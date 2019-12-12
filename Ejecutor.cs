using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;

namespace ProyectoPlanilla
{
    // Clase encargada de ejecutar las instrucciones SQL
    public class Ejecutor
    {
        // Definir los tipos de datos en C# y su equivalencia en tipo OleDbType
        private static OleDbType ConvertirTipo(object obj)
        {
            var map = new Dictionary<Func<object, bool>, OleDbType>()
            {
                { d => d.GetType() == typeof(Int16), OleDbType.Binary },
                { d => d.GetType() == typeof(Int32), OleDbType.Integer },
                { d => d.GetType() == typeof(Int64), OleDbType.BigInt },
                { d => d.GetType() == typeof(Double), OleDbType.Double },
                { d => d.GetType() == typeof(DateTime), OleDbType.DBDate },
                { d => d.GetType() == typeof(Decimal), OleDbType.Decimal },
                { d => d.GetType() == typeof(String), OleDbType.VarChar },
            };

            var key = map.Keys.Single(test => test(obj));
            OleDbType value = map[key];

            return value;
        }

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
                dbParams[i] = new OleDbParameter($"{key}", Ejecutor.ConvertirTipo(valor), valor.ToString().Length); // Crear el parámetro para SQL
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
                        cmd.Parameters[p.Key].Value = p.Value;

                    cmd.Prepare(); // Preparar la instrucción sql
                    cmd.ExecuteScalar(); // Ejecutar el SQL y devolver id del registro insertado
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}"); // Mostrar mensaje de error en caso que haya
                }
            }

            return idRegistro; // Devolver ID del registro insertado (Hace falta)
        }
    }
}
