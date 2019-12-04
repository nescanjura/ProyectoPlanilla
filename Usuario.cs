using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlanilla
{
    class Usuario
    {
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

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string clave;

        public string Clave
        {
            set { clave = value; }
        }

        private Boolean activo;

        public Boolean Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public static void ObtenerPorId(int id)
        {
            
        }
    }
}
