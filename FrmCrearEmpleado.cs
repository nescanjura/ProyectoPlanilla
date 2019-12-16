using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlanilla
{
    public partial class FrmCrearEmpleado : Form
    {
        Empleado emp = new Empleado();
        List<Gerencia> gerencias;

        public FrmCrearEmpleado()
        {
            InitializeComponent();
            CargarGerencias();
            CmdNuevo.Text = "Nuevo";
        }

        public FrmCrearEmpleado(int idEmpleado)
        {
            InitializeComponent();
            CargarGerencias();

            emp = new Empleado().Obtener(idEmpleado);

            var ger = emp.ObtenerGerencia();
            var item = (from Object g in CbxGerencia.Items where ((Gerencia)g).Id.Value == ger.Id select g).FirstOrDefault();
            CbxGerencia.SelectedItem = item;
            TxtNombreEmpleado.Text = emp.Nombre;
            TxtApellidoEmpleado.Text = emp.Apellido;
            TxtTelefono.Text = emp.Telefono;
            TxtEmail.Text = emp.Email;
            TxtDireccionEmpleado.Text = emp.Direccion;
            TxtSueldoBase.Text = emp.SueldoBase.ToString();
            CmdNuevo.Text = "Actualizar";
        }

        private void CargarGerencias()
        {
            gerencias = new Gerencia().ObtenerTodo();

            CbxGerencia.Items.Clear();
            foreach (Gerencia ger in gerencias)
            {
                CbxGerencia.Items.Add(ger);
            }
            CbxGerencia.DisplayMember = "nombre";
            CbxGerencia.ValueMember = "id";
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            if (emp.Id == null)
            {
                try
                {
                    emp = new Empleado()
                    {
                        Nombre = TxtNombreEmpleado.Text,
                        Apellido = TxtApellidoEmpleado.Text,
                        Direccion = TxtDireccionEmpleado.Text,
                        Telefono = TxtTelefono.Text,
                        Email = TxtEmail.Text,
                        SueldoBase = Convert.ToDouble(TxtSueldoBase.Text),
                        IdGerencia = ((Gerencia)CbxGerencia.SelectedItem).Id.Value
                    };
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                if (emp.Agregar() > 0)
                {
                    MessageBox.Show("¡Se registró el empleado correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("No se pudo registrar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                emp.Nombre = TxtNombreEmpleado.Text;
                emp.Apellido = TxtApellidoEmpleado.Text;
                emp.Direccion = TxtDireccionEmpleado.Text;
                emp.Telefono = TxtTelefono.Text;
                emp.Email = TxtEmail.Text;
                emp.SueldoBase = Convert.ToDouble(TxtSueldoBase.Text);
                emp.IdGerencia = ((Gerencia)CbxGerencia.SelectedItem).Id.Value;

                if (emp.Actualizar())
                {
                    MessageBox.Show("¡Se actualizó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("No se pudo actualizar la información del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmCrearEmpleado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
