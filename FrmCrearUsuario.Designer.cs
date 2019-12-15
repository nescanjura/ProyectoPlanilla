namespace ProyectoPlanilla
{
    partial class FrmCrearUsuario
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
            this.GbxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.LblLoginUsuario = new System.Windows.Forms.Label();
            this.LblClaveUsuario = new System.Windows.Forms.Label();
            this.ChbActivoUsuario = new System.Windows.Forms.CheckBox();
            this.ChbEstadoUsuario = new System.Windows.Forms.CheckBox();
            this.LblNombreUsuairo = new System.Windows.Forms.Label();
            this.TxtLoginUsuario = new System.Windows.Forms.TextBox();
            this.TxtClaveUsuario = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.GbxControlesUsuario = new System.Windows.Forms.GroupBox();
            this.CmdLImpiarUsuario = new System.Windows.Forms.Button();
            this.CmdNuevoUsuario = new System.Windows.Forms.Button();
            this.GbxDatosUsuario.SuspendLayout();
            this.GbxControlesUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxDatosUsuario
            // 
            this.GbxDatosUsuario.Controls.Add(this.TxtNombreUsuario);
            this.GbxDatosUsuario.Controls.Add(this.TxtClaveUsuario);
            this.GbxDatosUsuario.Controls.Add(this.TxtLoginUsuario);
            this.GbxDatosUsuario.Controls.Add(this.ChbEstadoUsuario);
            this.GbxDatosUsuario.Controls.Add(this.ChbActivoUsuario);
            this.GbxDatosUsuario.Controls.Add(this.LblNombreUsuairo);
            this.GbxDatosUsuario.Controls.Add(this.LblClaveUsuario);
            this.GbxDatosUsuario.Controls.Add(this.LblLoginUsuario);
            this.GbxDatosUsuario.Location = new System.Drawing.Point(32, 41);
            this.GbxDatosUsuario.Name = "GbxDatosUsuario";
            this.GbxDatosUsuario.Size = new System.Drawing.Size(553, 238);
            this.GbxDatosUsuario.TabIndex = 0;
            this.GbxDatosUsuario.TabStop = false;
            this.GbxDatosUsuario.Text = "Datos";
            // 
            // LblLoginUsuario
            // 
            this.LblLoginUsuario.AutoSize = true;
            this.LblLoginUsuario.Location = new System.Drawing.Point(80, 31);
            this.LblLoginUsuario.Name = "LblLoginUsuario";
            this.LblLoginUsuario.Size = new System.Drawing.Size(43, 17);
            this.LblLoginUsuario.TabIndex = 0;
            this.LblLoginUsuario.Text = "Login";
            // 
            // LblClaveUsuario
            // 
            this.LblClaveUsuario.AutoSize = true;
            this.LblClaveUsuario.Location = new System.Drawing.Point(80, 78);
            this.LblClaveUsuario.Name = "LblClaveUsuario";
            this.LblClaveUsuario.Size = new System.Drawing.Size(43, 17);
            this.LblClaveUsuario.TabIndex = 0;
            this.LblClaveUsuario.Text = "Clave";
            // 
            // ChbActivoUsuario
            // 
            this.ChbActivoUsuario.AutoSize = true;
            this.ChbActivoUsuario.Location = new System.Drawing.Point(152, 182);
            this.ChbActivoUsuario.Name = "ChbActivoUsuario";
            this.ChbActivoUsuario.Size = new System.Drawing.Size(68, 21);
            this.ChbActivoUsuario.TabIndex = 1;
            this.ChbActivoUsuario.Text = "Activo";
            this.ChbActivoUsuario.UseVisualStyleBackColor = true;
            // 
            // ChbEstadoUsuario
            // 
            this.ChbEstadoUsuario.AutoSize = true;
            this.ChbEstadoUsuario.Location = new System.Drawing.Point(380, 182);
            this.ChbEstadoUsuario.Name = "ChbEstadoUsuario";
            this.ChbEstadoUsuario.Size = new System.Drawing.Size(74, 21);
            this.ChbEstadoUsuario.TabIndex = 1;
            this.ChbEstadoUsuario.Text = "Estado";
            this.ChbEstadoUsuario.UseVisualStyleBackColor = true;
            // 
            // LblNombreUsuairo
            // 
            this.LblNombreUsuairo.AutoSize = true;
            this.LblNombreUsuairo.Location = new System.Drawing.Point(80, 122);
            this.LblNombreUsuairo.Name = "LblNombreUsuairo";
            this.LblNombreUsuairo.Size = new System.Drawing.Size(57, 17);
            this.LblNombreUsuairo.TabIndex = 0;
            this.LblNombreUsuairo.Text = "Usuario";
            // 
            // TxtLoginUsuario
            // 
            this.TxtLoginUsuario.Location = new System.Drawing.Point(152, 31);
            this.TxtLoginUsuario.Name = "TxtLoginUsuario";
            this.TxtLoginUsuario.Size = new System.Drawing.Size(374, 22);
            this.TxtLoginUsuario.TabIndex = 2;
            // 
            // TxtClaveUsuario
            // 
            this.TxtClaveUsuario.Location = new System.Drawing.Point(152, 78);
            this.TxtClaveUsuario.Name = "TxtClaveUsuario";
            this.TxtClaveUsuario.PasswordChar = '*';
            this.TxtClaveUsuario.Size = new System.Drawing.Size(374, 22);
            this.TxtClaveUsuario.TabIndex = 2;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(152, 122);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(374, 22);
            this.TxtNombreUsuario.TabIndex = 2;
            // 
            // GbxControlesUsuario
            // 
            this.GbxControlesUsuario.Controls.Add(this.CmdLImpiarUsuario);
            this.GbxControlesUsuario.Controls.Add(this.CmdNuevoUsuario);
            this.GbxControlesUsuario.Location = new System.Drawing.Point(71, 311);
            this.GbxControlesUsuario.Name = "GbxControlesUsuario";
            this.GbxControlesUsuario.Size = new System.Drawing.Size(477, 62);
            this.GbxControlesUsuario.TabIndex = 2;
            this.GbxControlesUsuario.TabStop = false;
            this.GbxControlesUsuario.Text = "Controles";
            // 
            // CmdLImpiarUsuario
            // 
            this.CmdLImpiarUsuario.Location = new System.Drawing.Point(269, 21);
            this.CmdLImpiarUsuario.Name = "CmdLImpiarUsuario";
            this.CmdLImpiarUsuario.Size = new System.Drawing.Size(129, 35);
            this.CmdLImpiarUsuario.TabIndex = 0;
            this.CmdLImpiarUsuario.Text = "LImpiar";
            this.CmdLImpiarUsuario.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoUsuario
            // 
            this.CmdNuevoUsuario.Location = new System.Drawing.Point(76, 22);
            this.CmdNuevoUsuario.Name = "CmdNuevoUsuario";
            this.CmdNuevoUsuario.Size = new System.Drawing.Size(141, 34);
            this.CmdNuevoUsuario.TabIndex = 0;
            this.CmdNuevoUsuario.Text = "Nuevo";
            this.CmdNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 394);
            this.Controls.Add(this.GbxControlesUsuario);
            this.Controls.Add(this.GbxDatosUsuario);
            this.Name = "FrmCrearUsuario";
            this.Text = "Pantalla Usuario";
            this.GbxDatosUsuario.ResumeLayout(false);
            this.GbxDatosUsuario.PerformLayout();
            this.GbxControlesUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxDatosUsuario;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.TextBox TxtClaveUsuario;
        private System.Windows.Forms.TextBox TxtLoginUsuario;
        private System.Windows.Forms.CheckBox ChbEstadoUsuario;
        private System.Windows.Forms.CheckBox ChbActivoUsuario;
        private System.Windows.Forms.Label LblNombreUsuairo;
        private System.Windows.Forms.Label LblClaveUsuario;
        private System.Windows.Forms.Label LblLoginUsuario;
        private System.Windows.Forms.GroupBox GbxControlesUsuario;
        private System.Windows.Forms.Button CmdLImpiarUsuario;
        private System.Windows.Forms.Button CmdNuevoUsuario;
    }
}