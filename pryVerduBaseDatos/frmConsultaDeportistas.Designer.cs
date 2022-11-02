namespace pryVerduBaseDatos
{
    partial class frmConsultaDeportistas
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
            this.dgvDeportistas = new System.Windows.Forms.DataGridView();
            this.CodigoDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostar = new System.Windows.Forms.Button();
            this.EstadoConeccionDepCons = new System.Windows.Forms.ToolStrip();
            this.ConsultaDepTool = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).BeginInit();
            this.EstadoConeccionDepCons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeportistas
            // 
            this.dgvDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDep,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Edad,
            this.Deporte});
            this.dgvDeportistas.Location = new System.Drawing.Point(8, 28);
            this.dgvDeportistas.Name = "dgvDeportistas";
            this.dgvDeportistas.Size = new System.Drawing.Size(743, 249);
            this.dgvDeportistas.TabIndex = 0;
            // 
            // CodigoDep
            // 
            this.CodigoDep.HeaderText = "Codigo deportista";
            this.CodigoDep.Name = "CodigoDep";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(648, 277);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(103, 32);
            this.btnMostar.TabIndex = 1;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // EstadoConeccionDepCons
            // 
            this.EstadoConeccionDepCons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaDepTool});
            this.EstadoConeccionDepCons.Location = new System.Drawing.Point(0, 0);
            this.EstadoConeccionDepCons.Name = "EstadoConeccionDepCons";
            this.EstadoConeccionDepCons.Size = new System.Drawing.Size(760, 25);
            this.EstadoConeccionDepCons.TabIndex = 2;
            this.EstadoConeccionDepCons.Text = "toolStrip1";
            // 
            // ConsultaDepTool
            // 
            this.ConsultaDepTool.Name = "ConsultaDepTool";
            this.ConsultaDepTool.Size = new System.Drawing.Size(86, 22);
            this.ConsultaDepTool.Text = "toolStripLabel1";
            // 
            // frmConsultaDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 320);
            this.Controls.Add(this.EstadoConeccionDepCons);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.dgvDeportistas);
            this.Name = "frmConsultaDeportistas";
            this.Text = "Consulta deportistas";
            this.Load += new System.EventHandler(this.frmConsultaDeportistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).EndInit();
            this.EstadoConeccionDepCons.ResumeLayout(false);
            this.EstadoConeccionDepCons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.ToolStrip EstadoConeccionDepCons;
        private System.Windows.Forms.ToolStripLabel ConsultaDepTool;
    }
}