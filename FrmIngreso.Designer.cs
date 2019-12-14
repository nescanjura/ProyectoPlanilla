namespace ProyectoPlanilla
{
    partial class FrmIngreso
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
            this.GbxDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.TxtClaveIngreso = new System.Windows.Forms.TextBox();
            this.TxtLoginIngreso = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.CmdIngreso = new System.Windows.Forms.Button();
            this.CmdLimpiarIngreso = new System.Windows.Forms.Button();
            this.GbxDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxDatosUsuarios
            // 
            this.GbxDatosUsuarios.Controls.Add(this.TxtClaveIngreso);
            this.GbxDatosUsuarios.Controls.Add(this.TxtLoginIngreso);
            this.GbxDatosUsuarios.Controls.Add(this.LblClave);
            this.GbxDatosUsuarios.Controls.Add(this.LblLogin);
            this.GbxDatosUsuarios.Location = new System.Drawing.Point(57, 21);
            this.GbxDatosUsuarios.Name = "GbxDatosUsuarios";
            this.GbxDatosUsuarios.Size = new System.Drawing.Size(425, 152);
            this.GbxDatosUsuarios.TabIndex = 1;
            this.GbxDatosUsuarios.TabStop = false;
            this.GbxDatosUsuarios.Text = "Datos";
            // 
            // TxtClaveIngreso
            // 
            this.TxtClaveIngreso.Location = new System.Drawing.Point(136, 101);
            this.TxtClaveIngreso.Name = "TxtClaveIngreso";
            this.TxtClaveIngreso.PasswordChar = '*';
            this.TxtClaveIngreso.Size = new System.Drawing.Size(263, 22);
            this.TxtClaveIngreso.TabIndex = 2;
            // 
            // TxtLoginIngreso
            // 
            this.TxtLoginIngreso.Location = new System.Drawing.Point(136, 54);
            this.TxtLoginIngreso.Name = "TxtLoginIngreso";
            this.TxtLoginIngreso.Size = new System.Drawing.Size(263, 22);
            this.TxtLoginIngreso.TabIndex = 2;
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(30, 106);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(43, 17);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(30, 59);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(43, 17);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login";
            // 
            // CmdIngreso
            // 
            this.CmdIngreso.Location = new System.Drawing.Point(109, 214);
            this.CmdIngreso.Name = "CmdIngreso";
            this.CmdIngreso.Size = new System.Drawing.Size(143, 31);
            this.CmdIngreso.TabIndex = 2;
            this.CmdIngreso.Text = "Ingresar";
            this.CmdIngreso.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarIngreso
            // 
            this.CmdLimpiarIngreso.Location = new System.Drawing.Point(301, 214);
            this.CmdLimpiarIngreso.Name = "CmdLimpiarIngreso";
            this.CmdLimpiarIngreso.Size = new System.Drawing.Size(143, 31);
            this.CmdLimpiarIngreso.TabIndex = 2;
            this.CmdLimpiarIngreso.Text = "Limpiar";
            this.CmdLimpiarIngreso.UseVisualStyleBackColor = true;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 271);
            this.Controls.Add(this.CmdLimpiarIngreso);
            this.Controls.Add(this.CmdIngreso);
            this.Controls.Add(this.GbxDatosUsuarios);
            this.Name = "FrmIngreso";
            this.Text = "Pantalla de Ingreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            this.GbxDatosUsuarios.ResumeLayout(false);
            this.GbxDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxDatosUsuarios;
        private System.Windows.Forms.TextBox TxtClaveIngreso;
        private System.Windows.Forms.TextBox TxtLoginIngreso;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Button CmdIngreso;
        private System.Windows.Forms.Button CmdLimpiarIngreso;
    }
}