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
    public partial class FrmCrearPlanilla : Form
    {
        Planilla pln = new Planilla();
        public FrmCrearPlanilla()
        {
            InitializeComponent();
        }

        private void CmdLImpiarPlanilla_Click(object sender, EventArgs e)
        {
            TxtNombrePlanilla.Text = string.Empty;
        }

        private void CmdNuevoPlanilla_Click(object sender, EventArgs e)
        {
            pln = new Planilla()
            {
                Nombre = TxtNombrePlanilla.Text,
                Fecha = DtpFechaPlanilla.Value
            };

            int idNuevo = pln.Agregar();
            if (idNuevo > 0)
            {
                FrmDetaPlanilla det = new FrmDetaPlanilla(idNuevo);
                det.Show();
            }   
            else
                MessageBox.Show("No se pudo registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.Close();
        }
    }
}
