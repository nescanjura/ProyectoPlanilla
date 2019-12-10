using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Empleado : Persona
    {
        private const string TABLA = "Empleado";
        Dictionary<string, string> parametros;


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
            parametros = new Dictionary<string, string>()
            {
                { "nombre", this.nombre },
                { "apellido", this.apellido },
                { "fechaNacimiento", this.fechaNacimiento.ToString("") },
                { "direccion", this.direccion },
                { "telefono", this.telefono },
                { "sueldoBase", this.sueldoBase.ToString() },
            };

            Ejecutor.Insertar(TABLA, parametros);

            return 0;
        }

    }
}
