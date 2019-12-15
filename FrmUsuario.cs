using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPlanilla.Properties;
using System.Diagnostics;
using System.Threading;

namespace ProyectoPlanilla
{
    public partial class FrmUsuario : Form
    {
        Usuario usr = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();

        public FrmUsuario()
        {      
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            DgvUsuario.Rows.Clear();
            usuarios = usr.ObtenerTodo();
            int i = 0;
            foreach (Usuario user in usuarios)
            {
                DgvUsuario.Rows.Insert(i++, new object[] { i, user.Nombre, user.Login });
                DgvUsuario.Rows[i-1].Tag = user.Id;
            }
        }

        private void ClicCelda(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            var fila = ((DataGridView)sender).Rows[e.RowIndex];
            int idRegistro = (int)fila.Tag;

            usr = usr.Obtener(idRegistro);

            if (e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show($"¿Desea eliminar la cuenta de usuario {usr.Login}?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (usr.Eliminar())
                        MessageBox.Show("¡Se eliminó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminarl el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.CargarDatos();
                }
            }

        }
    }
}
