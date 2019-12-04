using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Gerencia
    {
        private int isUsuario;

        public int IdUsuario
        {
            get { return isUsuario; }
            set { isUsuario = value; }
        }

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
        }


        private int id;

        public int Id
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

    }
}
