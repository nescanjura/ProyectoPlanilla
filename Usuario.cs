using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Usuario : Persona
    {
        const string TABLA = "Usuario";
        const string CONDICION_ESTADO = "estado = true";
        Dictionary<string, object> parametros;
        JArray elementos = null;
        string campos = "*";
        string condiciones = "";

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string clave;

        public string Clave
        {
            set { clave = value; }
        }

        private Boolean activo;

        public Boolean Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public Usuario Obtener(int id)
        {
            condiciones = $"ID = {id} AND {CONDICION_ESTADO}";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            var first = elementos.First;

            return new Usuario()
            {
                id = (int)first["id"],
                Nombre = (string)first["nombre"],
                Login = (string)first["login"],
                Activo = (bool)first["activo"],
                Estado = (bool)first["estado"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "login", this.login }
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
                { "login", this.login }
            };

            return Ejecutor.Actualizar(TABLA, parametros, condiciones);
        }

        public List<Usuario> ObtenerTodo()
        {
            List<Usuario> resultado = new List<Usuario>();
            try
            {
                string str = Ejecutor.Consultar(TABLA, campos, CONDICION_ESTADO);
                elementos = JArray.Parse(str);

                foreach (JObject el in elementos)
                {
                    resultado.Add(new Usuario()
                    {
                        id = (int)el["id"],
                        Nombre = el["nombre"].ToString(),
                        Login = el["login"].ToString(),
                        Activo = (bool)el["activo"],
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return resultado;
        }

        public bool Eliminar(bool quitar = false)
        {
            if (id == null) return false;

            if (quitar)
                return Ejecutor.Eliminar(TABLA, $"Id = {this.id}"); // Eliminar el registro de la base
            else
                return Ejecutor.Actualizar(TABLA, new Dictionary<string, object>() { { "estado", false } }, $"Id = {this.id}"); // Cambiar estado a false
        }
    }
}
