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
            this.CmdLImpiarPlanilla = new System.Windows.Forms.Button();
            this.CmdNuevoPlanilla = new System.Windows.Forms.Button();
            this.GbxDatosPlanilla = new System.Windows.Forms.GroupBox();
            this.TxtNombrePlanilla = new System.Windows.Forms.TextBox();
            this.LblFechaPlanilla = new System.Windows.Forms.Label();
            this.LblNombrePlanilla = new System.Windows.Forms.Label();
            this.DtpFechaPlanilla = new System.Windows.Forms.DateTimePicker();
            this.GbxControlesUsuario.SuspendLayout();
            this.GbxDatosPlanilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxControlesUsuario
            // 
            this.GbxControlesUsuario.Controls.Add(this.CmdLImpiarPlanilla);
            this.GbxControlesUsuario.Controls.Add(this.CmdNuevoPlanilla);
            this.GbxControlesUsuario.Location = new System.Drawing.Point(109, 223);
            this.GbxControlesUsuario.Name = "GbxControlesUsuario";
            this.GbxControlesUsuario.Size = new System.Drawing.Size(477, 62);
            this.GbxControlesUsuario.TabIndex = 4;
            this.GbxControlesUsuario.TabStop = false;
            this.GbxControlesUsuario.Text = "Controles";
            // 
            // CmdLImpiarPlanilla
            // 
            this.CmdLImpiarPlanilla.Location = new System.Drawing.Point(269, 21);
            this.CmdLImpiarPlanilla.Name = "CmdLImpiarPlanilla";
            this.CmdLImpiarPlanilla.Size = new System.Drawing.Size(129, 35);
            this.CmdLImpiarPlanilla.TabIndex = 0;
            this.CmdLImpiarPlanilla.Text = "LImpiar";
            this.CmdLImpiarPlanilla.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoPlanilla
            // 
            this.CmdNuevoPlanilla.Location = new System.Drawing.Point(76, 22);
            this.CmdNuevoPlanilla.Name = "CmdNuevoPlanilla";
            this.CmdNuevoPlanilla.Size = new System.Drawing.Size(141, 34);
            this.CmdNuevoPlanilla.TabIndex = 0;
            this.CmdNuevoPlanilla.Text = "Nuevo";
            this.CmdNuevoPlanilla.UseVisualStyleBackColor = true;
            // 
            // GbxDatosPlanilla
            // 
            this.GbxDatosPlanilla.Controls.Add(this.DtpFechaPlanilla);
            this.GbxDatosPlanilla.Controls.Add(this.TxtNombrePlanilla);
            this.GbxDatosPlanilla.Controls.Add(this.LblFechaPlanilla);
            this.GbxDatosPlanilla.Controls.Add(this.LblNombrePlanilla);
            this.GbxDatosPlanilla.Location = new System.Drawing.Point(60, 53);
            this.GbxDatosPlanilla.Name = "GbxDatosPlanilla";
            this.GbxDatosPlanilla.Size = new System.Drawing.Size(561, 134);
            this.GbxDatosPlanilla.TabIndex = 3;
            this.GbxDatosPlanilla.TabStop = false;
            this.GbxDatosPlanilla.Text = "Datos";
            // 
            // TxtNombrePlanilla
            // 
            this.TxtNombrePlanilla.Location = new System.Drawing.Point(152, 31);
            this.TxtNombrePlanilla.Name = "TxtNombrePlanilla";
            this.TxtNombrePlanilla.Size = new System.Drawing.Size(374, 22);
            this.TxtNombrePlanilla.TabIndex = 2;
            // 
            // LblFechaPlanilla
            // 
            this.LblFechaPlanilla.AutoSize = true;
            this.LblFechaPlanilla.Location = new System.Drawing.Point(80, 78);
            this.LblFechaPlanilla.Name = "LblFechaPlanilla";
            this.LblFechaPlanilla.Size = new System.Drawing.Size(47, 17);
            this.LblFechaPlanilla.TabIndex = 0;
            this.LblFechaPlanilla.Text = "Fecha";
            // 
            // LblNombrePlanilla
            // 
            this.LblNombrePlanilla.AutoSize = true;
            this.LblNombrePlanilla.Location = new System.Drawing.Point(80, 31);
            this.LblNombrePlanilla.Name = "LblNombrePlanilla";
            this.LblNombrePlanilla.Size = new System.Drawing.Size(58, 17);
            this.LblNombrePlanilla.TabIndex = 0;
            this.LblNombrePlanilla.Text = "Nombre";
            // 
            // DtpFechaPlanilla
            // 
            this.DtpFechaPlanilla.Location = new System.Drawing.Point(152, 72);
            this.DtpFechaPlanilla.Name = "DtpFechaPlanilla";
            this.DtpFechaPlanilla.Size = new System.Drawing.Size(374, 22);
            this.DtpFechaPlanilla.TabIndex = 3;
            // 
            // FrmCrearPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 337);
            this.Controls.Add(this.GbxControlesUsuario);
            this.Controls.Add(this.GbxDatosPlanilla);
            this.Name = "FrmCrearPlanilla";
            this.Text = "FrmCrearPlanilla";
            this.GbxControlesUsuario.ResumeLayout(false);
            this.GbxDatosPlanilla.ResumeLayout(false);
            this.GbxDatosPlanilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControlesUsuario;
        private System.Windows.Forms.Button CmdLImpiarPlanilla;
        private System.Windows.Forms.Button CmdNuevoPlanilla;
        private System.Windows.Forms.GroupBox GbxDatosPlanilla;
        private System.Windows.Forms.TextBox TxtNombrePlanilla;
        private System.Windows.Forms.Label LblFechaPlanilla;
        private System.Windows.Forms.Label LblNombrePlanilla;
        private System.Windows.Forms.DateTimePicker DtpFechaPlanilla;
    }
}