﻿using System;
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
    public partial class FrmDetaPlanilla : Form
    {
        Planilla pln = new Planilla();
        DetallePlanilla det = new DetallePlanilla();
        List<DetallePlanilla> detalles;
        public FrmDetaPlanilla()
        {
            InitializeComponent();
        }

        public FrmDetaPlanilla(int idPlanilla)
        {
            InitializeComponent();

            pln = new Planilla().Obtener(idPlanilla);
            detalles = det.ObtenerPorPlanilla(pln.Id.Value);
        }

        private void FrmDetaPlanilla_Load(object sender, EventArgs e)
        {
            LblNombrePlanilla.Text = pln.Nombre;
            LblFechaPlanilla.Text = pln.Fecha.ToString("MMMM yyyy");

            CargarDetalles();
        }

        private void CargarDetalles()
        {
            int i = 0;
            foreach (DetallePlanilla dp in detalles)
            {
                DgvDetaPlanilla.Rows.Insert(i++, new object[] {
                    i,
                    dp.ObtenerEmpleado().NombreCompleto,
                    "$" + dp.SueldoBase,
                    "$" + dp.Isss,
                    "$" + dp.AfpEmpleado,
                    "$" + dp.AfpEmpleador,
                    "$" + dp.Renta
                });
                DgvDetaPlanilla.Rows[i - 1].Tag = dp.Id;
            }
        }
    }
}
