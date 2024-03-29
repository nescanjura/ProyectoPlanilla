﻿using Newtonsoft.Json.Linq;
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

        public Usuario Obtener(int id)
        {
            condiciones = $"ID = {id}";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            if (elementos.Count != 1) return null;

            var first = elementos.First;

            return new Usuario()
            {
                id = (int)first["id"],
                Nombre = (string)first["nombre"],
                Login = (string)first["login"],
                Estado = (bool)first["estado"]
            };
        }

        public Usuario LogIn()
        {
            condiciones = $"login = '{login}' AND clave = '{clave}' AND estado = true";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            if (elementos.Count != 1) return null;

            var first = elementos.First;
            
            return new Usuario()
            {
                id = (int)first["id"],
                Nombre = (string)first["nombre"],
                Login = (string)first["login"],
                Estado = (bool)first["estado"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "login", this.login },
                { "clave", this.clave }
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

            if (this.ObtenerTodo().Count == 1) return false; // Porque no se puede quedar sin ningún usuario

            if (quitar)
                return Ejecutor.Eliminar(TABLA, $"Id = {this.id}"); // Eliminar el registro de la base
            else
                return Ejecutor.Actualizar(TABLA, new Dictionary<string, object>() { { "estado", false } }, $"Id = {this.id}"); // Cambiar estado a false
        }
    }
}
