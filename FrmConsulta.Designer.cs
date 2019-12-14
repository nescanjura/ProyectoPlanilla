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
            this.GbxControles = new System.Windows.Forms.GroupBox();
            this.CmdImprimirConsulta = new System.Windows.Forms.Button();
            this.GbxDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.CmbEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.DtpConsultaFin = new System.Windows.Forms.DateTimePicker();
            this.DtpConsultaInicio = new System.Windows.Forms.DateTimePicker();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblFecFin = new System.Windows.Forms.Label();
            this.LblFecInicio = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.EmpleadoTableAdapter();
            this.GbxControles.SuspendLayout();
            this.GbxDatosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdImprimirConsulta);
            this.GbxControles.Location = new System.Drawing.Point(36, 290);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(423, 85);
            this.GbxControles.TabIndex = 3;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdImprimirConsulta
            // 
            this.CmdImprimirConsulta.Location = new System.Drawing.Point(160, 32);
            this.CmdImprimirConsulta.Name = "CmdImprimirConsulta";
            this.CmdImprimirConsulta.Size = new System.Drawing.Size(125, 32);
            this.CmdImprimirConsulta.TabIndex = 0;
            this.CmdImprimirConsulta.Text = "Consultar";
            this.CmdImprimirConsulta.UseVisualStyleBackColor = true;
            this.CmdImprimirConsulta.Click += new System.EventHandler(this.CmdImprimirConsulta_Click);
            // 
            // GbxDatosUsuarios
            // 
            this.GbxDatosUsuarios.Controls.Add(this.CmbEmpleado);
            this.GbxDatosUsuarios.Controls.Add(this.DtpConsultaFin);
            this.GbxDatosUsuarios.Controls.Add(this.DtpConsultaInicio);
            this.GbxDatosUsuarios.Controls.Add(this.LblEmpleado);
            this.GbxDatosUsuarios.Controls.Add(this.LblFecFin);
            this.GbxDatosUsuarios.Controls.Add(this.LblFecInicio);
            this.GbxDatosUsuarios.Location = new System.Drawing.Point(36, 40);
            this.GbxDatosUsuarios.Name = "GbxDatosUsuarios";
            this.GbxDatosUsuarios.Size = new System.Drawing.Size(423, 210);
            this.GbxDatosUsuarios.TabIndex = 2;
            this.GbxDatosUsuarios.TabStop = false;
            this.GbxDatosUsuarios.Text = "Datos";
            // 
            // CmbEmpleado
            // 
            this.CmbEmpleado.DataSource = this.empleadoBindingSource;
            this.CmbEmpleado.FormattingEnabled = true;
            this.CmbEmpleado.Location = new System.Drawing.Point(131, 156);
            this.CmbEmpleado.Name = "CmbEmpleado";
            this.CmbEmpleado.Size = new System.Drawing.Size(254, 24);
            this.CmbEmpleado.TabIndex = 4;
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
            // DtpConsultaFin
            // 
            this.DtpConsultaFin.Location = new System.Drawing.Point(131, 113);
            this.DtpConsultaFin.Name = "DtpConsultaFin";
            this.DtpConsultaFin.Size = new System.Drawing.Size(254, 22);
            this.DtpConsultaFin.TabIndex = 3;
            // 
            // DtpConsultaInicio
            // 
            this.DtpConsultaInicio.Location = new System.Drawing.Point(131, 59);
            this.DtpConsultaInicio.Name = "DtpConsultaInicio";
            this.DtpConsultaInicio.Size = new System.Drawing.Size(254, 22);
            this.DtpConsultaInicio.TabIndex = 2;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Location = new System.Drawing.Point(30, 165);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(71, 17);
            this.LblEmpleado.TabIndex = 1;
            this.LblEmpleado.Text = "Empleado";
            // 
            // LblFecFin
            // 
            this.LblFecFin.AutoSize = true;
            this.LblFecFin.Location = new System.Drawing.Point(30, 113);
            this.LblFecFin.Name = "LblFecFin";
            this.LblFecFin.Size = new System.Drawing.Size(66, 17);
            this.LblFecFin.TabIndex = 1;
            this.LblFecFin.Text = "Fecha fin";
            // 
            // LblFecInicio
            // 
            this.LblFecInicio.AutoSize = true;
            this.LblFecInicio.Location = new System.Drawing.Point(30, 59);
            this.LblFecInicio.Name = "LblFecInicio";
            this.LblFecInicio.Size = new System.Drawing.Size(83, 17);
            this.LblFecInicio.TabIndex = 0;
            this.LblFecInicio.Text = "Fecha Inicio";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 423);
            this.Controls.Add(this.GbxControles);
            this.Controls.Add(this.GbxDatosUsuarios);
            this.Name = "FrmConsulta";
            this.Text = "Pantalla Consulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.GbxControles.ResumeLayout(false);
            this.GbxDatosUsuarios.ResumeLayout(false);
            this.GbxDatosUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdImprimirConsulta;
        private System.Windows.Forms.GroupBox GbxDatosUsuarios;
        private System.Windows.Forms.ComboBox CmbEmpleado;
        private System.Windows.Forms.DateTimePicker DtpConsultaFin;
        private System.Windows.Forms.DateTimePicker DtpConsultaInicio;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblFecFin;
        private System.Windows.Forms.Label LblFecInicio;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
    }
}