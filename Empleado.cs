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
        const string TABLA = "Empleado";
        Dictionary<string, object> parametros;
        JArray elementos = null;
        string campos = "*";
        string condiciones = "";


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

        public Empleado Obtener(int id)
        {
            condiciones = $"ID = {id}";
            string str = Ejecutor.Consultar(TABLA, campos, condiciones);
            elementos = JArray.Parse(str);

            var first = elementos.First;

            return new Empleado()
            {
                id = (int)first["Id"],
                Nombre = first["nombre"].ToString(),
                Apellido = first["apellido"].ToString(),
                FechaNacimiento = Convert.ToDateTime(first["fechaNacimiento"].ToString()),
                Email = first["email"].ToString(),
                Direccion = first["direccion"].ToString(),
                Telefono = first["telefono"].ToString(),
                sueldoBase = Convert.ToDouble(first["sueldoBase"].ToString()),
                //Estado = (bool)first["estado"]
            };
        }

        public int Agregar()
        {
            parametros = new Dictionary<string, object>()
            {
                { "nombre", this.nombre },
                { "apellido", this.apellido },
                { "fechaNacimiento", this.fechaNacimiento.ToString("dd/MM/yyyy") },
                { "sexo", this.sexo },
                { "email", this.email },
                { "direccion", this.direccion },
                { "telefono", this.telefono },
                { "sueldoBase", this.sueldoBase },
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
                { "apellido", this.apellido },
                { "fechaNacimiento", this.fechaNacimiento.ToString("dd/MM/yyyy") },
                { "sexo", this.sexo },
                { "email", this.email },
                { "direccion", this.direccion },
                { "telefono", this.telefono },
                { "sueldoBase", this.sueldoBase },
            };

            return Ejecutor.Actualizar(TABLA, parametros, condiciones);
        }

        public List<Empleado> ObtenerTodo()
        {
            List<Empleado> resultado = new List<Empleado>();
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
