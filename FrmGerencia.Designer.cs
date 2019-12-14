namespace ProyectoPlanilla
{
    partial class FrmGerencia
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
            this.GbxControlesGerencia = new System.Windows.Forms.GroupBox();
            this.CmdCrearGerencia = new System.Windows.Forms.Button();
            this.DgvGerencia = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derechoBonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasExtrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeBonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gerenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.gerenciaTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.GerenciaTableAdapter();
            this.GbxControlesGerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGerencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxControlesGerencia
            // 
            this.GbxControlesGerencia.Controls.Add(this.CmdCrearGerencia);
            this.GbxControlesGerencia.Location = new System.Drawing.Point(521, 282);
            this.GbxControlesGerencia.Name = "GbxControlesGerencia";
            this.GbxControlesGerencia.Size = new System.Drawing.Size(142, 75);
            this.GbxControlesGerencia.TabIndex = 3;
            this.GbxControlesGerencia.TabStop = false;
            this.GbxControlesGerencia.Text = "Controles";
            // 
            // CmdCrearGerencia
            // 
            this.CmdCrearGerencia.Location = new System.Drawing.Point(33, 32);
            this.CmdCrearGerencia.Name = "CmdCrearGerencia";
            this.CmdCrearGerencia.Size = new System.Drawing.Size(81, 32);
            this.CmdCrearGerencia.TabIndex = 0;
            this.CmdCrearGerencia.Text = "Crear";
            this.CmdCrearGerencia.UseVisualStyleBackColor = true;
            // 
            // DgvGerencia
            // 
            this.DgvGerencia.AutoGenerateColumns = false;
            this.DgvGerencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGerencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.derechoBonoDataGridViewTextBoxColumn,
            this.horasExtrasDataGridViewTextBoxColumn,
            this.porcentajeBonoDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.Actualizar,
            this.Eliminar});
            this.DgvGerencia.DataSource = this.gerenciaBindingSource;
            this.DgvGerencia.Location = new System.Drawing.Point(33, 43);
            this.DgvGerencia.Name = "DgvGerencia";
            this.DgvGerencia.RowHeadersWidth = 51;
            this.DgvGerencia.RowTemplate.Height = 24;
            this.DgvGerencia.Size = new System.Drawing.Size(1064, 213);
            this.DgvGerencia.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // derechoBonoDataGridViewTextBoxColumn
            // 
            this.derechoBonoDataGridViewTextBoxColumn.DataPropertyName = "derechoBono";
            this.derechoBonoDataGridViewTextBoxColumn.HeaderText = "derechoBono";
            this.derechoBonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.derechoBonoDataGridViewTextBoxColumn.Name = "derechoBonoDataGridViewTextBoxColumn";
            this.derechoBonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // horasExtrasDataGridViewTextBoxColumn
            // 
            this.horasExtrasDataGridViewTextBoxColumn.DataPropertyName = "horasExtras";
            this.horasExtrasDataGridViewTextBoxColumn.HeaderText = "horasExtras";
            this.horasExtrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horasExtrasDataGridViewTextBoxColumn.Name = "horasExtrasDataGridViewTextBoxColumn";
            this.horasExtrasDataGridViewTextBoxColumn.Width = 125;
            // 
            // porcentajeBonoDataGridViewTextBoxColumn
            // 
            this.porcentajeBonoDataGridViewTextBoxColumn.DataPropertyName = "porcentajeBono";
            this.porcentajeBonoDataGridViewTextBoxColumn.HeaderText = "porcentajeBono";
            this.porcentajeBonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.porcentajeBonoDataGridViewTextBoxColumn.Name = "porcentajeBonoDataGridViewTextBoxColumn";
            this.porcentajeBonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "";
            this.Actualizar.MinimumWidth = 6;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // gerenciaBindingSource
            // 
            this.gerenciaBindingSource.DataMember = "Gerencia";
            this.gerenciaBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gerenciaTableAdapter
            // 
            this.gerenciaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 388);
            this.Controls.Add(this.DgvGerencia);
            this.Controls.Add(this.GbxControlesGerencia);
            this.Name = "FrmGerencia";
            this.Text = "Pantalla Gerencia";
            this.Load += new System.EventHandler(this.FrmGerencia_Load);
            this.GbxControlesGerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGerencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxControlesGerencia;
        private System.Windows.Forms.Button CmdCrearGerencia;
        private System.Windows.Forms.DataGridView DgvGerencia;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource gerenciaBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.GerenciaTableAdapter gerenciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derechoBonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasExtrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeBonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}