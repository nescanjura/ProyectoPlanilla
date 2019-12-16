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
    public partial class FrmCrearGerencia : Form
    {
        Gerencia ger = new Gerencia();
        public FrmCrearGerencia()
        {
            InitializeComponent();

            CmdNuevoGerencia.Text = "Nuevo";
        }

        public FrmCrearGerencia(int idGerencia)
        {
            InitializeComponent();

            ger = new Gerencia().Obtener(idGerencia);
            TxtNombreGerencia.Text = ger.Nombre;
            ChbBonoGerencia.Checked = ger.DerechoBono;
            chbHorasExtrasGerencia.Checked = ger.HorasExtras;
            TxtPorcentajeBonoGerencia.Text = ger.PorcentajeBono.Value.ToString();
            CmdNuevoGerencia.Text = "Actualizar";
        }

     
        private void LimpiarCampos()
        {
            foreach (TextBox txt in this.GbxDatosUsuario.Controls.OfType<TextBox>())
                txt.Text = string.Empty;
        }

        private bool validar()
        {
            foreach (TextBox txt in this.GbxDatosUsuario.Controls.OfType<TextBox>())
                if (txt.Visible && txt.Text.Length == 0) return false;

            return true;
        }

        private void CmdNuevoGerencia_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Verifique la información ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ger.Id == null)
            {
                ger = new Gerencia()
                {
                    Nombre = TxtNombreGerencia.Text,
                    HorasExtras = chbHorasExtrasGerencia.Checked,
                    DerechoBono = ChbBonoGerencia.Checked,
                    PorcentajeBono = Convert.ToDouble(TxtPorcentajeBonoGerencia.Text)/100
                };

                if (ger.Agregar() > 0)
                    MessageBox.Show("¡Se registró el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ger.Nombre = TxtNombreGerencia.Text;
                ger.HorasExtras = chbHorasExtrasGerencia.Checked;
                ger.DerechoBono = ChbBonoGerencia.Checked;
                ger.PorcentajeBono = (Convert.ToDouble(TxtPorcentajeBonoGerencia.Text))/100;

                if (ger.Actualizar())
                    MessageBox.Show("¡Se actualizó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo actualizar la información del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Close();
        }

        private void ChbBonoGerencia_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ChbBonoGerencia.Checked)
            { 
                TxtPorcentajeBonoGerencia.Visible = true; 
            }
            else
            {
                TxtPorcentajeBonoGerencia.Visible = false;
                TxtPorcentajeBonoGerencia.Text = "0";
            }
                
        }

        private void CmdLImpiarGerencia_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

