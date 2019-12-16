using System.Windows.Forms;

namespace ProyectoPlanilla
{
    partial class FrmCrearPlanilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbxControlesUsuario = new System.Windows.Forms.GroupBox();
            this.CmdNuevoPlanilla = new System.Windows.Forms.Button();
            this.GbxDatosPlanilla = new System.Windows.Forms.GroupBox();
            this.DtpFechaPlanilla = new System.Windows.Forms.DateTimePicker();
            this.TxtNombrePlanilla = new System.Windows.Forms.TextBox();
            this.LblFechaPlanilla = new System.Windows.Forms.Label();
            this.LblNombrePlanilla = new System.Windows.Forms.Label();
            this.GbxControlesUsuario.SuspendLayout();
            this.GbxDatosPlanilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxControlesUsuario
            // 
            this.GbxControlesUsuario.Controls.Add(this.CmdNuevoPlanilla);
            this.GbxControlesUsuario.Location = new System.Drawing.Point(82, 181);
            this.GbxControlesUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.GbxControlesUsuario.Name = "GbxControlesUsuario";
            this.GbxControlesUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.GbxControlesUsuario.Size = new System.Drawing.Size(358, 50);
            this.GbxControlesUsuario.TabIndex = 4;
            this.GbxControlesUsuario.TabStop = false;
            this.GbxControlesUsuario.Text = "Controles";
            // 
            // CmdNuevoPlanilla
            // 
            this.CmdNuevoPlanilla.Location = new System.Drawing.Point(219, 18);
            this.CmdNuevoPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.CmdNuevoPlanilla.Name = "CmdNuevoPlanilla";
            this.CmdNuevoPlanilla.Size = new System.Drawing.Size(106, 28);
            this.CmdNuevoPlanilla.TabIndex = 0;
            this.CmdNuevoPlanilla.Text = "Nuevo";
            this.CmdNuevoPlanilla.UseVisualStyleBackColor = true;
            this.CmdNuevoPlanilla.Click += new System.EventHandler(this.CmdNuevoPlanilla_Click);
            // 
            // GbxDatosPlanilla
            // 
            this.GbxDatosPlanilla.Controls.Add(this.DtpFechaPlanilla);
            this.GbxDatosPlanilla.Controls.Add(this.TxtNombrePlanilla);
            this.GbxDatosPlanilla.Controls.Add(this.LblFechaPlanilla);
            this.GbxDatosPlanilla.Controls.Add(this.LblNombrePlanilla);
            this.GbxDatosPlanilla.Location = new System.Drawing.Point(45, 43);
            this.GbxDatosPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.GbxDatosPlanilla.Name = "GbxDatosPlanilla";
            this.GbxDatosPlanilla.Padding = new System.Windows.Forms.Padding(2);
            this.GbxDatosPlanilla.Size = new System.Drawing.Size(421, 109);
            this.GbxDatosPlanilla.TabIndex = 3;
            this.GbxDatosPlanilla.TabStop = false;
            this.GbxDatosPlanilla.Text = "Datos";
            // 
            // DtpFechaPlanilla
            // 
            this.DtpFechaPlanilla.CustomFormat = "MMMM yyyy";
            this.DtpFechaPlanilla.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaPlanilla.Location = new System.Drawing.Point(114, 58);
            this.DtpFechaPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFechaPlanilla.Name = "DtpFechaPlanilla";
            this.DtpFechaPlanilla.ShowUpDown = true;
            this.DtpFechaPlanilla.Size = new System.Drawing.Size(282, 20);
            this.DtpFechaPlanilla.TabIndex = 3;
            // 
            // TxtNombrePlanilla
            // 
            this.TxtNombrePlanilla.Location = new System.Drawing.Point(114, 25);
            this.TxtNombrePlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombrePlanilla.Name = "TxtNombrePlanilla";
            this.TxtNombrePlanilla.Size = new System.Drawing.Size(282, 20);
            this.TxtNombrePlanilla.TabIndex = 2;
            // 
            // LblFechaPlanilla
            // 
            this.LblFechaPlanilla.AutoSize = true;
            this.LblFechaPlanilla.Location = new System.Drawing.Point(60, 63);
            this.LblFechaPlanilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaPlanilla.Name = "LblFechaPlanilla";
            this.LblFechaPlanilla.Size = new System.Drawing.Size(37, 13);
            this.LblFechaPlanilla.TabIndex = 0;
            this.LblFechaPlanilla.Text = "Fecha";
            // 
            // LblNombrePlanilla
            // 
            this.LblNombrePlanilla.AutoSize = true;
            this.LblNombrePlanilla.Location = new System.Drawing.Point(60, 25);
            this.LblNombrePlanilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombrePlanilla.Name = "LblNombrePlanilla";
            this.LblNombrePlanilla.Size = new System.Drawing.Size(44, 13);
            this.LblNombrePlanilla.TabIndex = 0;
            this.LblNombrePlanilla.Text = "Nombre";
            // 
            // FrmCrearPlanilla
            // 
            this.AcceptButton = this.CmdNuevoPlanilla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 274);
            this.Controls.Add(this.GbxControlesUsuario);
            this.Controls.Add(this.GbxDatosPlanilla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCrearPlanilla";
            this.Text = "FrmCrearPlanilla";
            this.GbxControlesUsuario.ResumeLayout(false);
            this.GbxDatosPlanilla.ResumeLayout(false);
            this.GbxDatosPlanilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControlesUsuario;
        private System.Windows.Forms.Button CmdNuevoPlanilla;
        private System.Windows.Forms.GroupBox GbxDatosPlanilla;
        private System.Windows.Forms.TextBox TxtNombrePlanilla;
        private System.Windows.Forms.Label LblFechaPlanilla;
        private System.Windows.Forms.Label LblNombrePlanilla;
        private System.Windows.Forms.DateTimePicker DtpFechaPlanilla;
    }
}