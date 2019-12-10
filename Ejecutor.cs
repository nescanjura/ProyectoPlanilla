using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;

namespace ProyectoPlanilla
{
    public class Ejecutor
    {
        public static int Insertar(string tabla, Dictionary<string, string> parametros)
        {
            Conexion conex = Conexion.ObtenerInstancia();
            string claves = "", claves2 = "";

            int i = 0;
            foreach (string key in parametros.Keys)
            {
                claves += $"[{key}]";
                claves2 += $"@{key}";
                i++;
                if (i < parametros.Count) {
                    claves += ",";
                    claves2 += ",";
                }
            }


            Debug.WriteLine(claves);
            Debug.WriteLine(claves2);

            OleDbConnection cnx = conex.ObtenerConexion();
            try
            {
                cnx.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            //using (OleDbCommand cmd = new OleDbCommand())
            //{
            //cmd.CommandText = $"INSERT INTO {tabla} ({campos}) VALUES({valores})";
            //     cmd.CommandText =
            //   "INSERT INTO bookRated " +
            //   "([title], [rating],  [review], [frnISBN], [frnUserName]) " +
            //   "VALUES(@title, @rating, @review, @isbn, @username)";

            //     // add named parameters
            //     cmd.Parameters.AddRange(new OleDbParameter[]
            //     {
            //    new OleDbParameter("@title", title),
            //    new OleDbParameter("@rating", rating),
            //    ...
            //});

            //     // execute
            //     cmd.ExecuteNonQuery();

            // }

            return 0;
        }
    }
}
