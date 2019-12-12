using System.Data.OleDb;
using System.Configuration;

namespace ProyectoPlanilla
{
    // Manejo de conexión a BD utilizando el patrón Singleton
    public class Conexion
    {
        private static Conexion conexion;

        private Conexion() { } // No se debe permitir hacer instancias directamente

        public static Conexion ObtenerInstancia() // Devolver una única instancia siempre
        {
            if (conexion == null)
                conexion = new Conexion();

            return conexion;
        }

        // Devolver la conexión a la base de datos
        public OleDbConnection ObtenerConexion()
        {
            // La cadena de conexión está en un ConnectionString
            string cadena = ConfigurationManager.ConnectionStrings["conexionPlanilla"].ConnectionString;
            OleDbConnection cnx = new OleDbConnection(cadena); // Crear la conexión
            return cnx; // Devolver la conexión
        }
    }
}