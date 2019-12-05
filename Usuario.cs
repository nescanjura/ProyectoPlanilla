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
