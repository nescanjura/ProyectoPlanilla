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
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSueldoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAfpEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAfpEmpleador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaPlanillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoPlanillaDataSet = new ProyectoPlanilla.ProyectoPlanillaDataSet();
            this.detaPlanillaTableAdapter = new ProyectoPlanilla.ProyectoPlanillaDataSetTableAdapters.DetaPlanillaTableAdapter();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombrePlanilla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFechaPlanilla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetaPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaPlanillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDetaPlanilla
            // 
            this.DgvDetaPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetaPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColEmpleado,
            this.ColSueldoBase,
            this.ColIsss,
            this.ColAfpEmpleado,
            this.ColAfpEmpleador,
            this.ColRenta});
            this.DgvDetaPlanilla.Location = new System.Drawing.Point(11, 98);
            this.DgvDetaPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.DgvDetaPlanilla.Name = "DgvDetaPlanilla";
            this.DgvDetaPlanilla.RowHeadersVisible = false;
            this.DgvDetaPlanilla.RowHeadersWidth = 51;
            this.DgvDetaPlanilla.RowTemplate.Height = 24;
            this.DgvDetaPlanilla.Size = new System.Drawing.Size(677, 219);
            this.DgvDetaPlanilla.TabIndex = 0;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "No.";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 40;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            this.ColEmpleado.Width = 140;
            // 
            // ColSueldoBase
            // 
            this.ColSueldoBase.HeaderText = "Sueldo Base";
            this.ColSueldoBase.Name = "ColSueldoBase";
            this.ColSueldoBase.ReadOnly = true;
            this.ColSueldoBase.Width = 90;
            // 
            // ColIsss
            // 
            this.ColIsss.HeaderText = "ISSS";
            this.ColIsss.Name = "ColIsss";
            this.ColIsss.ReadOnly = true;
            this.ColIsss.Width = 70;
            // 
            // ColAfpEmpleado
            // 
            this.ColAfpEmpleado.HeaderText = "AFP Empleado";
            this.ColAfpEmpleado.Name = "ColAfpEmpleado";
            this.ColAfpEmpleado.ReadOnly = true;
            // 
            // ColAfpEmpleador
            // 
            this.ColAfpEmpleador.HeaderText = "AFP Empleador";
            this.ColAfpEmpleador.Name = "ColAfpEmpleador";
            this.ColAfpEmpleador.ReadOnly = true;
            // 
            // ColRenta
            // 
            this.ColRenta.HeaderText = "Renta";
            this.ColRenta.Name = "ColRenta";
            this.ColRenta.ReadOnly = true;
            this.ColRenta.Width = 80;
            // 
            // detaPlanillaBindingSource
            // 
            this.detaPlanillaBindingSource.DataMember = "DetaPlanilla";
            this.detaPlanillaBindingSource.DataSource = this.proyectoPlanillaDataSet;
            // 
            // proyectoPlanillaDataSet
            // 
            this.proyectoPlanillaDataSet.DataSetName = "ProyectoPlanillaDataSet";
            this.proyectoPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detaPlanillaTableAdapter
            // 
            this.detaPlanillaTableAdapter.ClearBeforeFill = true;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(31, 26);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(62, 20);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Planilla:";
            // 
            // LblNombrePlanilla
            // 
            this.LblNombrePlanilla.AutoSize = true;
            this.LblNombrePlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNombrePlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePlanilla.Location = new System.Drawing.Point(113, 27);
            this.LblNombrePlanilla.Name = "LblNombrePlanilla";
            this.LblNombrePlanilla.Size = new System.Drawing.Size(2, 22);
            this.LblNombrePlanilla.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // LblFechaPlanilla
            // 
            this.LblFechaPlanilla.AutoSize = true;
            this.LblFechaPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFechaPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaPlanilla.Location = new System.Drawing.Point(113, 61);
            this.LblFechaPlanilla.Name = "LblFechaPlanilla";
            this.LblFechaPlanilla.Size = new System.Drawing.Size(2, 22);
            this.LblFechaPlanilla.TabIndex = 1;
            // 
            // FrmDetaPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 358);
            this.Controls.Add(this.LblFechaPlanilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNombrePlanilla);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.DgvDetaPlanilla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetaPlanilla";
            this.Text = "FrmDetaPlanilla";
            this.Load += new System.EventHandler(this.FrmDetaPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetaPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaPlanillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoPlanillaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetaPlanilla;
        private ProyectoPlanillaDataSet proyectoPlanillaDataSet;
        private System.Windows.Forms.BindingSource detaPlanillaBindingSource;
        private ProyectoPlanillaDataSetTableAdapters.DetaPlanillaTableAdapter detaPlanillaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSueldoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIsss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAfpEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAfpEmpleador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRenta;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombrePlanilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblFechaPlanilla;
    }
}