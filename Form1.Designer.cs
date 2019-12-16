namespace ProyectoPlanilla
{
    partial class FrmPantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.Empleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Planilla = new System.Windows.Forms.ToolStripMenuItem();
            this.Planillas = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerarPlanilla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.TxtCerrarSesion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mantenimiento,
            this.Planilla,
            this.toolStripMenuItem1,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripTextBox4,
            this.TxtNombreUsuario,
            this.TxtCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(892, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuario,
            this.Empleado});
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Size = new System.Drawing.Size(116, 23);
            this.Mantenimiento.Text = "MANTENIMIENTO";
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(135, 22);
            this.Usuario.Text = "USUARIO";
            this.Usuario.Click += new System.EventHandler(this.uSUARIOToolStripMenuItem_Click);
            // 
            // Empleado
            // 
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(135, 22);
            this.Empleado.Text = "EMPLEADO";
            this.Empleado.Click += new System.EventHandler(this.eMPLEADOToolStripMenuItem_Click);
            // 
            // Planilla
            // 
            this.Planilla.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Planillas,
            this.GenerarPlanilla});
            this.Planilla.Name = "Planilla";
            this.Planilla.Size = new System.Drawing.Size(72, 23);
            this.Planilla.Text = "PLANILLA";
            // 
            // Planillas
            // 
            this.Planillas.Name = "Planillas";
            this.Planillas.Size = new System.Drawing.Size(140, 22);
            this.Planillas.Text = "PLANILLAS";
            this.Planillas.Click += new System.EventHandler(this.Planillas_Click);
            // 
            // GenerarPlanilla
            // 
            this.GenerarPlanilla.Name = "GenerarPlanilla";
            this.GenerarPlanilla.Size = new System.Drawing.Size(140, 22);
            this.GenerarPlanilla.Text = "CONSULTAR";
            this.GenerarPlanilla.Click += new System.EventHandler(this.gENERARPLANILLAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.ReadOnly = true;
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.ReadOnly = true;
            this.TxtNombreUsuario.Size = new System.Drawing.Size(100, 23);
            this.TxtNombreUsuario.Text = "Usuario";
            // 
            // TxtCerrarSesion
            // 
            this.TxtCerrarSesion.Name = "TxtCerrarSesion";
            this.TxtCerrarSesion.ReadOnly = true;
            this.TxtCerrarSesion.Size = new System.Drawing.Size(100, 23);
            this.TxtCerrarSesion.Text = "Cerrar sesión";
            this.TxtCerrarSesion.Click += new System.EventHandler(this.TxtCerrarSesion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 410);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.ToolStripMenuItem Empleado;
        private System.Windows.Forms.ToolStripMenuItem Planilla;
        private System.Windows.Forms.ToolStripMenuItem GenerarPlanilla;
        private System.Windows.Forms.ToolStripMenuItem Planillas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox TxtNombreUsuario;
        private System.Windows.Forms.ToolStripTextBox TxtCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

