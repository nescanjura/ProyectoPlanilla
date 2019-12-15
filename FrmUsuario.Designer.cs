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
            this.CmdCrearUsuario = new System.Windows.Forms.Button();
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
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
            // CmdCrearUsuario
            // 
            this.CmdCrearUsuario.Location = new System.Drawing.Point(379, 24);
            this.CmdCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdCrearUsuario.Name = "CmdCrearUsuario";
            this.CmdCrearUsuario.Size = new System.Drawing.Size(94, 29);
            this.CmdCrearUsuario.TabIndex = 0;
            this.CmdCrearUsuario.Text = "Nuevo usuario";
            this.CmdCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.AllowUserToAddRows = false;
            this.DgvUsuario.AllowUserToDeleteRows = false;
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColNombre,
            this.ColLogin,
            this.ColActivo,
            this.Actualizar,
            this.Eliminar});
            this.DgvUsuario.Location = new System.Drawing.Point(17, 71);
            this.DgvUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.RowHeadersVisible = false;
            this.DgvUsuario.RowHeadersWidth = 51;
            this.DgvUsuario.RowTemplate.Height = 24;
            this.DgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvUsuario.Size = new System.Drawing.Size(456, 162);
            this.DgvUsuario.TabIndex = 2;
            this.DgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.proyectoPlanillaDataSet;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Editar";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProyectoPlanilla.Properties.Resources.editar_naranja;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "Editar";
            this.dataGridViewImageColumn1.Width = 18;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.ToolTipText = "Eliminar";
            this.dataGridViewImageColumn2.Width = 18;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "No.";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 35;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 125;
            // 
            // ColLogin
            // 
            this.ColLogin.HeaderText = "Login";
            this.ColLogin.MinimumWidth = 6;
            this.ColLogin.Name = "ColLogin";
            this.ColLogin.Width = 125;
            // 
            // ColActivo
            // 
            this.ColActivo.HeaderText = "Activo";
            this.ColActivo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColActivo.Name = "ColActivo";
            this.ColActivo.ReadOnly = true;
            this.ColActivo.Width = 45;
            // 
            // Actualizar
            // 
            this.Actualizar.Description = "Editar";
            this.Actualizar.HeaderText = "";
            this.Actualizar.Image = global::ProyectoPlanilla.Properties.Resources.editar_naranja;
            this.Actualizar.MinimumWidth = 6;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.ReadOnly = true;
            this.Actualizar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Actualizar.ToolTipText = "Editar";
            this.Actualizar.Width = 18;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::ProyectoPlanilla.Properties.Resources.eliminar_rojo;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.Width = 18;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 253);
            this.Controls.Add(this.CmdCrearUsuario);
            this.Controls.Add(this.DgvUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private ProyectoPlanillaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button CmdCrearUsuario;
        private System.Windows.Forms.DataGridView DgvUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogin;
        private System.Windows.Forms.DataGridViewImageColumn ColActivo;
        private System.Windows.Forms.DataGridViewImageColumn Actualizar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}