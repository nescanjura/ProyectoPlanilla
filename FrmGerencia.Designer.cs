namespace ProyectoPlanilla
{
    partial class FrmGerencia
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
            this.CmdEliminarGerencia = new System.Windows.Forms.Button();
            this.CmdActualizarGerencia = new System.Windows.Forms.Button();
            this.CmdCrearGerencia = new System.Windows.Forms.Button();
            this.GbxDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblNombreGerencia = new System.Windows.Forms.Label();
            this.LblPorcentajeBono = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.ChbBono = new System.Windows.Forms.CheckBox();
            this.CbxHorasExtras = new System.Windows.Forms.CheckBox();
            this.GbxControles.SuspendLayout();
            this.GbxDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdEliminarGerencia);
            this.GbxControles.Controls.Add(this.CmdActualizarGerencia);
            this.GbxControles.Controls.Add(this.CmdCrearGerencia);
            this.GbxControles.Location = new System.Drawing.Point(63, 292);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(423, 85);
            this.GbxControles.TabIndex = 3;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdEliminarGerencia
            // 
            this.CmdEliminarGerencia.Location = new System.Drawing.Point(324, 32);
            this.CmdEliminarGerencia.Name = "CmdEliminarGerencia";
            this.CmdEliminarGerencia.Size = new System.Drawing.Size(75, 32);
            this.CmdEliminarGerencia.TabIndex = 0;
            this.CmdEliminarGerencia.Text = "Eliminar";
            this.CmdEliminarGerencia.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarGerencia
            // 
            this.CmdActualizarGerencia.Location = new System.Drawing.Point(160, 32);
            this.CmdActualizarGerencia.Name = "CmdActualizarGerencia";
            this.CmdActualizarGerencia.Size = new System.Drawing.Size(125, 32);
            this.CmdActualizarGerencia.TabIndex = 0;
            this.CmdActualizarGerencia.Text = "Actualizar";
            this.CmdActualizarGerencia.UseVisualStyleBackColor = true;
            // 
            // CmdCrearGerencia
            // 
            this.CmdCrearGerencia.Location = new System.Drawing.Point(33, 32);
            this.CmdCrearGerencia.Name = "CmdCrearGerencia";
            this.CmdCrearGerencia.Size = new System.Drawing.Size(81, 32);
            this.CmdCrearGerencia.TabIndex = 0;
            this.CmdCrearGerencia.Text = "Crear";
            this.CmdCrearGerencia.UseVisualStyleBackColor = true;
            // 
            // GbxDatosUsuarios
            // 
            this.GbxDatosUsuarios.Controls.Add(this.CbxHorasExtras);
            this.GbxDatosUsuarios.Controls.Add(this.ChbBono);
            this.GbxDatosUsuarios.Controls.Add(this.TxtClave);
            this.GbxDatosUsuarios.Controls.Add(this.TxtLogin);
            this.GbxDatosUsuarios.Controls.Add(this.LblPorcentajeBono);
            this.GbxDatosUsuarios.Controls.Add(this.LblNombreGerencia);
            this.GbxDatosUsuarios.Location = new System.Drawing.Point(47, 41);
            this.GbxDatosUsuarios.Name = "GbxDatosUsuarios";
            this.GbxDatosUsuarios.Size = new System.Drawing.Size(439, 207);
            this.GbxDatosUsuarios.TabIndex = 2;
            this.GbxDatosUsuarios.TabStop = false;
            this.GbxDatosUsuarios.Text = "Datos";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(136, 54);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(263, 22);
            this.TxtLogin.TabIndex = 2;
            // 
            // LblNombreGerencia
            // 
            this.LblNombreGerencia.AutoSize = true;
            this.LblNombreGerencia.Location = new System.Drawing.Point(30, 59);
            this.LblNombreGerencia.Name = "LblNombreGerencia";
            this.LblNombreGerencia.Size = new System.Drawing.Size(58, 17);
            this.LblNombreGerencia.TabIndex = 0;
            this.LblNombreGerencia.Text = "Nombre";
            // 
            // LblPorcentajeBono
            // 
            this.LblPorcentajeBono.AutoSize = true;
            this.LblPorcentajeBono.Location = new System.Drawing.Point(30, 106);
            this.LblPorcentajeBono.Name = "LblPorcentajeBono";
            this.LblPorcentajeBono.Size = new System.Drawing.Size(57, 17);
            this.LblPorcentajeBono.TabIndex = 1;
            this.LblPorcentajeBono.Text = "% Bono";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(136, 101);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(108, 22);
            this.TxtClave.TabIndex = 2;
            // 
            // ChbBono
            // 
            this.ChbBono.AutoSize = true;
            this.ChbBono.Location = new System.Drawing.Point(33, 160);
            this.ChbBono.Name = "ChbBono";
            this.ChbBono.Size = new System.Drawing.Size(105, 21);
            this.ChbBono.TabIndex = 3;
            this.ChbBono.Text = "Aplica Bono";
            this.ChbBono.UseVisualStyleBackColor = true;
            // 
            // CbxHorasExtras
            // 
            this.CbxHorasExtras.AutoSize = true;
            this.CbxHorasExtras.Location = new System.Drawing.Point(246, 160);
            this.CbxHorasExtras.Name = "CbxHorasExtras";
            this.CbxHorasExtras.Size = new System.Drawing.Size(153, 21);
            this.CbxHorasExtras.TabIndex = 3;
            this.CbxHorasExtras.Text = "Aplica Horas Extras";
            this.CbxHorasExtras.UseVisualStyleBackColor = true;
            // 
            // FrmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 396);
            this.Controls.Add(this.GbxControles);
            this.Controls.Add(this.GbxDatosUsuarios);
            this.Name = "FrmGerencia";
            this.Text = "Pantalla Gerencia";
            this.GbxControles.ResumeLayout(false);
            this.GbxDatosUsuarios.ResumeLayout(false);
            this.GbxDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdEliminarGerencia;
        private System.Windows.Forms.Button CmdActualizarGerencia;
        private System.Windows.Forms.Button CmdCrearGerencia;
        private System.Windows.Forms.GroupBox GbxDatosUsuarios;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblNombreGerencia;
        private System.Windows.Forms.CheckBox CbxHorasExtras;
        private System.Windows.Forms.CheckBox ChbBono;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label LblPorcentajeBono;
    }
}