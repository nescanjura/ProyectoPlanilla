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
    public partial class FrmEmpleado : Form
    {
        Empleado emp = new Empleado();
        List<Empleado> empleados = new List<Empleado>();
        FrmCrearEmpleado formEmpleado;

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            DgvEmpleado.Rows.Clear();
            empleados = emp.ObtenerTodo();
            int i = 0;
            foreach (Empleado emp in empleados)
            {
                DgvEmpleado.Rows.Insert(i++, new object[] { i, emp.Nombre, emp.Apellido, emp.Telefono, emp.Direccion, emp.Email, emp.SueldoBase, emp.ObtenerGerencia().Nombre, emp.ObtenerUsuario().Nombre });
                DgvEmpleado.Rows[i - 1].Tag = emp.Id;
            }
        }

        private void CmdCrearEmpleado_Click(object sender, EventArgs e)
        {
            InicializarFormRegistro();
        }

        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 9) return;

            var fila = ((DataGridView)sender).Rows[e.RowIndex];
            int idRegistro = (int)fila.Tag;

            emp = emp.Obtener(idRegistro);

            if (e.ColumnIndex == 9)
            {
                InicializarFormRegistro(emp.Id.Value);
            }

            if (e.ColumnIndex == 10)
            {
                DialogResult result = MessageBox.Show($"¿Desea eliminar el registro del empleado {emp.NombreCompleto}?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (emp.Eliminar())
                        MessageBox.Show("¡Se eliminó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.CargarDatos();
                }
            }
        }

        private void InicializarFormRegistro(int idEmp = 0)
        {
            if (idEmp > 0)
                formEmpleado = new FrmCrearEmpleado(idEmp);
            else
                formEmpleado = new FrmCrearEmpleado();
            formEmpleado.FormClosed += new FormClosedEventHandler(this.FormCerrado);
            formEmpleado.Show();
        }

        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            this.CargarDatos();
        }
    }
}
