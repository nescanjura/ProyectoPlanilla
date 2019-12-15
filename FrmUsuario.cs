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
        public FrmUsuario()
        {
      
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectoPlanillaDataSet);

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoPlanillaDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.proyectoPlanillaDataSet.Usuario);

        }



        private void CmdCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario Nuevo = new FrmCrearUsuario();
            Nuevo.Show();
        }
    }
}
