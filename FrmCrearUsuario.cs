using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlanilla
{
    public partial class FrmCrearUsuario : Form
    {
        Usuario usr = new Usuario();
        public FrmCrearUsuario()
        {
            InitializeComponent();

            TxtClaveUsuario.Visible = true;
            TxtClaveUsuario.Visible = true;
            CmdNuevoUsuario.Text = "Nuevo";
        }

        public FrmCrearUsuario(int idUsuario)
        {
            InitializeComponent();

            usr = new Usuario().Obtener(idUsuario);
            TxtNombreUsuario.Text = usr.Nombre;
            TxtLoginUsuario.Text = usr.Login;
            LblClaveUsuario.Visible = false;
            TxtClaveUsuario.Visible = false;
            CmdNuevoUsuario.Text = "Actualizar";
        }

        private void CmdLImpiarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CmdNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Verifique la información ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usr.Id == null)
            {
                usr = new Usuario()
                {
                    Nombre = TxtNombreUsuario.Text,
                    Login = TxtLoginUsuario.Text,
                    Clave = TxtClaveUsuario.Text
                };

                if (usr.Agregar() > 0)
                    MessageBox.Show("¡Se registró el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                usr.Nombre = TxtNombreUsuario.Text;
                usr.Login = TxtLoginUsuario.Text;
                if (usr.Actualizar())
                    MessageBox.Show("¡Se actualizó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo actualizar la información del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Close();
        }

        private void LimpiarCampos()
        {
            foreach (TextBox txt in this.GbxDatosUsuario.Controls.OfType<TextBox>())
                txt.Text = string.Empty;
        }

        private bool validar()
        {
            foreach (TextBox txt in this.GbxDatosUsuario.Controls.OfType<TextBox>())
                if (txt.Visible && txt.Text.Length == 0) return false;

            return true;
        }
    }
}
