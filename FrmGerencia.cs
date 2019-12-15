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
    public partial class FrmGerencia : Form
    {
        public FrmGerencia()
        {
            InitializeComponent();
        }

        private void FrmGerencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoPlanillaDataSet.Gerencia' Puede moverla o quitarla según sea necesario.
            this.gerenciaTableAdapter.Fill(this.proyectoPlanillaDataSet.Gerencia);

        }

        private void CmdCrearGerencia_Click(object sender, EventArgs e)
        {
            FrmCrearGerencia Nuevo = new FrmCrearGerencia();
            Nuevo.Show();
        }
    }
}
