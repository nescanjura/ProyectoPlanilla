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

        protected string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        protected string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        protected Boolean estado;

        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
