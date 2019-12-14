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
            this.GbxControles = new System.Windows.Forms.GroupBox();
            this.CmdCrearPlanilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.planillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planillaTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.PlanillaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdCrearPlanilla);
            this.GbxControles.Location = new System.Drawing.Point(403, 220);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(137, 83);
            this.GbxControles.TabIndex = 3;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdCrearPlanilla
            // 
            this.CmdCrearPlanilla.Location = new System.Drawing.Point(33, 32);
            this.CmdCrearPlanilla.Name = "CmdCrearPlanilla";
            this.CmdCrearPlanilla.Size = new System.Drawing.Size(81, 32);
            this.CmdCrearPlanilla.TabIndex = 0;
            this.CmdCrearPlanilla.Text = "Crear";
            this.CmdCrearPlanilla.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.Actualizar,
            this.Eliminar});
            this.dataGridView1.DataSource = this.planillaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 153);
            this.dataGridView1.TabIndex = 4;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planillaBindingSource
            // 
            this.planillaBindingSource.DataMember = "Planilla";
            this.planillaBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // planillaTableAdapter
            // 
            this.planillaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "";
            this.Actualizar.MinimumWidth = 6;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Actualizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Actualizar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbxControles);
            this.Name = "FrmPlanilla";
            this.Text = "Pantalla Planilla";
            this.Load += new System.EventHandler(this.FrmPlanilla_Load);
            this.GbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdCrearPlanilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource planillaBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.PlanillaTableAdapter planillaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}