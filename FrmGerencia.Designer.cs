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
            this.DgvGerencia = new System.Windows.Forms.DataGridView();
            this.gerenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.gerenciaTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.GerenciaTableAdapter();
            this.CmdCrearGerencia = new System.Windows.Forms.Button();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorasExtras = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColBono = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColPorcentajeBono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGerencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvGerencia
            // 
            this.DgvGerencia.AllowUserToAddRows = false;
            this.DgvGerencia.AllowUserToDeleteRows = false;
            this.DgvGerencia.AllowUserToResizeColumns = false;
            this.DgvGerencia.AllowUserToResizeRows = false;
            this.DgvGerencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGerencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColNombre,
            this.ColHorasExtras,
            this.ColBono,
            this.ColPorcentajeBono,
            this.ColEditar,
            this.ColEliminar});
            this.DgvGerencia.Location = new System.Drawing.Point(33, 43);
            this.DgvGerencia.Name = "DgvGerencia";
            this.DgvGerencia.RowHeadersVisible = false;
            this.DgvGerencia.RowHeadersWidth = 51;
            this.DgvGerencia.RowTemplate.Height = 24;
            this.DgvGerencia.Size = new System.Drawing.Size(1064, 213);
            this.DgvGerencia.TabIndex = 4;
            this.DgvGerencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGerencia_CellContentClick);
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
            // CmdCrearGerencia
            // 
            this.CmdCrearGerencia.Location = new System.Drawing.Point(900, 277);
            this.CmdCrearGerencia.Name = "CmdCrearGerencia";
            this.CmdCrearGerencia.Size = new System.Drawing.Size(180, 32);
            this.CmdCrearGerencia.TabIndex = 0;
            this.CmdCrearGerencia.Text = "Crear Nueva Gerencia";
            this.CmdCrearGerencia.UseVisualStyleBackColor = true;
            this.CmdCrearGerencia.Click += new System.EventHandler(this.CmdCrearGerencia_Click);
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "No.";
            this.ColNumero.MinimumWidth = 6;
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 30;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 125;
            // 
            // ColHorasExtras
            // 
            this.ColHorasExtras.HeaderText = "Horas extras";
            this.ColHorasExtras.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColHorasExtras.MinimumWidth = 6;
            this.ColHorasExtras.Name = "ColHorasExtras";
            this.ColHorasExtras.ReadOnly = true;
            this.ColHorasExtras.Width = 125;
            // 
            // ColBono
            // 
            this.ColBono.HeaderText = "Bono";
            this.ColBono.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColBono.MinimumWidth = 6;
            this.ColBono.Name = "ColBono";
            this.ColBono.ReadOnly = true;
            this.ColBono.Width = 125;
            // 
            // ColPorcentajeBono
            // 
            this.ColPorcentajeBono.HeaderText = "% Bono";
            this.ColPorcentajeBono.MinimumWidth = 6;
            this.ColPorcentajeBono.Name = "ColPorcentajeBono";
            this.ColPorcentajeBono.ReadOnly = true;
            this.ColPorcentajeBono.Width = 125;
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "";
            this.ColEditar.Image = global::ProyectoPlanilla.Properties.Resources.editar_naranja;
            this.ColEditar.MinimumWidth = 6;
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            this.ColEditar.Width = 35;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "";
            this.ColEliminar.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.ColEliminar.MinimumWidth = 6;
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Width = 35;
            // 
            // FrmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 328);
            this.Controls.Add(this.CmdCrearGerencia);
            this.Controls.Add(this.DgvGerencia);
            this.Name = "FrmGerencia";
            this.Text = "Pantalla Nueva Gerencia";
            this.Load += new System.EventHandler(this.FrmGerencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGerencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvGerencia;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource gerenciaBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.GerenciaTableAdapter gerenciaTableAdapter;
        private System.Windows.Forms.Button CmdCrearGerencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewImageColumn ColHorasExtras;
        private System.Windows.Forms.DataGridViewImageColumn ColBono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPorcentajeBono;
        private System.Windows.Forms.DataGridViewImageColumn ColEditar;
        private System.Windows.Forms.DataGridViewImageColumn ColEliminar;
    }
}