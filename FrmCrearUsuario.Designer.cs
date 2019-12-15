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
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtClaveUsuario = new System.Windows.Forms.TextBox();
            this.TxtLoginUsuario = new System.Windows.Forms.TextBox();
            this.LblNombreUsuairo = new System.Windows.Forms.Label();
            this.LblClaveUsuario = new System.Windows.Forms.Label();
            this.LblLoginUsuario = new System.Windows.Forms.Label();
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
            this.GbxDatosUsuario.Controls.Add(this.LblNombreUsuairo);
            this.GbxDatosUsuario.Controls.Add(this.LblClaveUsuario);
            this.GbxDatosUsuario.Controls.Add(this.LblLoginUsuario);
            this.GbxDatosUsuario.Location = new System.Drawing.Point(24, 33);
            this.GbxDatosUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxDatosUsuario.Name = "GbxDatosUsuario";
            this.GbxDatosUsuario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxDatosUsuario.Size = new System.Drawing.Size(415, 129);
            this.GbxDatosUsuario.TabIndex = 0;
            this.GbxDatosUsuario.TabStop = false;
            this.GbxDatosUsuario.Text = "Datos";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(114, 30);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(282, 20);
            this.TxtNombreUsuario.TabIndex = 0;
            // 
            // TxtClaveUsuario
            // 
            this.TxtClaveUsuario.Location = new System.Drawing.Point(114, 93);
            this.TxtClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtClaveUsuario.Name = "TxtClaveUsuario";
            this.TxtClaveUsuario.PasswordChar = '*';
            this.TxtClaveUsuario.Size = new System.Drawing.Size(282, 20);
            this.TxtClaveUsuario.TabIndex = 2;
            // 
            // TxtLoginUsuario
            // 
            this.TxtLoginUsuario.Location = new System.Drawing.Point(114, 63);
            this.TxtLoginUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLoginUsuario.Name = "TxtLoginUsuario";
            this.TxtLoginUsuario.Size = new System.Drawing.Size(282, 20);
            this.TxtLoginUsuario.TabIndex = 1;
            // 
            // LblNombreUsuairo
            // 
            this.LblNombreUsuairo.AutoSize = true;
            this.LblNombreUsuairo.Location = new System.Drawing.Point(60, 34);
            this.LblNombreUsuairo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreUsuairo.Name = "LblNombreUsuairo";
            this.LblNombreUsuairo.Size = new System.Drawing.Size(44, 13);
            this.LblNombreUsuairo.TabIndex = 0;
            this.LblNombreUsuairo.Text = "Nombre";
            // 
            // LblClaveUsuario
            // 
            this.LblClaveUsuario.AutoSize = true;
            this.LblClaveUsuario.Location = new System.Drawing.Point(60, 93);
            this.LblClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblClaveUsuario.Name = "LblClaveUsuario";
            this.LblClaveUsuario.Size = new System.Drawing.Size(34, 13);
            this.LblClaveUsuario.TabIndex = 0;
            this.LblClaveUsuario.Text = "Clave";
            // 
            // LblLoginUsuario
            // 
            this.LblLoginUsuario.AutoSize = true;
            this.LblLoginUsuario.Location = new System.Drawing.Point(60, 66);
            this.LblLoginUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLoginUsuario.Name = "LblLoginUsuario";
            this.LblLoginUsuario.Size = new System.Drawing.Size(33, 13);
            this.LblLoginUsuario.TabIndex = 0;
            this.LblLoginUsuario.Text = "Login";
            // 
            // GbxControlesUsuario
            // 
            this.GbxControlesUsuario.Controls.Add(this.CmdLImpiarUsuario);
            this.GbxControlesUsuario.Controls.Add(this.CmdNuevoUsuario);
            this.GbxControlesUsuario.Location = new System.Drawing.Point(81, 166);
            this.GbxControlesUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxControlesUsuario.Name = "GbxControlesUsuario";
            this.GbxControlesUsuario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxControlesUsuario.Size = new System.Drawing.Size(358, 50);
            this.GbxControlesUsuario.TabIndex = 2;
            this.GbxControlesUsuario.TabStop = false;
            this.GbxControlesUsuario.Text = "Controles";
            // 
            // CmdLImpiarUsuario
            // 
            this.CmdLImpiarUsuario.Location = new System.Drawing.Point(95, 17);
            this.CmdLImpiarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdLImpiarUsuario.Name = "CmdLImpiarUsuario";
            this.CmdLImpiarUsuario.Size = new System.Drawing.Size(97, 28);
            this.CmdLImpiarUsuario.TabIndex = 4;
            this.CmdLImpiarUsuario.Text = "Limpiar";
            this.CmdLImpiarUsuario.UseVisualStyleBackColor = true;
            this.CmdLImpiarUsuario.Click += new System.EventHandler(this.CmdLImpiarUsuario_Click);
            // 
            // CmdNuevoUsuario
            // 
            this.CmdNuevoUsuario.Location = new System.Drawing.Point(233, 17);
            this.CmdNuevoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdNuevoUsuario.Name = "CmdNuevoUsuario";
            this.CmdNuevoUsuario.Size = new System.Drawing.Size(106, 28);
            this.CmdNuevoUsuario.TabIndex = 3;
            this.CmdNuevoUsuario.Text = "Nuevo";
            this.CmdNuevoUsuario.UseVisualStyleBackColor = true;
            this.CmdNuevoUsuario.Click += new System.EventHandler(this.CmdNuevoUsuario_Click);
            // 
            // FrmCrearUsuario
            // 
            this.AcceptButton = this.CmdNuevoUsuario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 223);
            this.Controls.Add(this.GbxControlesUsuario);
            this.Controls.Add(this.GbxDatosUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label LblNombreUsuairo;
        private System.Windows.Forms.Label LblClaveUsuario;
        private System.Windows.Forms.Label LblLoginUsuario;
        private System.Windows.Forms.GroupBox GbxControlesUsuario;
        private System.Windows.Forms.Button CmdLImpiarUsuario;
        private System.Windows.Forms.Button CmdNuevoUsuario;
    }
}