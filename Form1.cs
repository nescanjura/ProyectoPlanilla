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
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
                FrmUsuario Nuevo = new FrmUsuario();
                Nuevo.MdiParent = this;
                Nuevo.Show();
            
        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado Nuevo = new FrmEmpleado();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void gERENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerencia Nuevo = new FrmGerencia();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void gENERARPLANILLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanilla Nuevo = new FrmPlanilla();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void pLANILLAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void hISTORICOPLANILLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta Nuevo = new FrmConsulta();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }
    }
}
