namespace ProyectoPlanilla
{
    partial class FrmCrearEmpleado
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
            this.TcEmpleado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblNombreEmpleado = new System.Windows.Forms.Label();
            this.LblApellidoEmpleado = new System.Windows.Forms.Label();
            this.LblSexoEmpleado = new System.Windows.Forms.Label();
            this.LblFecNacimientoEmpleado = new System.Windows.Forms.Label();
            this.LblEmailEmpleado = new System.Windows.Forms.Label();
            this.LblFechaCreacionEmpleado = new System.Windows.Forms.Label();
            this.LblDireccionEmpleado = new System.Windows.Forms.Label();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.TxtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.TxtTEmailEmpleado = new System.Windows.Forms.TextBox();
            this.TxtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbSexoEmpleado = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.LblSueldoBaseEmpleado = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.LblGerencia = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GbxControlesEmpleado = new System.Windows.Forms.GroupBox();
            this.CmdNuevo = new System.Windows.Forms.Button();
            this.CmdLImpiarEmpleado = new System.Windows.Forms.Button();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ChbEstadoEmpleado = new System.Windows.Forms.CheckBox();
            this.LblIsssEmpleado = new System.Windows.Forms.Label();
            this.TxtIsssEmpleado = new System.Windows.Forms.TextBox();
            this.LblNupEmpleado = new System.Windows.Forms.Label();
            this.TxtNupEmpleado = new System.Windows.Forms.TextBox();
            this.TcEmpleado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GbxControlesEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcEmpleado
            // 
            this.TcEmpleado.Controls.Add(this.tabPage1);
            this.TcEmpleado.Controls.Add(this.tabPage2);
            this.TcEmpleado.Location = new System.Drawing.Point(33, 32);
            this.TcEmpleado.Name = "TcEmpleado";
            this.TcEmpleado.SelectedIndex = 0;
            this.TcEmpleado.Size = new System.Drawing.Size(1028, 459);
            this.TcEmpleado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.ChbEstadoEmpleado);
            this.tabPage1.Controls.Add(this.CmbSexoEmpleado);
            this.tabPage1.Controls.Add(this.DtpFechaNacimiento);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.TxtDireccionEmpleado);
            this.tabPage1.Controls.Add(this.TxtTEmailEmpleado);
            this.tabPage1.Controls.Add(this.TxtApellidoEmpleado);
            this.tabPage1.Controls.Add(this.TxtNombreEmpleado);
            this.tabPage1.Controls.Add(this.LblDireccionEmpleado);
            this.tabPage1.Controls.Add(this.LblFechaCreacionEmpleado);
            this.tabPage1.Controls.Add(this.LblEmailEmpleado);
            this.tabPage1.Controls.Add(this.LblFecNacimientoEmpleado);
            this.tabPage1.Controls.Add(this.LblSexoEmpleado);
            this.tabPage1.Controls.Add(this.LblApellidoEmpleado);
            this.tabPage1.Controls.Add(this.LblNombreEmpleado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.LblGerencia);
            this.tabPage2.Controls.Add(this.LblSueldoBaseEmpleado);
            this.tabPage2.Controls.Add(this.TxtNupEmpleado);
            this.tabPage2.Controls.Add(this.LblNupEmpleado);
            this.tabPage2.Controls.Add(this.TxtIsssEmpleado);
            this.tabPage2.Controls.Add(this.LblIsssEmpleado);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.LblTelefonoEmpleado);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Patronales";
            // 
            // LblNombreEmpleado
            // 
            this.LblNombreEmpleado.AutoSize = true;
            this.LblNombreEmpleado.Location = new System.Drawing.Point(53, 58);
            this.LblNombreEmpleado.Name = "LblNombreEmpleado";
            this.LblNombreEmpleado.Size = new System.Drawing.Size(58, 17);
            this.LblNombreEmpleado.TabIndex = 0;
            this.LblNombreEmpleado.Text = "Nombre";
            // 
            // LblApellidoEmpleado
            // 
            this.LblApellidoEmpleado.AutoSize = true;
            this.LblApellidoEmpleado.Location = new System.Drawing.Point(53, 101);
            this.LblApellidoEmpleado.Name = "LblApellidoEmpleado";
            this.LblApellidoEmpleado.Size = new System.Drawing.Size(58, 17);
            this.LblApellidoEmpleado.TabIndex = 0;
            this.LblApellidoEmpleado.Text = "Apellido";
            // 
            // LblSexoEmpleado
            // 
            this.LblSexoEmpleado.AutoSize = true;
            this.LblSexoEmpleado.Location = new System.Drawing.Point(53, 144);
            this.LblSexoEmpleado.Name = "LblSexoEmpleado";
            this.LblSexoEmpleado.Size = new System.Drawing.Size(39, 17);
            this.LblSexoEmpleado.TabIndex = 0;
            this.LblSexoEmpleado.Text = "Sexo";
            // 
            // LblFecNacimientoEmpleado
            // 
            this.LblFecNacimientoEmpleado.AutoSize = true;
            this.LblFecNacimientoEmpleado.Location = new System.Drawing.Point(53, 178);
            this.LblFecNacimientoEmpleado.Name = "LblFecNacimientoEmpleado";
            this.LblFecNacimientoEmpleado.Size = new System.Drawing.Size(141, 17);
            this.LblFecNacimientoEmpleado.TabIndex = 0;
            this.LblFecNacimientoEmpleado.Text = "Fecha de Nacimiento";
            // 
            // LblEmailEmpleado
            // 
            this.LblEmailEmpleado.AutoSize = true;
            this.LblEmailEmpleado.Location = new System.Drawing.Point(53, 223);
            this.LblEmailEmpleado.Name = "LblEmailEmpleado";
            this.LblEmailEmpleado.Size = new System.Drawing.Size(42, 17);
            this.LblEmailEmpleado.TabIndex = 0;
            this.LblEmailEmpleado.Text = "Email";
            // 
            // LblFechaCreacionEmpleado
            // 
            this.LblFechaCreacionEmpleado.AutoSize = true;
            this.LblFechaCreacionEmpleado.Location = new System.Drawing.Point(648, 57);
            this.LblFechaCreacionEmpleado.Name = "LblFechaCreacionEmpleado";
            this.LblFechaCreacionEmpleado.Size = new System.Drawing.Size(127, 17);
            this.LblFechaCreacionEmpleado.TabIndex = 0;
            this.LblFechaCreacionEmpleado.Text = "Fecha de Creacion";
            // 
            // LblDireccionEmpleado
            // 
            this.LblDireccionEmpleado.AutoSize = true;
            this.LblDireccionEmpleado.Location = new System.Drawing.Point(53, 263);
            this.LblDireccionEmpleado.Name = "LblDireccionEmpleado";
            this.LblDireccionEmpleado.Size = new System.Drawing.Size(67, 17);
            this.LblDireccionEmpleado.TabIndex = 0;
            this.LblDireccionEmpleado.Text = "Dirección";
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(141, 53);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(456, 22);
            this.TxtNombreEmpleado.TabIndex = 1;
            // 
            // TxtApellidoEmpleado
            // 
            this.TxtApellidoEmpleado.Location = new System.Drawing.Point(141, 96);
            this.TxtApellidoEmpleado.Name = "TxtApellidoEmpleado";
            this.TxtApellidoEmpleado.Size = new System.Drawing.Size(456, 22);
            this.TxtApellidoEmpleado.TabIndex = 1;
            // 
            // TxtTEmailEmpleado
            // 
            this.TxtTEmailEmpleado.Location = new System.Drawing.Point(141, 218);
            this.TxtTEmailEmpleado.Name = "TxtTEmailEmpleado";
            this.TxtTEmailEmpleado.Size = new System.Drawing.Size(456, 22);
            this.TxtTEmailEmpleado.TabIndex = 1;
            // 
            // TxtDireccionEmpleado
            // 
            this.TxtDireccionEmpleado.Location = new System.Drawing.Point(141, 260);
            this.TxtDireccionEmpleado.Multiline = true;
            this.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado";
            this.TxtDireccionEmpleado.Size = new System.Drawing.Size(474, 101);
            this.TxtDireccionEmpleado.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(799, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // CmbSexoEmpleado
            // 
            this.CmbSexoEmpleado.FormattingEnabled = true;
            this.CmbSexoEmpleado.Location = new System.Drawing.Point(141, 135);
            this.CmbSexoEmpleado.Name = "CmbSexoEmpleado";
            this.CmbSexoEmpleado.Size = new System.Drawing.Size(299, 24);
            this.CmbSexoEmpleado.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 22);
            this.textBox5.TabIndex = 3;
            // 
            // LblTelefonoEmpleado
            // 
            this.LblTelefonoEmpleado.AutoSize = true;
            this.LblTelefonoEmpleado.Location = new System.Drawing.Point(20, 38);
            this.LblTelefonoEmpleado.Name = "LblTelefonoEmpleado";
            this.LblTelefonoEmpleado.Size = new System.Drawing.Size(64, 17);
            this.LblTelefonoEmpleado.TabIndex = 2;
            this.LblTelefonoEmpleado.Text = "Teléfono";
            // 
            // LblSueldoBaseEmpleado
            // 
            this.LblSueldoBaseEmpleado.AutoSize = true;
            this.LblSueldoBaseEmpleado.Location = new System.Drawing.Point(20, 93);
            this.LblSueldoBaseEmpleado.Name = "LblSueldoBaseEmpleado";
            this.LblSueldoBaseEmpleado.Size = new System.Drawing.Size(88, 17);
            this.LblSueldoBaseEmpleado.TabIndex = 2;
            this.LblSueldoBaseEmpleado.Text = "Sueldo Base";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 87);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(182, 22);
            this.textBox7.TabIndex = 3;
            // 
            // LblGerencia
            // 
            this.LblGerencia.AutoSize = true;
            this.LblGerencia.Location = new System.Drawing.Point(20, 152);
            this.LblGerencia.Name = "LblGerencia";
            this.LblGerencia.Size = new System.Drawing.Size(66, 17);
            this.LblGerencia.TabIndex = 2;
            this.LblGerencia.Text = "Gerencia";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // GbxControlesEmpleado
            // 
            this.GbxControlesEmpleado.Controls.Add(this.CmdLImpiarEmpleado);
            this.GbxControlesEmpleado.Controls.Add(this.CmdNuevo);
            this.GbxControlesEmpleado.Location = new System.Drawing.Point(319, 515);
            this.GbxControlesEmpleado.Name = "GbxControlesEmpleado";
            this.GbxControlesEmpleado.Size = new System.Drawing.Size(477, 62);
            this.GbxControlesEmpleado.TabIndex = 1;
            this.GbxControlesEmpleado.TabStop = false;
            this.GbxControlesEmpleado.Text = "Controles";
            // 
            // CmdNuevo
            // 
            this.CmdNuevo.Location = new System.Drawing.Point(76, 22);
            this.CmdNuevo.Name = "CmdNuevo";
            this.CmdNuevo.Size = new System.Drawing.Size(141, 34);
            this.CmdNuevo.TabIndex = 0;
            this.CmdNuevo.Text = "Nuevo";
            this.CmdNuevo.UseVisualStyleBackColor = true;
            // 
            // CmdLImpiarEmpleado
            // 
            this.CmdLImpiarEmpleado.Location = new System.Drawing.Point(269, 21);
            this.CmdLImpiarEmpleado.Name = "CmdLImpiarEmpleado";
            this.CmdLImpiarEmpleado.Size = new System.Drawing.Size(129, 35);
            this.CmdLImpiarEmpleado.TabIndex = 0;
            this.CmdLImpiarEmpleado.Text = "LImpiar";
            this.CmdLImpiarEmpleado.UseVisualStyleBackColor = true;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(226, 178);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(303, 22);
            this.DtpFechaNacimiento.TabIndex = 2;
            // 
            // ChbEstadoEmpleado
            // 
            this.ChbEstadoEmpleado.AutoSize = true;
            this.ChbEstadoEmpleado.Location = new System.Drawing.Point(925, 103);
            this.ChbEstadoEmpleado.Name = "ChbEstadoEmpleado";
            this.ChbEstadoEmpleado.Size = new System.Drawing.Size(74, 21);
            this.ChbEstadoEmpleado.TabIndex = 5;
            this.ChbEstadoEmpleado.Text = "Estado";
            this.ChbEstadoEmpleado.UseVisualStyleBackColor = true;
            // 
            // LblIsssEmpleado
            // 
            this.LblIsssEmpleado.AutoSize = true;
            this.LblIsssEmpleado.Location = new System.Drawing.Point(20, 207);
            this.LblIsssEmpleado.Name = "LblIsssEmpleado";
            this.LblIsssEmpleado.Size = new System.Drawing.Size(38, 17);
            this.LblIsssEmpleado.TabIndex = 2;
            this.LblIsssEmpleado.Text = "ISSS";
            // 
            // TxtIsssEmpleado
            // 
            this.TxtIsssEmpleado.Location = new System.Drawing.Point(120, 201);
            this.TxtIsssEmpleado.Name = "TxtIsssEmpleado";
            this.TxtIsssEmpleado.Size = new System.Drawing.Size(182, 22);
            this.TxtIsssEmpleado.TabIndex = 3;
            // 
            // LblNupEmpleado
            // 
            this.LblNupEmpleado.AutoSize = true;
            this.LblNupEmpleado.Location = new System.Drawing.Point(20, 255);
            this.LblNupEmpleado.Name = "LblNupEmpleado";
            this.LblNupEmpleado.Size = new System.Drawing.Size(37, 17);
            this.LblNupEmpleado.TabIndex = 2;
            this.LblNupEmpleado.Text = "NUP";
            // 
            // TxtNupEmpleado
            // 
            this.TxtNupEmpleado.Location = new System.Drawing.Point(120, 249);
            this.TxtNupEmpleado.Name = "TxtNupEmpleado";
            this.TxtNupEmpleado.Size = new System.Drawing.Size(182, 22);
            this.TxtNupEmpleado.TabIndex = 3;
            // 
            // FrmCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 589);
            this.Controls.Add(this.GbxControlesEmpleado);
            this.Controls.Add(this.TcEmpleado);
            this.Name = "FrmCrearEmpleado";
            this.Text = "Pantalla Empleado";
            this.TcEmpleado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GbxControlesEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcEmpleado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CmbSexoEmpleado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtDireccionEmpleado;
        private System.Windows.Forms.TextBox TxtTEmailEmpleado;
        private System.Windows.Forms.TextBox TxtApellidoEmpleado;
        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.Label LblDireccionEmpleado;
        private System.Windows.Forms.Label LblFechaCreacionEmpleado;
        private System.Windows.Forms.Label LblEmailEmpleado;
        private System.Windows.Forms.Label LblFecNacimientoEmpleado;
        private System.Windows.Forms.Label LblSexoEmpleado;
        private System.Windows.Forms.Label LblApellidoEmpleado;
        private System.Windows.Forms.Label LblNombreEmpleado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label LblGerencia;
        private System.Windows.Forms.Label LblSueldoBaseEmpleado;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label LblTelefonoEmpleado;
        private System.Windows.Forms.GroupBox GbxControlesEmpleado;
        private System.Windows.Forms.Button CmdLImpiarEmpleado;
        private System.Windows.Forms.Button CmdNuevo;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ChbEstadoEmpleado;
        private System.Windows.Forms.TextBox TxtNupEmpleado;
        private System.Windows.Forms.Label LblNupEmpleado;
        private System.Windows.Forms.TextBox TxtIsssEmpleado;
        private System.Windows.Forms.Label LblIsssEmpleado;
    }
}