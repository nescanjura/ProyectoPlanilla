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
            this.GbxDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.GbxControles = new System.Windows.Forms.GroupBox();
            this.CmdEliminarUsuario = new System.Windows.Forms.Button();
            this.CmdActualizarUsuario = new System.Windows.Forms.Button();
            this.CmdCrearUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.GbxDatosUsuarios.SuspendLayout();
            this.GbxControles.SuspendLayout();
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
            // GbxDatosUsuarios
            // 
            this.GbxDatosUsuarios.Controls.Add(this.TxtUsuario);
            this.GbxDatosUsuarios.Controls.Add(this.TxtClave);
            this.GbxDatosUsuarios.Controls.Add(this.TxtLogin);
            this.GbxDatosUsuarios.Controls.Add(this.LblUsuario);
            this.GbxDatosUsuarios.Controls.Add(this.LblClave);
            this.GbxDatosUsuarios.Controls.Add(this.LblLogin);
            this.GbxDatosUsuarios.Location = new System.Drawing.Point(29, 47);
            this.GbxDatosUsuarios.Name = "GbxDatosUsuarios";
            this.GbxDatosUsuarios.Size = new System.Drawing.Size(423, 210);
            this.GbxDatosUsuarios.TabIndex = 0;
            this.GbxDatosUsuarios.TabStop = false;
            this.GbxDatosUsuarios.Text = "Datos";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(136, 148);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(263, 22);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(136, 101);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(263, 22);
            this.TxtClave.TabIndex = 2;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(136, 54);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(263, 22);
            this.TxtLogin.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(33, 153);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(30, 106);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(43, 17);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(30, 59);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(43, 17);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login";
            // 
            // GbxControles
            // 
            this.GbxControles.Controls.Add(this.CmdEliminarUsuario);
            this.GbxControles.Controls.Add(this.CmdActualizarUsuario);
            this.GbxControles.Controls.Add(this.CmdCrearUsuario);
            this.GbxControles.Location = new System.Drawing.Point(29, 297);
            this.GbxControles.Name = "GbxControles";
            this.GbxControles.Size = new System.Drawing.Size(423, 85);
            this.GbxControles.TabIndex = 1;
            this.GbxControles.TabStop = false;
            this.GbxControles.Text = "Controles";
            // 
            // CmdEliminarUsuario
            // 
            this.CmdEliminarUsuario.Location = new System.Drawing.Point(324, 32);
            this.CmdEliminarUsuario.Name = "CmdEliminarUsuario";
            this.CmdEliminarUsuario.Size = new System.Drawing.Size(75, 32);
            this.CmdEliminarUsuario.TabIndex = 0;
            this.CmdEliminarUsuario.Text = "Eliminar";
            this.CmdEliminarUsuario.UseVisualStyleBackColor = true;
            this.CmdEliminarUsuario.Click += new System.EventHandler(this.CmdEliminarUsuario_Click);
            // 
            // CmdActualizarUsuario
            // 
            this.CmdActualizarUsuario.Location = new System.Drawing.Point(160, 32);
            this.CmdActualizarUsuario.Name = "CmdActualizarUsuario";
            this.CmdActualizarUsuario.Size = new System.Drawing.Size(125, 32);
            this.CmdActualizarUsuario.TabIndex = 0;
            this.CmdActualizarUsuario.Text = "Actualizar";
            this.CmdActualizarUsuario.UseVisualStyleBackColor = true;
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
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 410);
            this.Controls.Add(this.GbxControles);
            this.Controls.Add(this.GbxDatosUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.GbxDatosUsuarios.ResumeLayout(false);
            this.GbxDatosUsuarios.PerformLayout();
            this.GbxControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private ProyectoPlanillaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox GbxDatosUsuarios;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.GroupBox GbxControles;
        private System.Windows.Forms.Button CmdEliminarUsuario;
        private System.Windows.Forms.Button CmdActualizarUsuario;
        private System.Windows.Forms.Button CmdCrearUsuario;
    }
}