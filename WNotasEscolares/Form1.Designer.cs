namespace WNotasEscolares
{
    partial class frmNotasEscolares
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbDatosEstudiante = new System.Windows.Forms.GroupBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.grbMovimiento = new System.Windows.Forms.GroupBox();
            this.rbtHistorialCalificaciones = new System.Windows.Forms.RadioButton();
            this.rbtCalcularPromedio = new System.Windows.Forms.RadioButton();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.grbDatosEstudiante.SuspendLayout();
            this.grbMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(163, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 45);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // grbDatosEstudiante
            // 
            this.grbDatosEstudiante.Controls.Add(this.lblCalificacion);
            this.grbDatosEstudiante.Controls.Add(this.txtMatricula);
            this.grbDatosEstudiante.Controls.Add(this.txtCalificacion);
            this.grbDatosEstudiante.Controls.Add(this.cmbNombre);
            this.grbDatosEstudiante.Controls.Add(this.lblMatricula);
            this.grbDatosEstudiante.Controls.Add(this.lblNombre);
            this.grbDatosEstudiante.Location = new System.Drawing.Point(12, 21);
            this.grbDatosEstudiante.Name = "grbDatosEstudiante";
            this.grbDatosEstudiante.Size = new System.Drawing.Size(220, 136);
            this.grbDatosEstudiante.TabIndex = 3;
            this.grbDatosEstudiante.TabStop = false;
            this.grbDatosEstudiante.Text = "Datos del estudiante";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(73, 66);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(125, 20);
            this.txtMatricula.TabIndex = 7;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(73, 36);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(125, 21);
            this.cmbNombre.TabIndex = 6;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 69);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matricula";
            // 
            // grbMovimiento
            // 
            this.grbMovimiento.Controls.Add(this.rbtHistorialCalificaciones);
            this.grbMovimiento.Controls.Add(this.rbtCalcularPromedio);
            this.grbMovimiento.Location = new System.Drawing.Point(238, 21);
            this.grbMovimiento.Name = "grbMovimiento";
            this.grbMovimiento.Size = new System.Drawing.Size(187, 136);
            this.grbMovimiento.TabIndex = 4;
            this.grbMovimiento.TabStop = false;
            this.grbMovimiento.Text = "Movimiento";
            // 
            // rbtHistorialCalificaciones
            // 
            this.rbtHistorialCalificaciones.AutoSize = true;
            this.rbtHistorialCalificaciones.Location = new System.Drawing.Point(10, 32);
            this.rbtHistorialCalificaciones.Name = "rbtHistorialCalificaciones";
            this.rbtHistorialCalificaciones.Size = new System.Drawing.Size(129, 17);
            this.rbtHistorialCalificaciones.TabIndex = 2;
            this.rbtHistorialCalificaciones.TabStop = true;
            this.rbtHistorialCalificaciones.Text = "Historial calificaciones";
            this.rbtHistorialCalificaciones.UseVisualStyleBackColor = true;
            this.rbtHistorialCalificaciones.CheckedChanged += new System.EventHandler(this.rbtHistorialCalificaciones_CheckedChanged);
            // 
            // rbtCalcularPromedio
            // 
            this.rbtCalcularPromedio.AutoSize = true;
            this.rbtCalcularPromedio.Location = new System.Drawing.Point(10, 65);
            this.rbtCalcularPromedio.Name = "rbtCalcularPromedio";
            this.rbtCalcularPromedio.Size = new System.Drawing.Size(109, 17);
            this.rbtCalcularPromedio.TabIndex = 1;
            this.rbtCalcularPromedio.TabStop = true;
            this.rbtCalcularPromedio.Text = "Calcular promedio";
            this.rbtCalcularPromedio.UseVisualStyleBackColor = true;
            this.rbtCalcularPromedio.CheckedChanged += new System.EventHandler(this.rbtCalcularPromedio_CheckedChanged);
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(73, 96);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(125, 20);
            this.txtCalificacion.TabIndex = 6;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(6, 99);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 7;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // frmNotasEscolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 223);
            this.Controls.Add(this.grbMovimiento);
            this.Controls.Add(this.grbDatosEstudiante);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmNotasEscolares";
            this.Text = "Notas escolares";
            this.Load += new System.EventHandler(this.frmNotasEscolares_Load);
            this.grbDatosEstudiante.ResumeLayout(false);
            this.grbDatosEstudiante.PerformLayout();
            this.grbMovimiento.ResumeLayout(false);
            this.grbMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbDatosEstudiante;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox grbMovimiento;
        private System.Windows.Forms.RadioButton rbtHistorialCalificaciones;
        private System.Windows.Forms.RadioButton rbtCalcularPromedio;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblCalificacion;
    }
}

