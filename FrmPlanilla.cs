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
        Planilla pln = new Planilla();
        List<Planilla> planillas = new List<Planilla>();
        FrmCrearPlanilla formPlanilla;

        public FrmPlanilla()
        {
            InitializeComponent();
        }

        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            DgvPlanilla.Rows.Clear();
            planillas = pln.ObtenerTodo();
            int i = 0;
            foreach (Planilla p in planillas)
            {
                DgvPlanilla.Rows.Insert(i++, new object[] { i, p.Nombre, p.Fecha.ToString("MMMM yyyy") });
                DgvPlanilla.Rows[i - 1].Tag = p.Id;
            }
        }

        private void CmdCrearPlanilla_Click(object sender, EventArgs e)
        {
            InicializarFormRegistro();
        }

        private void DgvPlanilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 3) return;

            var fila = ((DataGridView)sender).Rows[e.RowIndex];
            int idRegistro = (int)fila.Tag;

            pln = pln.Obtener(idRegistro);

            if (e.ColumnIndex == 3)
            {
                FrmDetaPlanilla det = new FrmDetaPlanilla(pln.Id.Value);
                det.Show();
            }

            if (e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show($"¿Desea eliminar la planilla con toda la información generada?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (pln.Eliminar())
                        MessageBox.Show("¡Se eliminó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.CargarDatos();
                }
            }
        }

        private void InicializarFormRegistro(int id = 0)
        {
            formPlanilla = new FrmCrearPlanilla();
            formPlanilla.FormClosed += new FormClosedEventHandler(this.FormCerrado);
            formPlanilla.Show();
        }

        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            this.CargarDatos();
        }
    }
}
