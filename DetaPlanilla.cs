using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class DetaPlanilla
    {
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

        private double sueldoBase;

        public double SueldoBase
        {
            get { return sueldoBase; }
            set { sueldoBase = value; }
        }

    }
}
