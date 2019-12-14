namespace ProyectoPlanilla
{
    partial class FrmUsuario
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
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.TableAdapterManager();
            this.GbxControles = new System.Windows.Forms.GroupBox();
            this.CmdCrearUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.GbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AfpTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetaPlanillaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.GerenciaTableAdapter = null;
            this.tableAdapterManager.PlanillaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdCrearUsuario);
            this.GbxControles.Location = new System.Drawing.Point(368, 280);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(157, 84);
            this.GbxControles.TabIndex = 1;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdCrearUsuario
            // 
            this.CmdCrearUsuario.Location = new System.Drawing.Point(33, 32);
            this.CmdCrearUsuario.Name = "CmdCrearUsuario";
            this.CmdCrearUsuario.Size = new System.Drawing.Size(81, 32);
            this.CmdCrearUsuario.TabIndex = 0;
            this.CmdCrearUsuario.Text = "Crear";
            this.CmdCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Actualizar,
            this.Eliminar});
            this.dataGridView1.DataSource = this.usuarioBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.proyectoPlanillaDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "clave";
            this.claveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            this.claveDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
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
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbxControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.GbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private ProyectoPlanillaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdCrearUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
    }
}