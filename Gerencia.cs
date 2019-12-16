using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Gerencia
    {
        const string TABLA = "Gerencia";
        Dictionary<string, object> parametros;
        JArray elementos = null;
        string campos = "*";
        string condiciones = "";

        private int? id;

        public int? Id
        {
            get { return id; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Boolean derechoBono;

        public Boolean DerechoBono
        {
            get { return derechoBono; }
            set { derechoBono = value; }
        }

        private Boolean horasExtras;

        public  Boolean HorasExtras 
        {
            get { return horasExtras; }
            set { horasExtras = value; }
        }

        private double? porcentajeBono;

        public double? PorcentajeBono
        {
            get { return porcentajeBono; }
            set { porcentajeBono = value; }
        }

        public Gerencia Obtener(int id)
        {
            condiciones = $"id = {id}";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            var first = elementos.First;

            return new Gerencia()
            {
                id = (int)first["id"],
                Nombre = (string)first["nombre"],
                DerechoBono = (bool)first["derechoBono"],
                HorasExtras = (bool)first["horasExtras"],
                PorcentajeBono = (double)first["porcentajeBono"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "derechoBono", this.derechoBono },
                { "horasExtras", this.horasExtras },
                { "porcentajeBono", this.porcentajeBono }
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
                { "derechoBono", this.derechoBono },
                { "horasExtras", this.horasExtras },
                { "porcentajeBono", this.porcentajeBono }
            };

            return Ejecutor.Actualizar(TABLA, parametros, condiciones);
        }

        public List<Gerencia> ObtenerTodo()
        {
            List<Gerencia> resultado = new List<Gerencia>();
            try
            {
                string str = Ejecutor.Consultar(TABLA, campos);
                elementos = JArray.Parse(str);

                foreach (JObject el in elementos)
                {
                    resultado.Add(new Gerencia()
                    {
                        id = (int)el["id"],
                        Nombre = el["nombre"].ToString(),
                        DerechoBono = (bool)el["derechoBono"],
                        HorasExtras = (bool)el["horasExtras"],
                        PorcentajeBono = (double)el["porcentajeBono"]
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

    }
}
