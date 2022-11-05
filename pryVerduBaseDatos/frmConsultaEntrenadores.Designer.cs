namespace pryVerduBaseDatos
{
    partial class frmConsultaEntrenadores
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
            this.EstadoConeccionEntrCons = new System.Windows.Forms.ToolStrip();
            this.ConsultaEntrenadoresTool = new System.Windows.Forms.ToolStripLabel();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.CodigoDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EstadoConeccionEntrCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoConeccionEntrCons
            // 
            this.EstadoConeccionEntrCons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaEntrenadoresTool});
            this.EstadoConeccionEntrCons.Location = new System.Drawing.Point(0, 0);
            this.EstadoConeccionEntrCons.Name = "EstadoConeccionEntrCons";
            this.EstadoConeccionEntrCons.Size = new System.Drawing.Size(691, 25);
            this.EstadoConeccionEntrCons.TabIndex = 4;
            this.EstadoConeccionEntrCons.Text = "toolStrip1";
            // 
            // ConsultaEntrenadoresTool
            // 
            this.ConsultaEntrenadoresTool.Name = "ConsultaEntrenadoresTool";
            this.ConsultaEntrenadoresTool.Size = new System.Drawing.Size(86, 22);
            this.ConsultaEntrenadoresTool.Text = "toolStripLabel1";
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDep,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Provincia,
            this.Deporte});
            this.dgvEntrenadores.Location = new System.Drawing.Point(12, 37);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.Size = new System.Drawing.Size(643, 201);
            this.dgvEntrenadores.TabIndex = 3;
            // 
            // CodigoDep
            // 
            this.CodigoDep.HeaderText = "Codigo entrenador";
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
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(552, 244);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(103, 32);
            this.btnMostar.TabIndex = 5;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(691, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmConsultaEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 284);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.EstadoConeccionEntrCons);
            this.Controls.Add(this.dgvEntrenadores);
            this.Name = "frmConsultaEntrenadores";
            this.Text = "Consulta entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenadores_Load);
            this.EstadoConeccionEntrCons.ResumeLayout(false);
            this.EstadoConeccionEntrCons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip EstadoConeccionEntrCons;
        private System.Windows.Forms.ToolStripLabel ConsultaEntrenadoresTool;
        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}