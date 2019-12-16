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
    public partial class FrmConsulta : Form
    {
        List<Empleado> empleados;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            empleados = new Empleado().ObtenerTodo();

            CmbEmpleadoConsulta.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                CmbEmpleadoConsulta.Items.Add(emp);
            }
            CmbEmpleadoConsulta.ValueMember = "id";
            CmbEmpleadoConsulta.DisplayMember = "nombreCompleto";
        }

        private void CmdImprimirConsulta_Click(object sender, EventArgs e)
        {
            if (CmbEmpleadoConsulta.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idEmpleado = ((Empleado)CmbEmpleadoConsulta.SelectedItem).Id.Value;
            FrmDetaPlanilla Nuevo = new FrmDetaPlanilla(idEmpleado, DtpConsultaInicio.Value);
            Nuevo.Show();
        }
    }
}
