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
    public partial class FrmPlanilla : Form
    {
        public FrmPlanilla()
        {
            InitializeComponent();
        }

        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoPlanillaDataSet.Planilla' Puede moverla o quitarla según sea necesario.
            this.planillaTableAdapter.Fill(this.proyectoPlanillaDataSet.Planilla);

        }

        private void CmdCrearPlanilla_Click(object sender, EventArgs e)
        {
            FrmCrearPlanilla Nuevo= new FrmCrearPlanilla();
            Nuevo.Show();
        }
    }
}
