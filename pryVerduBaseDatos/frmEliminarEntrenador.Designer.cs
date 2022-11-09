namespace pryVerduBaseDatos
{
    partial class frmEliminarEntrenador
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
            this.EstadoConeccionEntrEliminar = new System.Windows.Forms.ToolStrip();
            this.EliminarEntrenadoresTool = new System.Windows.Forms.ToolStripLabel();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.EstadoConeccionEntrEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadoConeccionEntrEliminar
            // 
            this.EstadoConeccionEntrEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EliminarEntrenadoresTool});
            this.EstadoConeccionEntrEliminar.Location = new System.Drawing.Point(0, 0);
            this.EstadoConeccionEntrEliminar.Name = "EstadoConeccionEntrEliminar";
            this.EstadoConeccionEntrEliminar.Size = new System.Drawing.Size(238, 25);
            this.EstadoConeccionEntrEliminar.TabIndex = 47;
            this.EstadoConeccionEntrEliminar.Text = "toolStrip1";
            // 
            // EliminarEntrenadoresTool
            // 
            this.EliminarEntrenadoresTool.Name = "EliminarEntrenadoresTool";
            this.EliminarEntrenadoresTool.Size = new System.Drawing.Size(86, 22);
            this.EliminarEntrenadoresTool.Text = "toolStripLabel1";
            // 
            // cboDeporte
            // 
            this.cboDeporte.FormattingEnabled = true;
            this.cboDeporte.Items.AddRange(new object[] {
            "TENIS",
            "FUTBOL",
            "BASQUET",
            "CICLISMO"});
            this.cboDeporte.Location = new System.Drawing.Point(104, 351);
            this.cboDeporte.Name = "cboDeporte";
            this.cboDeporte.Size = new System.Drawing.Size(100, 21);
            this.cboDeporte.TabIndex = 46;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(11, 351);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(48, 13);
            this.lblDeporte.TabIndex = 45;
            this.lblDeporte.Text = "Deporte:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(129, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(104, 306);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 43;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(104, 261);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 216);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 171);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 40;
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(104, 78);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEntrenador.TabIndex = 39;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(110, 115);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(94, 36);
            this.btnMostrarDatos.TabIndex = 38;
            this.btnMostrarDatos.Text = "Mostar entrenador";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(10, 306);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 37;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(10, 261);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(10, 216);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 35;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 171);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(10, 78);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEntrenador.TabIndex = 33;
            this.lblCodigoEntrenador.Text = "Codigo:";
            // 
            // frmEliminarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 450);
            this.Controls.Add(this.EstadoConeccionEntrEliminar);
            this.Controls.Add(this.cboDeporte);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoEntrenador);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoEntrenador);
            this.Name = "frmEliminarEntrenador";
            this.Text = "Elimanar entrenador";
            this.Load += new System.EventHandler(this.frmElimanarEntrenador_Load);
            this.EstadoConeccionEntrEliminar.ResumeLayout(false);
            this.EstadoConeccionEntrEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip EstadoConeccionEntrEliminar;
        private System.Windows.Forms.ToolStripLabel EliminarEntrenadoresTool;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoEntrenador;
    }
}