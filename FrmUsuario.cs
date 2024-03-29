﻿using System;
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
    public partial class FrmUsuario : Form
    {
        Usuario usr = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();
        FrmCrearUsuario formUsuario;

        public FrmUsuario()
        {      
            InitializeComponent();
        }

        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            this.CargarDatos();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            DgvUsuario.Rows.Clear();
            usuarios = usr.ObtenerTodo();
            int i = 0;
            foreach (Usuario user in usuarios)
            {
                DgvUsuario.Rows.Insert(i++, new object[] { i, user.Nombre, user.Login });
                DgvUsuario.Rows[i-1].Tag = user.Id;
            }
        }

        private void ClicCelda(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 3) return;

            var fila = ((DataGridView)sender).Rows[e.RowIndex];
            int idRegistro = (int)fila.Tag;

            usr = usr.Obtener(idRegistro);

            if (e.ColumnIndex == 3)
            {
                InicializarFormRegistro(usr.Id.Value);
            }

            if (e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show($"¿Desea eliminar la cuenta de usuario {usr.Login}?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (usr.Eliminar())
                        MessageBox.Show("¡Se eliminó el registro correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.CargarDatos();
                }
            }
        }

        private void CmdCrearUsuario_Click(object sender, EventArgs e)
        {
            InicializarFormRegistro();
        }

        private void InicializarFormRegistro(int idUser = 0)
        {
            if (idUser > 0)
                formUsuario = new FrmCrearUsuario(idUser);
            else
                formUsuario = new FrmCrearUsuario();
            formUsuario.FormClosed += new FormClosedEventHandler(this.FormCerrado);
            formUsuario.Show();
        }
    }
}
