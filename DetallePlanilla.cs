using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class DetallePlanilla
    {
        const string TABLA = "DetallePlanilla";
        Dictionary<string, object> parametros;
        JArray elementos = null;
        string campos = "*";
        string condiciones = "";

        #region Propiedades
        private int? id;

        public int? Id
        {
            get { return id; }
        }

        private double sueldoBase;

        public double SueldoBase
        {
            get { return sueldoBase; }
            set { sueldoBase = value; }
        }

        private double isss;

        public double Isss
        {
            get { return isss; }
            set { isss = value; }
        }

        private double afpEmpleado;

        public double AfpEmpleado
        {
            get { return afpEmpleado; }
            set { afpEmpleado = value; }
        }

        private double afpEmpleador;

        public  double AfpEmpleador
        {
            get { return afpEmpleador; }
            set { afpEmpleador = value; }
        }

        private double renta;

        public double Renta
        {
            get { return renta; }
            set { renta = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
        }

        #endregion

        #region Métodos
        public DetallePlanilla Obtener(int id)
        {
            condiciones = $"ID = {id}";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            var first = elementos.First;

            return new DetallePlanilla()
            {
                id = (int)first["id"],
                SueldoBase = (double)first["sueldoBase"],
                Isss = (double)first["isss"],
                AfpEmpleado = (double)first["afpEmpleado"],
                AfpEmpleador = (double)first["afpEmpleador"],
                Renta = (double)first["renta"],
                Fecha = (DateTime)first["fecha"],
                idEmpleado = (int)first["idEmpleado"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "isss", this.Isss },
                { "sueldoBase", this.SueldoBase },
                { "afpEmpleado", this.AfpEmpleado },
                { "afpEmpleados", this.AfpEmpleador },
                { "renta", this.Renta },
                { "fecha", this.fecha.ToString("dd/MM/yyyy") },
                { "idEmpleado", this.IdEmpleado }
            };

            return Ejecutor.Insertar(TABLA, parametros);
        }

        public bool Actualizar()
        {
            if (id == null) return false;

            condiciones = $"id = {this.id}";
            parametros = new Dictionary<string, object>()
            {
                { "isss", this.Isss },
                { "sueldoBase", this.SueldoBase },
                { "afpEmpleado", this.AfpEmpleado },
                { "afpEmpleador", this.AfpEmpleador },
                { "renta", this.Renta }
            };

            return Ejecutor.Actualizar(TABLA, parametros, condiciones);
        }

        public List<DetallePlanilla> ObtenerPorPlanilla(int id)
        {
            List<DetallePlanilla> resultado = new List<DetallePlanilla>();
            condiciones = $"idPlanilla = {id}";
            try
            {
                string str = Ejecutor.Consultar(TABLA, campos, condiciones);
                elementos = JArray.Parse(str);

                foreach (JObject el in elementos)
                {
                    resultado.Add(new DetallePlanilla()
                    {
                        id = (int)el["id"],
                        Isss = (double)el["isss"],
                        AfpEmpleado = (double)el["afpEmpleado"],
                        AfpEmpleador = (double)el["afpEmpleador"],
                        Renta = (double)el["renta"],
                        fecha = (DateTime)el["renta"],
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
        #endregion
    }
}
