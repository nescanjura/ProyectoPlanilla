using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Planilla
    {
        const string TABLA = "Planilla";
        Dictionary<string, object> parametros;
        JArray elementos = null;
        string campos = "*";
        string condiciones = "";

        #region Propiedades
        private int? id;

        public int? Id
        {
            get { return id; }
            set { id = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
        }
        #endregion

        #region Métodos
        public Planilla Obtener(int id)
        {
            condiciones = $"ID = {id}";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            var first = elementos.First;

            return new Planilla()
            {
                id = (int)first["id"],
                Nombre = (string)first["nombre"],
                Fecha = (DateTime)first["fecha"],
                idUsuario = (int)first["idUsuario"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "fecha", this.fecha.ToString("dd/MM/yyyy") },
                { "idUsuario", this.idUsuario }
            };

            return Ejecutor.Insertar(TABLA, parametros);
        }

        public bool Actualizar()
        {
            if (id == null) return false;

            condiciones = $"id = {this.id}";
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "fecha", this.fecha.ToString("dd/MM/yyyy") }
            };

            return Ejecutor.Actualizar(TABLA, parametros, condiciones);
        }

        public List<Planilla> ObtenerTodo()
        {
            List<Planilla> resultado = new List<Planilla>();
            try
            {
                string str = Ejecutor.Consultar(TABLA, campos);
                elementos = JArray.Parse(str);

                foreach (JObject el in elementos)
                {
                    resultado.Add(new Planilla()
                    {
                        id = (int)el["id"],
                        Nombre = el["nombre"].ToString(),
                        Fecha = Convert.ToDateTime(el["fechaNacimiento"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return resultado;
        }

        public bool Eliminar()
        {
            if (id == null) return false;

            return Ejecutor.Eliminar(TABLA, $"Id = {this.id}"); // Eliminar el registro de la base
        }

        public Usuario ObtenerUsuario()
        {
            if (id == null) return null;

            return new Usuario().Obtener(this.idUsuario);
        }
        #endregion
    }
}
