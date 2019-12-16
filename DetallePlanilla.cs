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


        public double Isss
        {
            get { return DescuentoIsss(); }
        }


        public double AfpEmpleado
        {
            get { return sueldoBase * 0.725; }
        }


        public  double AfpEmpleador
        {
            get { return sueldoBase * 0.775; }
        }


        public double Renta
        {
            get { return DescuentoRenta(); }
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
            set { idEmpleado = value; }
        }

        private int idPlanilla;

        public int IdPlanilla
        {
            get { return idPlanilla; }
            set { idPlanilla = value; }
        }
        #endregion

        #region Métodos
        private double DescuentoIsss()
        {
            Dictionary<Func<double, bool>, double> map = new Dictionary<Func<double, bool>, double>()
            {
                { d => d > 0 && d <= 685.71, 20.57 },
                { d => d > 685.71 && d <= 700, 21 },
                { d => d > 700 && d <= 750, 22.5 },
                { d => d > 750 && d <= 800, 24 },
                { d => d > 800 &&d <= 850, 25.5 },
                { d => d > 850 && d <= 900, 27 },
                { d => d > 900 && d <= 950, 28.5 },
                { d => d > 950, 30 }
            };

            var key = map.Keys.Single(test => test(this.sueldoBase));
            return map[key];
        }

        private double DescuentoRenta()
        {
            Dictionary<Func<double, bool>, double> map = new Dictionary<Func<double, bool>, double>()
            {
                { d => d >= 0.01 && d <= 487.6, 0 },
                { d => d > 487.6 && d <= 642.85, sueldoBase * 0.1 + 17.48 },
                { d => d > 642.85 && d <= 915.81, sueldoBase * 0.1 + 32.70 },
                { d => d > 915.81 && d <= 2058.67, sueldoBase * 0.2 + 60 },
                { d => d > 2058.67, sueldoBase * 0.3 + 288.57 }
            };

            var key = map.Keys.Single(test => test(this.sueldoBase));
            return map[key];
        }

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
                Fecha = (DateTime)first["fecha"],
                idEmpleado = (int)first["idEmpleado"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "sueldoBase", this.SueldoBase },
                { "isss", this.Isss },
                { "afpEmpleado", this.AfpEmpleado },
                { "afpEmpleador", this.AfpEmpleador },
                { "renta", this.Renta },
                { "fecha", this.fecha.ToString("dd/MM/yyyy") },
                { "idPlanilla", this.idPlanilla },
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
                        sueldoBase = (double)el["sueldoBase"],
                        fecha = (DateTime)el["fecha"],
                        idEmpleado = (int)el["idEmpleado"],
                        idPlanilla = (int)el["idPlanilla"]
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return resultado;
        }

        public List<DetallePlanilla> ObtenerPorEmpleadoMes(int id, DateTime mes)
        {
            List<DetallePlanilla> resultado = new List<DetallePlanilla>();
            condiciones = $"idEmpleado = {id} AND Month(fecha) = {mes.Month} AND Year(fecha) = {mes.Year}";
            try
            {
                string str = Ejecutor.Consultar(TABLA, campos, condiciones);
                elementos = JArray.Parse(str);

                foreach (JObject el in elementos)
                {
                    resultado.Add(new DetallePlanilla()
                    {
                        id = (int)el["id"],
                        sueldoBase = (double)el["sueldoBase"],
                        fecha = (DateTime)el["fecha"],
                        idEmpleado = (int)el["idEmpleado"],
                        idPlanilla = (int)el["idPlanilla"]
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

        public Empleado ObtenerEmpleado()
        {
            if (id == null) return null;

            return new Empleado().Obtener(idEmpleado);
        }

        public Planilla ObtenerPlanilla()
        {
            if (id == null) return null;

            return new Planilla().Obtener(idPlanilla);
        }
        #endregion
    }
}
