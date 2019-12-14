namespace ProyectoPlanilla
{
    partial class FrmPlanilla
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
            this.GbxControles = new System.Windows.Forms.GroupBox();
            this.CmdEliminarPlanilla = new System.Windows.Forms.Button();
            this.CmdActualizarPlanilla = new System.Windows.Forms.Button();
            this.CmdCrearPlanilla = new System.Windows.Forms.Button();
            this.GbxDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.TxtMesPlanilla = new System.Windows.Forms.TextBox();
            this.TxtNombrePlanilla = new System.Windows.Forms.TextBox();
            this.LblMesPlanilla = new System.Windows.Forms.Label();
            this.LblNombrePlanilla = new System.Windows.Forms.Label();
            this.GbxControles.SuspendLayout();
            this.GbxDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdEliminarPlanilla);
            this.GbxControles.Controls.Add(this.CmdActualizarPlanilla);
            this.GbxControles.Controls.Add(this.CmdCrearPlanilla);
            this.GbxControles.Location = new System.Drawing.Point(39, 226);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(423, 85);
            this.GbxControles.TabIndex = 3;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdEliminarPlanilla
            // 
            this.CmdEliminarPlanilla.Location = new System.Drawing.Point(324, 32);
            this.CmdEliminarPlanilla.Name = "CmdEliminarPlanilla";
            this.CmdEliminarPlanilla.Size = new System.Drawing.Size(75, 32);
            this.CmdEliminarPlanilla.TabIndex = 0;
            this.CmdEliminarPlanilla.Text = "Eliminar";
            this.CmdEliminarPlanilla.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarPlanilla
            // 
            this.CmdActualizarPlanilla.Location = new System.Drawing.Point(160, 32);
            this.CmdActualizarPlanilla.Name = "CmdActualizarPlanilla";
            this.CmdActualizarPlanilla.Size = new System.Drawing.Size(125, 32);
            this.CmdActualizarPlanilla.TabIndex = 0;
            this.CmdActualizarPlanilla.Text = "Actualizar";
            this.CmdActualizarPlanilla.UseVisualStyleBackColor = true;
            // 
            // CmdCrearPlanilla
            // 
            this.CmdCrearPlanilla.Location = new System.Drawing.Point(33, 32);
            this.CmdCrearPlanilla.Name = "CmdCrearPlanilla";
            this.CmdCrearPlanilla.Size = new System.Drawing.Size(81, 32);
            this.CmdCrearPlanilla.TabIndex = 0;
            this.CmdCrearPlanilla.Text = "Crear";
            this.CmdCrearPlanilla.UseVisualStyleBackColor = true;
            // 
            // GbxDatosUsuarios
            // 
            this.GbxDatosUsuarios.Controls.Add(this.TxtMesPlanilla);
            this.GbxDatosUsuarios.Controls.Add(this.TxtNombrePlanilla);
            this.GbxDatosUsuarios.Controls.Add(this.LblMesPlanilla);
            this.GbxDatosUsuarios.Controls.Add(this.LblNombrePlanilla);
            this.GbxDatosUsuarios.Location = new System.Drawing.Point(39, 32);
            this.GbxDatosUsuarios.Name = "GbxDatosUsuarios";
            this.GbxDatosUsuarios.Size = new System.Drawing.Size(423, 151);
            this.GbxDatosUsuarios.TabIndex = 2;
            this.GbxDatosUsuarios.TabStop = false;
            this.GbxDatosUsuarios.Text = "Datos";
            // 
            // TxtMesPlanilla
            // 
            this.TxtMesPlanilla.Location = new System.Drawing.Point(136, 101);
            this.TxtMesPlanilla.Name = "TxtMesPlanilla";
            this.TxtMesPlanilla.PasswordChar = '*';
            this.TxtMesPlanilla.Size = new System.Drawing.Size(263, 22);
            this.TxtMesPlanilla.TabIndex = 2;
            // 
            // TxtNombrePlanilla
            // 
            this.TxtNombrePlanilla.Location = new System.Drawing.Point(136, 54);
            this.TxtNombrePlanilla.Name = "TxtNombrePlanilla";
            this.TxtNombrePlanilla.Size = new System.Drawing.Size(263, 22);
            this.TxtNombrePlanilla.TabIndex = 2;
            // 
            // LblMesPlanilla
            // 
            this.LblMesPlanilla.AutoSize = true;
            this.LblMesPlanilla.Location = new System.Drawing.Point(30, 106);
            this.LblMesPlanilla.Name = "LblMesPlanilla";
            this.LblMesPlanilla.Size = new System.Drawing.Size(87, 17);
            this.LblMesPlanilla.TabIndex = 1;
            this.LblMesPlanilla.Text = "Fecha (Mes)";
            // 
            // LblNombrePlanilla
            // 
            this.LblNombrePlanilla.AutoSize = true;
            this.LblNombrePlanilla.Location = new System.Drawing.Point(30, 59);
            this.LblNombrePlanilla.Name = "LblNombrePlanilla";
            this.LblNombrePlanilla.Size = new System.Drawing.Size(58, 17);
            this.LblNombrePlanilla.TabIndex = 0;
            this.LblNombrePlanilla.Text = "Nombre";
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 340);
            this.Controls.Add(this.GbxControles);
            this.Controls.Add(this.GbxDatosUsuarios);
            this.Name = "FrmPlanilla";
            this.Text = "Pantalla Planilla";
            this.GbxControles.ResumeLayout(false);
            this.GbxDatosUsuarios.ResumeLayout(false);
            this.GbxDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdEliminarPlanilla;
        private System.Windows.Forms.Button CmdActualizarPlanilla;
        private System.Windows.Forms.Button CmdCrearPlanilla;
        private System.Windows.Forms.GroupBox GbxDatosUsuarios;
        private System.Windows.Forms.TextBox TxtMesPlanilla;
        private System.Windows.Forms.TextBox TxtNombrePlanilla;
        private System.Windows.Forms.Label LblMesPlanilla;
        private System.Windows.Forms.Label LblNombrePlanilla;
    }
}