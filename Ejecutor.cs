using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;
using Newtonsoft.Json;
using System.IO;

namespace ProyectoPlanilla
{
    // Clase encargada de ejecutar las instrucciones SQL
    public class Ejecutor
    {
        // Definir los tipos de datos en C# y su equivalencia en tipo OleDbType
        private static OleDbType ConvertirTipo(object obj)
        {
            if (obj == null || obj.ToString().Length == 0) return OleDbType.Variant;

            var map = new Dictionary<Func<object, bool>, OleDbType>()
            {
                { d => d.GetType() == typeof(Int16), OleDbType.Binary },
                { d => d.GetType() == typeof(Int32), OleDbType.Integer },
                { d => d.GetType() == typeof(Int64), OleDbType.BigInt },
                { d => d.GetType() == typeof(Double), OleDbType.Double },
                { d => d.GetType() == typeof(DateTime), OleDbType.DBDate },
                { d => d.GetType() == typeof(Decimal), OleDbType.Decimal },
                { d => d.GetType() == typeof(String), OleDbType.VarChar },
                { d => d.GetType() == typeof(Boolean), OleDbType.Boolean },
            };

            var key = map.Keys.Single(test => test(obj));
            OleDbType value = map[key];

            return value;
        }

        private static int ObtenerLongitud(object obj)
        {
            int result = 1;

            if (obj != null)
            {
                int len = obj.ToString().Length;
                result = (len > 0) ? len : 1;
            }
            return result;
        }

        /// <summary>
        /// Crea un nuevo registro en la base de datos según los parámetros enviados
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public static int Insertar(string tabla, Dictionary<string, object> parametros)
        {
            int idRegistro = 0; // El id del registro insertado
            object valor = ""; // El valor del parámetro al recorrer el diccionario
            string campos = "", valores = ""; // Mapeo de campos y parámetros para construir SQL
            Conexion conex = Conexion.ObtenerInstancia(); // Obtener la instancia de la clase Conexión
            OleDbConnection cnx = conex.ObtenerConexion(); // Obtener la conexión a la BD
            OleDbParameter[] dbParams = new OleDbParameter[parametros.Count]; // Crear el arreglo para los parámetros

            int i = 0;
            foreach (string key in parametros.Keys) // Recorrer los parámetros y asignar datos a variables
            {
                valor = parametros[key]; // Asignar el valor del parámetro
                dbParams[i] = new OleDbParameter($"{key}", Ejecutor.ConvertirTipo(valor), Ejecutor.ObtenerLongitud(valor)); // Crear el parámetro para SQL
                campos += $"{key}"; // El nombre del campo
                valores += "?"; // Se agrega uno por cada parámetro
                i++;
                if (i < parametros.Count) { // Si no se ha llegado al último parámetro, se agrega ',' a los campos y parámetros
                    campos += ",";
                    valores += ",";
                }
            }

            cnx.Open(); // Abrir la conexión

            using (OleDbCommand cmd = cnx.CreateCommand())
            {
                try
                {
                    cmd.CommandText = $"INSERT INTO {tabla} ({campos}) VALUES ({valores})"; // Consulta SQL
                    cmd.Parameters.AddRange(dbParams); // Agregar los parámetros al comando
                    
                    foreach (var p in parametros) // Agregar los valores de los parámetros
                        cmd.Parameters[p.Key].Value = p.Value ?? DBNull.Value;

                    cmd.Prepare(); // Preparar la instrucción sql
                    cmd.ExecuteNonQuery(); // Ejecutar el SQL
                    cmd.CommandText = "SELECT @@Identity"; // Consulta para obtener el último registro insertado
                    idRegistro = (int)cmd.ExecuteScalar(); // Obtener el id del registro insertado
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}"); // Mostrar mensaje de error en caso que haya
                }
            }

            return idRegistro; // Devolver ID del registro insertado
        }

        /// <summary>
        /// Modifica datos de la base de datos según los parámetros enviados
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="parametros"></param>
        /// <param name="condiciones"></param>
        /// <returns></returns>
        public static bool Actualizar(string tabla, Dictionary<string, object> parametros, string condiciones)
        {
            bool resultado = false;
            object valor = ""; // El valor del parámetro al recorrer el diccionario
            string valoresParams = ""; // Variable para asignar el nombre del campo y su parámetro
            Conexion conex = Conexion.ObtenerInstancia(); // Obtener la instancia de la clase Conexión
            OleDbConnection cnx = conex.ObtenerConexion(); // Obtener la conexión a la BD
            OleDbParameter[] dbParams = new OleDbParameter[parametros.Count]; // Crear el arreglo para los parámetros

            int i = 0;
            foreach (string key in parametros.Keys)
            {
                valor = parametros[key]; // Asignar el valor del parámetro
                dbParams[i] = new OleDbParameter($"{key}", Ejecutor.ConvertirTipo(valor), Ejecutor.ObtenerLongitud(valor)); // Crear el parámetro para SQL
                valoresParams += $"{key} = ?"; // El nombre del campo con su parámetro
                i++;
                if (i < parametros.Count)
                    valoresParams += ",";
            }

            cnx.Open(); // Abrir la conexión

            using (OleDbCommand cmd = cnx.CreateCommand())
            {
                try
                {
                    cmd.CommandText = $"UPDATE {tabla} SET {valoresParams} WHERE {condiciones}"; // Consulta SQL
                    cmd.Parameters.AddRange(dbParams); // Agregar los parámetros al comando

                    foreach (var p in parametros) // Agregar los valores de los parámetros
                        cmd.Parameters[p.Key].Value = p.Value ?? DBNull.Value;

                    cmd.Prepare(); // Preparar la instrucción sql
                    resultado = cmd.ExecuteNonQuery() == 1 ? true : false; // Ejecutar el SQL
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}"); // Mostrar mensaje de error en caso que haya
                }

                return resultado;
            }
        }

        /// <summary>
        /// Devuelve el conjunto de elementos encontrados en formato JSON
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="campos"></param>
        /// <param name="condiciones"></param>
        /// <returns></returns>
        public static string Consultar(string tabla, string campos, string condiciones = "1=1")
        {
            Conexion conex = Conexion.ObtenerInstancia(); // Obtener la instancia de la clase Conexión
            OleDbConnection cnx = conex.ObtenerConexion(); // Obtener la conexión a la BD
            OleDbDataReader reader; // Objeto encarado de leer los registros encontrados

            cnx.Open(); // Abrir la conexión
            using (OleDbCommand cmd = cnx.CreateCommand()) // Utilizar el recurso y después eliminarlo
            {
                StringBuilder sb = new StringBuilder(); // Auxiliar para crear el StringWriter
                StringWriter sw = new StringWriter(sb); // Utilizado para generarel objeto JSON
                cmd.CommandText = $"SELECT {campos} FROM {tabla} WHERE {condiciones}"; // Consulta SQL
                reader = cmd.ExecuteReader(); // Ejecutar el lector

                using (JsonWriter jsonWriter = new JsonTextWriter(sw)) // Crear el objeto JSON
                {
                    jsonWriter.WriteStartArray(); // Inicializar el arreglo

                    while (reader.Read()) // Leer los registros encontrados
                    {
                        jsonWriter.WriteStartObject(); // Crear un nuevo objeto en el arreglo JSON

                        int fields = reader.FieldCount; // Cantidad de campos del reader

                        for (int i = 0; i < fields; i++) // Recorrer los campos
                        {
                            jsonWriter.WritePropertyName(reader.GetName(i)); // Nombre de la propiedad del objeto
                            jsonWriter.WriteValue(reader[i]); // Valor de la propiedad del objeto
                        }

                        jsonWriter.WriteEndObject(); // Finalizar objeto creado
                    }

                    jsonWriter.WriteEndArray(); // FInalizar el arreglo JSON
                }

                return sw.ToString(); // Devolver el arreglo JSON como string
            };
        }

        /// <summary>
        /// Elimina un registro de la base de datos y devuelve falso si no se pudo eliminar el registro o verdadero en caso que se haya podido
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="condicion"></param>
        /// <returns></returns>
        public static bool Eliminar(string tabla, string condicion)
        {
            bool resultado = false;
            Conexion conex = Conexion.ObtenerInstancia(); // Obtener la instancia de la clase Conexión
            OleDbConnection cnx = conex.ObtenerConexion(); // Obtener la conexión a la BD

            cnx.Open(); // Abrir la conexión
            using (OleDbCommand cmd = cnx.CreateCommand())
            {
                try
                {
                    cmd.CommandText = $"DELETE FROM {tabla} WHERE {condicion}";
                    resultado = cmd.ExecuteNonQuery() == 1 ? true : false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}");
                }
            }

            return resultado;
        }
    }
}
