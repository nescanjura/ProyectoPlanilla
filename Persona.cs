using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Persona
    {
        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        protected string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        protected Boolean estado;

        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
