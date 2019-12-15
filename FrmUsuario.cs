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
            usuarios = usr.ObtenerTodo();

            int i = 0;
            foreach (Usuario user in usuarios)
            {
                DgvUsuario.Rows.Insert(i++, new object[] { i, user.Nombre, user.Login, user.Activo ? Properties.Resources.check : Properties.Resources.cancel });
                DgvUsuario.Rows[i].Tag = user.Id;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
