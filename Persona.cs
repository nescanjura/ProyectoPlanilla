using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Persona
    {
        protected int? id;

        public int? Id
        {
            get { return id; }
        }

        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        protected Boolean estado;

        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
