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
                Nombre = "Oscar",
                Apellido = "Peña",
                Direccion = "San Salvador",
                Email = "oscar01@gmail.com",
                FechaNacimiento = new DateTime(1997, 12, 02),
                SueldoBase = 520,
                Telefono = "7121-0020",
                Sexo = "Hombre"
            };
            //emp.Agregar();
            //emp.ObtenerTodo();
        }
    }
}
