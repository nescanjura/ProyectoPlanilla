using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlanilla
{
    public partial class Login : Form
    {
        Usuario usr = new Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            usr.Login = TxtLogin.Text;
            usr.Clave = TxtClave.Text;

            var usuario = usr.LogIn();
            if (usuario != null)
            {
                Sesion.usuario = usuario;
                FrmPantallaPrincipal main = new FrmPantallaPrincipal();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
