namespace WReservaVuelos
{
    partial class frmReservaVuelos
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
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblInfoAsientos = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblCiudadOrigen = new System.Windows.Forms.Label();
            this.cmbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(101, 76);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(121, 21);
            this.cmbClase.TabIndex = 0;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(36, 84);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 13);
            this.lblClase.TabIndex = 1;
            this.lblClase.Text = "Clase";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(101, 37);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(281, 117);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(142, 38);
            this.btnReservar.TabIndex = 3;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblInfoAsientos
            // 
            this.lblInfoAsientos.AutoSize = true;
            this.lblInfoAsientos.Location = new System.Drawing.Point(36, 190);
            this.lblInfoAsientos.Name = "lblInfoAsientos";
            this.lblInfoAsientos.Size = new System.Drawing.Size(71, 13);
            this.lblInfoAsientos.TabIndex = 5;
            this.lblInfoAsientos.Text = "Info Asientos:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 44);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmbCiudadDestino
            // 
            this.cmbCiudadDestino.FormattingEnabled = true;
            this.cmbCiudadDestino.Location = new System.Drawing.Point(340, 76);
            this.cmbCiudadDestino.Name = "cmbCiudadDestino";
            this.cmbCiudadDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadDestino.TabIndex = 6;
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(244, 84);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(77, 13);
            this.lblCiudadDestino.TabIndex = 7;
            this.lblCiudadDestino.Text = "Ciudad destino";
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(244, 45);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(72, 13);
            this.lblCiudadOrigen.TabIndex = 9;
            this.lblCiudadOrigen.Text = "Ciudad origen";
            // 
            // cmbCiudadOrigen
            // 
            this.cmbCiudadOrigen.FormattingEnabled = true;
            this.cmbCiudadOrigen.Location = new System.Drawing.Point(340, 37);
            this.cmbCiudadOrigen.Name = "cmbCiudadOrigen";
            this.cmbCiudadOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadOrigen.TabIndex = 8;
            // 
            // cmbFecha
            // 
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Location = new System.Drawing.Point(101, 117);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(121, 21);
            this.cmbFecha.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 120);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // frmReservaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 265);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbFecha);
            this.Controls.Add(this.lblCiudadOrigen);
            this.Controls.Add(this.cmbCiudadOrigen);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.cmbCiudadDestino);
            this.Controls.Add(this.lblInfoAsientos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.cmbClase);
            this.Name = "frmReservaVuelos";
            this.Text = "Reserva de vuelo";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblInfoAsientos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbCiudadDestino;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblCiudadOrigen;
        private System.Windows.Forms.ComboBox cmbCiudadOrigen;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}

