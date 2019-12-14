using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Empleado : Persona
    {
        private const string TABLA = "Empleado";
        Dictionary<string, object> parametros;


        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
        }

        private double sueldoBase;

        public double SueldoBase
        {
            get { return sueldoBase; }
            set { sueldoBase = value; }
        }


        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "apellido", this.apellido },
                { "fechaNacimiento", this.fechaNacimiento.ToString("dd/MM/yyyy") },
                { "email", this.email },
                { "direccion", this.direccion },
                { "telefono", this.telefono },
                { "sueldoBase", this.sueldoBase },
            };

            return Ejecutor.Insertar(TABLA, parametros);
        }

        public List<Empleado> ObtenerTodo()
        {
            List<Empleado> resultado = new List<Empleado>();
            JArray elementos = null;
            string campos = "*";
            try
            {
                string str = Ejecutor.Consultar(TABLA, campos);
                elementos = JArray.Parse(str);

                foreach (JObject el in elementos)
                {
                    resultado.Add(new Empleado()
                    {
                        Nombre = el["nombre"].ToString(),
                        Apellido = el["apellido"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(el["fechaNacimiento"].ToString()),
                        Email = el["email"].ToString(),
                        Direccion = el["direccion"].ToString(),
                        Telefono = el["telefono"].ToString(),
                        sueldoBase = Convert.ToDouble(el["sueldoBase"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return resultado;
        }

    }
}
