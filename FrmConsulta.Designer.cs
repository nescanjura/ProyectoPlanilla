namespace ProyectoPlanilla
{
    partial class FrmConsulta
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
            this.components = new System.ComponentModel.Container();
            this.GbxControlesConsulta = new System.Windows.Forms.GroupBox();
            this.CmdImprimirConsulta = new System.Windows.Forms.Button();
            this.GbxDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.CmbEmpleadoConsulta = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblFecInicio = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.EmpleadoTableAdapter();
            this.DtpConsultaInicio = new System.Windows.Forms.DateTimePicker();
            this.GbxControlesConsulta.SuspendLayout();
            this.GbxDatosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxControlesConsulta
            // 
            this.GbxControlesConsulta.Controls.Add(this.CmdImprimirConsulta);
            this.GbxControlesConsulta.Location = new System.Drawing.Point(27, 170);
            this.GbxControlesConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxControlesConsulta.Name = "GbxControlesConsulta";
            this.GbxControlesConsulta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxControlesConsulta.Size = new System.Drawing.Size(317, 69);
            this.GbxControlesConsulta.TabIndex = 3;
            this.GbxControlesConsulta.TabStop = false;
            this.GbxControlesConsulta.Text = "Controles";
            // 
            // CmdImprimirConsulta
            // 
            this.CmdImprimirConsulta.Location = new System.Drawing.Point(120, 26);
            this.CmdImprimirConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdImprimirConsulta.Name = "CmdImprimirConsulta";
            this.CmdImprimirConsulta.Size = new System.Drawing.Size(94, 26);
            this.CmdImprimirConsulta.TabIndex = 0;
            this.CmdImprimirConsulta.Text = "Consultar";
            this.CmdImprimirConsulta.UseVisualStyleBackColor = true;
            this.CmdImprimirConsulta.Click += new System.EventHandler(this.CmdImprimirConsulta_Click);
            // 
            // GbxDatosUsuarios
            // 
            this.GbxDatosUsuarios.Controls.Add(this.CmbEmpleadoConsulta);
            this.GbxDatosUsuarios.Controls.Add(this.DtpConsultaInicio);
            this.GbxDatosUsuarios.Controls.Add(this.LblEmpleado);
            this.GbxDatosUsuarios.Controls.Add(this.LblFecInicio);
            this.GbxDatosUsuarios.Location = new System.Drawing.Point(27, 32);
            this.GbxDatosUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxDatosUsuarios.Name = "GbxDatosUsuarios";
            this.GbxDatosUsuarios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxDatosUsuarios.Size = new System.Drawing.Size(317, 117);
            this.GbxDatosUsuarios.TabIndex = 2;
            this.GbxDatosUsuarios.TabStop = false;
            this.GbxDatosUsuarios.Text = "Datos";
            // 
            // CmbEmpleadoConsulta
            // 
            this.CmbEmpleadoConsulta.FormattingEnabled = true;
            this.CmbEmpleadoConsulta.Location = new System.Drawing.Point(98, 32);
            this.CmbEmpleadoConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbEmpleadoConsulta.Name = "CmbEmpleadoConsulta";
            this.CmbEmpleadoConsulta.Size = new System.Drawing.Size(192, 21);
            this.CmbEmpleadoConsulta.TabIndex = 4;
            this.CmbEmpleadoConsulta.Text = "[Seleccione]";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Location = new System.Drawing.Point(22, 36);
            this.LblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.LblEmpleado.TabIndex = 1;
            this.LblEmpleado.Text = "Empleado";
            // 
            // LblFecInicio
            // 
            this.LblFecInicio.AutoSize = true;
            this.LblFecInicio.Location = new System.Drawing.Point(22, 73);
            this.LblFecInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecInicio.Name = "LblFecInicio";
            this.LblFecInicio.Size = new System.Drawing.Size(27, 13);
            this.LblFecInicio.TabIndex = 0;
            this.LblFecInicio.Text = "Mes";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // DtpConsultaInicio
            // 
            this.DtpConsultaInicio.CustomFormat = "MMMM yyyy";
            this.DtpConsultaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpConsultaInicio.ShowUpDown = true;
            this.DtpConsultaInicio.Location = new System.Drawing.Point(98, 73);
            this.DtpConsultaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DtpConsultaInicio.Name = "DtpConsultaInicio";
            this.DtpConsultaInicio.Size = new System.Drawing.Size(192, 20);
            this.DtpConsultaInicio.TabIndex = 2;
            // 
            // FrmConsulta
            // 
            this.AcceptButton = this.CmdImprimirConsulta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 252);
            this.Controls.Add(this.GbxControlesConsulta);
            this.Controls.Add(this.GbxDatosUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConsulta";
            this.Text = "Pantalla Consulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.GbxControlesConsulta.ResumeLayout(false);
            this.GbxDatosUsuarios.ResumeLayout(false);
            this.GbxDatosUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControlesConsulta;
        private System.Windows.Forms.Button CmdImprimirConsulta;
        private System.Windows.Forms.GroupBox GbxDatosUsuarios;
        private System.Windows.Forms.ComboBox CmbEmpleadoConsulta;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblFecInicio;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DateTimePicker DtpConsultaInicio;
    }
}