using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Diagnostics;

namespace ProyectoPlanilla
{
    public static class Conexion
    {

        public static OleDbConnection ObtenerConexion()
        {
            Gerencia ger = new Gerencia();
            var cadena = ConfigurationManager.ConnectionStrings["conexionPlanilla"].ConnectionString;

            OleDbConnection cnx = new OleDbConnection(cadena);
            return cnx;
        }

        public static OleDbDataReader Consultar(string campos, string tabla, string condicion = "1=1")
        {
            var cnx = Conexion.ObtenerConexion();
            string queryString = $"SELECT {campos} FROM {tabla} WHERE {condicion} ";
            Debug.WriteLine(queryString);
            OleDbCommand command = new OleDbCommand(queryString, cnx); 
            cnx.Open();
            
            OleDbDataReader reader = command.ExecuteReader();
            Debug.WriteLine(reader.FieldCount);
            return reader;

        }

        public static int Insertar(string tabla, string campos, string valores)
        {
            var cnx = Conexion.ObtenerConexion(); 
            string sql = $"INSERT INTO {tabla} ({campos}) values ({valores})";
            Debug.WriteLine(sql);
            
            OleDbCommand cmd = new OleDbCommand(sql, cnx);
            cnx.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
