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
            this.Gerencia = new System.Windows.Forms.ToolStripMenuItem();
            this.Planilla = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerarPlanilla = new System.Windows.Forms.ToolStripMenuItem();
            this.Planillas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mantenimiento,
            this.Planilla});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuario,
            this.Empleado,
            this.Gerencia});
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Size = new System.Drawing.Size(116, 20);
            this.Mantenimiento.Text = "MANTENIMIENTO";
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(152, 22);
            this.Usuario.Text = "USUARIO";
            this.Usuario.Click += new System.EventHandler(this.uSUARIOToolStripMenuItem_Click);
            // 
            // Empleado
            // 
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(152, 22);
            this.Empleado.Text = "EMPLEADO";
            this.Empleado.Click += new System.EventHandler(this.eMPLEADOToolStripMenuItem_Click);
            // 
            // Gerencia
            // 
            this.Gerencia.Name = "Gerencia";
            this.Gerencia.Size = new System.Drawing.Size(152, 22);
            this.Gerencia.Text = "GERENCIA";
            this.Gerencia.Click += new System.EventHandler(this.gERENCIAToolStripMenuItem_Click);
            // 
            // Planilla
            // 
            this.Planilla.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Planillas,
            this.GenerarPlanilla});
            this.Planilla.Name = "Planilla";
            this.Planilla.Size = new System.Drawing.Size(72, 20);
            this.Planilla.Text = "PLANILLA";
            // 
            // GenerarPlanilla
            // 
            this.GenerarPlanilla.Name = "GenerarPlanilla";
            this.GenerarPlanilla.Size = new System.Drawing.Size(152, 22);
            this.GenerarPlanilla.Text = "CONSULTAR";
            this.GenerarPlanilla.Click += new System.EventHandler(this.gENERARPLANILLAToolStripMenuItem_Click);
            // 
            // Planillas
            // 
            this.Planillas.Name = "Planillas";
            this.Planillas.Size = new System.Drawing.Size(152, 22);
            this.Planillas.Text = "PLANILLAS";
            this.Planillas.Click += new System.EventHandler(this.Planillas_Click);
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 607);
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
        private System.Windows.Forms.ToolStripMenuItem Gerencia;
        private System.Windows.Forms.ToolStripMenuItem Planillas;
    }
}

