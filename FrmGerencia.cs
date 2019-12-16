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
    public partial class FrmGerencia : Form
    {
        Gerencia ger = new Gerencia();
        List<Gerencia> gerencias = new List<Gerencia>();
        FrmCrearGerencia formGerencia;

        public FrmGerencia()
        {
            InitializeComponent();
        }

        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            this.CargarDatos();
        }
        private void FrmGerencia_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            DgvGerencia.Rows.Clear();
            gerencias = ger.ObtenerTodo();
            int i = 0;
            foreach (Gerencia ger in gerencias)
            {
                DgvGerencia.Rows.Insert(i++, new object[] { 
                    i, 
                    ger.Nombre, 
                    ger.HorasExtras ? Resources.check : Resources.cancel,
                    ger.DerechoBono ? Resources.check : Resources.cancel,
                    ger.PorcentajeBono
                });
                DgvGerencia.Rows[i - 1].Tag = ger.Id;
            }
        }

        private void CmdCrearGerencia_Click(object sender, EventArgs e)
        {
            InicializarFormRegistro();
        }

        private void InicializarFormRegistro(int idUser = 0)
        {
            if (idUser > 0)
                formGerencia = new FrmCrearGerencia(idUser);
            else
                formGerencia = new FrmCrearGerencia();
            formGerencia.FormClosed += new FormClosedEventHandler(this.FormCerrado);
            formGerencia.Show();
        }

        private void DgvGerencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 6) return;

            var fila = ((DataGridView)sender).Rows[e.RowIndex];
            int idRegistro = (int)fila.Tag;

            ger = ger.Obtener(idRegistro);

            if (e.ColumnIndex == 5)
            {
                InicializarFormRegistro(ger.Id.Value);
            }

            if (e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show($"¿Desea eliminar el registro {ger.Nombre}?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (ger.Eliminar())
                        MessageBox.Show("¡Se eliminó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.CargarDatos();
                }
            }

        }
    }
}
