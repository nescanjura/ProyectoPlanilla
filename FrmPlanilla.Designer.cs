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
            this.components = new System.ComponentModel.Container();
            this.CmdCrearPlanilla = new System.Windows.Forms.Button();
            this.DgvPlanilla = new System.Windows.Forms.DataGridView();
            this.planillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.planillaTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.PlanillaTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCrearPlanilla
            // 
            this.CmdCrearPlanilla.Location = new System.Drawing.Point(399, 11);
            this.CmdCrearPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.CmdCrearPlanilla.Name = "CmdCrearPlanilla";
            this.CmdCrearPlanilla.Size = new System.Drawing.Size(113, 26);
            this.CmdCrearPlanilla.TabIndex = 0;
            this.CmdCrearPlanilla.Text = "Crear Nueva Planilla";
            this.CmdCrearPlanilla.UseVisualStyleBackColor = true;
            this.CmdCrearPlanilla.Click += new System.EventHandler(this.CmdCrearPlanilla_Click);
            // 
            // DgvPlanilla
            // 
            this.DgvPlanilla.AllowUserToAddRows = false;
            this.DgvPlanilla.AllowUserToDeleteRows = false;
            this.DgvPlanilla.AllowUserToResizeColumns = false;
            this.DgvPlanilla.AllowUserToResizeRows = false;
            this.DgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColNombre,
            this.ColFecha,
            this.ColDetalle,
            this.ColEliminar});
            this.DgvPlanilla.Location = new System.Drawing.Point(11, 61);
            this.DgvPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.DgvPlanilla.Name = "DgvPlanilla";
            this.DgvPlanilla.RowHeadersVisible = false;
            this.DgvPlanilla.RowHeadersWidth = 51;
            this.DgvPlanilla.RowTemplate.Height = 24;
            this.DgvPlanilla.Size = new System.Drawing.Size(501, 124);
            this.DgvPlanilla.TabIndex = 4;
            this.DgvPlanilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPlanilla_CellContentClick);
            // 
            // planillaBindingSource
            // 
            this.planillaBindingSource.DataMember = "Planilla";
            this.planillaBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planillaTableAdapter
            // 
            this.planillaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 40;
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
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColDetalle
            // 
            this.ColDetalle.HeaderText = "";
            this.ColDetalle.Image = global::ProyectoPlanilla.Properties.Resources.eye;
            this.ColDetalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColDetalle.Name = "ColDetalle";
            this.ColDetalle.ReadOnly = true;
            this.ColDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDetalle.Width = 35;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "";
            this.ColEliminar.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Width = 35;
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 209);
            this.Controls.Add(this.CmdCrearPlanilla);
            this.Controls.Add(this.DgvPlanilla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPlanilla";
            this.Text = "Pantalla Planilla";
            this.Load += new System.EventHandler(this.FrmPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdCrearPlanilla;
        private System.Windows.Forms.DataGridView DgvPlanilla;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource planillaBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.PlanillaTableAdapter planillaTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewImageColumn ColDetalle;
        private System.Windows.Forms.DataGridViewImageColumn ColEliminar;
    }
}