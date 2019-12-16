namespace ProyectoPlanilla
{
    partial class FrmEmpleado
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
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.EmpleadoTableAdapter();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSueldoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CmdCrearEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.AllowUserToAddRows = false;
            this.DgvEmpleado.AllowUserToDeleteRows = false;
            this.DgvEmpleado.AllowUserToResizeColumns = false;
            this.DgvEmpleado.AllowUserToResizeRows = false;
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColNombre,
            this.ColApellido,
            this.ColTelefono,
            this.ColDireccion,
            this.ColEmail,
            this.ColSueldoBase,
            this.ColGerencia,
            this.ColUsuario,
            this.ColEditar,
            this.ColEliminar});
            this.DgvEmpleado.Location = new System.Drawing.Point(6, 53);
            this.DgvEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.RowHeadersVisible = false;
            this.DgvEmpleado.RowHeadersWidth = 51;
            this.DgvEmpleado.RowTemplate.Height = 24;
            this.DgvEmpleado.Size = new System.Drawing.Size(806, 236);
            this.DgvEmpleado.TabIndex = 4;
            this.DgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleado_CellContentClick);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            this.empleadoBindingSource1.DataSource = this.proyectoPlanillaDataSet;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "No.";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 40;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 80;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 80;
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Teléfono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 65;
            // 
            // ColDireccion
            // 
            this.ColDireccion.HeaderText = "Dirección";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            this.ColDireccion.Width = 120;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColSueldoBase
            // 
            this.ColSueldoBase.HeaderText = "Sueldo";
            this.ColSueldoBase.Name = "ColSueldoBase";
            this.ColSueldoBase.ReadOnly = true;
            this.ColSueldoBase.Width = 50;
            // 
            // ColGerencia
            // 
            this.ColGerencia.HeaderText = "Gerencia";
            this.ColGerencia.Name = "ColGerencia";
            this.ColGerencia.ReadOnly = true;
            this.ColGerencia.Width = 70;
            // 
            // ColUsuario
            // 
            this.ColUsuario.HeaderText = "Registrado por";
            this.ColUsuario.Name = "ColUsuario";
            this.ColUsuario.ReadOnly = true;
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "";
            this.ColEditar.Image = global::ProyectoPlanilla.Properties.Resources.editar_naranja;
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            this.ColEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEditar.Width = 30;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "";
            this.ColEliminar.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEliminar.Width = 30;
            // 
            // CmdCrearEmpleado
            // 
            this.CmdCrearEmpleado.Location = new System.Drawing.Point(665, 11);
            this.CmdCrearEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.CmdCrearEmpleado.Name = "CmdCrearEmpleado";
            this.CmdCrearEmpleado.Size = new System.Drawing.Size(147, 26);
            this.CmdCrearEmpleado.TabIndex = 0;
            this.CmdCrearEmpleado.Text = "Crear Nuevo Empleado";
            this.CmdCrearEmpleado.UseVisualStyleBackColor = true;
            this.CmdCrearEmpleado.Click += new System.EventHandler(this.CmdCrearEmpleado_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 299);
            this.Controls.Add(this.CmdCrearEmpleado);
            this.Controls.Add(this.DgvEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvEmpleado;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSueldoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGerencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
        private System.Windows.Forms.DataGridViewImageColumn ColEditar;
        private System.Windows.Forms.DataGridViewImageColumn ColEliminar;
        private System.Windows.Forms.Button CmdCrearEmpleado;
    }
}