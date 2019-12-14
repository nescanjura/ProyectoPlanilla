namespace ProyectoPlanilla
{
    partial class FrmDetaPlanilla
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
            this.DgvDetaPlanilla = new System.Windows.Forms.DataGridView();
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.detaPlanillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detaPlanillaTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.DetaPlanillaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanillaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afpEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afpEmpleadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAfpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbxControles = new System.Windows.Forms.GroupBox();
            this.CmdEliminarDetallePlanilla = new System.Windows.Forms.Button();
            this.CmdActualizarDetallePlanilla = new System.Windows.Forms.Button();
            this.CmdCrearDetallePlanila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetaPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaPlanillaBindingSource)).BeginInit();
            this.GbxControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDetaPlanilla
            // 
            this.DgvDetaPlanilla.AutoGenerateColumns = false;
            this.DgvDetaPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetaPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.idPlanillaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.sueldoBaseDataGridViewTextBoxColumn,
            this.isssDataGridViewTextBoxColumn,
            this.afpEmpleadoDataGridViewTextBoxColumn,
            this.afpEmpleadorDataGridViewTextBoxColumn,
            this.idAfpDataGridViewTextBoxColumn,
            this.rentaDataGridViewTextBoxColumn});
            this.DgvDetaPlanilla.DataSource = this.detaPlanillaBindingSource;
            this.DgvDetaPlanilla.Location = new System.Drawing.Point(36, 66);
            this.DgvDetaPlanilla.Name = "DgvDetaPlanilla";
            this.DgvDetaPlanilla.RowHeadersWidth = 51;
            this.DgvDetaPlanilla.RowTemplate.Height = 24;
            this.DgvDetaPlanilla.Size = new System.Drawing.Size(998, 219);
            this.DgvDetaPlanilla.TabIndex = 0;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detaPlanillaBindingSource
            // 
            this.detaPlanillaBindingSource.DataMember = "DetaPlanilla";
            this.detaPlanillaBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // detaPlanillaTableAdapter
            // 
            this.detaPlanillaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPlanillaDataGridViewTextBoxColumn
            // 
            this.idPlanillaDataGridViewTextBoxColumn.DataPropertyName = "idPlanilla";
            this.idPlanillaDataGridViewTextBoxColumn.HeaderText = "idPlanilla";
            this.idPlanillaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlanillaDataGridViewTextBoxColumn.Name = "idPlanillaDataGridViewTextBoxColumn";
            this.idPlanillaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // sueldoBaseDataGridViewTextBoxColumn
            // 
            this.sueldoBaseDataGridViewTextBoxColumn.DataPropertyName = "sueldoBase";
            this.sueldoBaseDataGridViewTextBoxColumn.HeaderText = "sueldoBase";
            this.sueldoBaseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sueldoBaseDataGridViewTextBoxColumn.Name = "sueldoBaseDataGridViewTextBoxColumn";
            this.sueldoBaseDataGridViewTextBoxColumn.Width = 125;
            // 
            // isssDataGridViewTextBoxColumn
            // 
            this.isssDataGridViewTextBoxColumn.DataPropertyName = "isss";
            this.isssDataGridViewTextBoxColumn.HeaderText = "isss";
            this.isssDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isssDataGridViewTextBoxColumn.Name = "isssDataGridViewTextBoxColumn";
            this.isssDataGridViewTextBoxColumn.Width = 125;
            // 
            // afpEmpleadoDataGridViewTextBoxColumn
            // 
            this.afpEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "afpEmpleado";
            this.afpEmpleadoDataGridViewTextBoxColumn.HeaderText = "afpEmpleado";
            this.afpEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.afpEmpleadoDataGridViewTextBoxColumn.Name = "afpEmpleadoDataGridViewTextBoxColumn";
            this.afpEmpleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // afpEmpleadorDataGridViewTextBoxColumn
            // 
            this.afpEmpleadorDataGridViewTextBoxColumn.DataPropertyName = "afpEmpleador";
            this.afpEmpleadorDataGridViewTextBoxColumn.HeaderText = "afpEmpleador";
            this.afpEmpleadorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.afpEmpleadorDataGridViewTextBoxColumn.Name = "afpEmpleadorDataGridViewTextBoxColumn";
            this.afpEmpleadorDataGridViewTextBoxColumn.Width = 125;
            // 
            // idAfpDataGridViewTextBoxColumn
            // 
            this.idAfpDataGridViewTextBoxColumn.DataPropertyName = "idAfp";
            this.idAfpDataGridViewTextBoxColumn.HeaderText = "idAfp";
            this.idAfpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAfpDataGridViewTextBoxColumn.Name = "idAfpDataGridViewTextBoxColumn";
            this.idAfpDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentaDataGridViewTextBoxColumn
            // 
            this.rentaDataGridViewTextBoxColumn.DataPropertyName = "renta";
            this.rentaDataGridViewTextBoxColumn.HeaderText = "renta";
            this.rentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentaDataGridViewTextBoxColumn.Name = "rentaDataGridViewTextBoxColumn";
            this.rentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdEliminarDetallePlanilla);
            this.GbxControles.Controls.Add(this.CmdActualizarDetallePlanilla);
            this.GbxControles.Controls.Add(this.CmdCrearDetallePlanila);
            this.GbxControles.Location = new System.Drawing.Point(336, 331);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(423, 85);
            this.GbxControles.TabIndex = 2;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdEliminarDetallePlanilla
            // 
            this.CmdEliminarDetallePlanilla.Location = new System.Drawing.Point(324, 32);
            this.CmdEliminarDetallePlanilla.Name = "CmdEliminarDetallePlanilla";
            this.CmdEliminarDetallePlanilla.Size = new System.Drawing.Size(75, 32);
            this.CmdEliminarDetallePlanilla.TabIndex = 0;
            this.CmdEliminarDetallePlanilla.Text = "Eliminar";
            this.CmdEliminarDetallePlanilla.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarDetallePlanilla
            // 
            this.CmdActualizarDetallePlanilla.Location = new System.Drawing.Point(160, 32);
            this.CmdActualizarDetallePlanilla.Name = "CmdActualizarDetallePlanilla";
            this.CmdActualizarDetallePlanilla.Size = new System.Drawing.Size(125, 32);
            this.CmdActualizarDetallePlanilla.TabIndex = 0;
            this.CmdActualizarDetallePlanilla.Text = "Actualizar";
            this.CmdActualizarDetallePlanilla.UseVisualStyleBackColor = true;
            // 
            // CmdCrearDetallePlanila
            // 
            this.CmdCrearDetallePlanila.Location = new System.Drawing.Point(33, 32);
            this.CmdCrearDetallePlanila.Name = "CmdCrearDetallePlanila";
            this.CmdCrearDetallePlanila.Size = new System.Drawing.Size(81, 32);
            this.CmdCrearDetallePlanila.TabIndex = 0;
            this.CmdCrearDetallePlanila.Text = "Crear";
            this.CmdCrearDetallePlanila.UseVisualStyleBackColor = true;
            // 
            // FrmDetaPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 441);
            this.Controls.Add(this.GbxControles);
            this.Controls.Add(this.DgvDetaPlanilla);
            this.Name = "FrmDetaPlanilla";
            this.Text = "FrmDetaPlanilla";
            this.Load += new System.EventHandler(this.FrmDetaPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetaPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaPlanillaBindingSource)).EndInit();
            this.GbxControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetaPlanilla;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource detaPlanillaBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.DetaPlanillaTableAdapter detaPlanillaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanillaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afpEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afpEmpleadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAfpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdEliminarDetallePlanilla;
        private System.Windows.Forms.Button CmdActualizarDetallePlanilla;
        private System.Windows.Forms.Button CmdCrearDetallePlanila;
    }
}