using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Diagnostics;

namespace ProyectoPlanilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleado emp = new Empleado()
            {
                Nombre = "Marcela",
                Apellido = "Orellana",
                Direccion = "La Libertad",
                Email = "marcela@hotmail.com",
                FechaNacimiento = new DateTime(1994, 02, 12),
                SueldoBase = 750,
                Telefono = "7232-1209",
                Sexo = "Mujer"
            };
            emp.Agregar();

            //Conexion conexion = Conexion.ObtenerInstancia();
            //Debug.WriteLine(Conexion.Consultar("nombre", "usuario"));
            //var x = Conexion.Insertar("usuario", "login, clave, nombre", "'nestor2','cualquiera2', 'nestor2'");
            //Debug.WriteLine(x);
            //Gerencia ger = new Gerencia();
            //var cadena = ConfigurationManager.ConnectionStrings["conexionPlanilla"].ConnectionString;
            //Debug.WriteLine("Cadenas de conexion: ");
            //Debug.WriteLine(cadena);
            //OleDbConnection cnx = new OleDbConnection(cadena);
            //cnx.Open();
            //Debug.WriteLine(cnx);
        }
    }
}
