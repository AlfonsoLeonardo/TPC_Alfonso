﻿namespace AgregarIngrediente
{
    partial class FormIngredientes
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
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textNombreIngrediente = new System.Windows.Forms.TextBox();
            this.textCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.textPrecioIngrediente = new System.Windows.Forms.TextBox();
            this.AceptarAgregaIngrediente = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(33, 75);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(47, 13);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Location = new System.Drawing.Point(33, 102);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(52, 13);
            this.labelcantidad.TabIndex = 1;
            this.labelcantidad.Text = "Cantidad:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(33, 129);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio:";
            // 
            // textNombreIngrediente
            // 
            this.textNombreIngrediente.Location = new System.Drawing.Point(114, 76);
            this.textNombreIngrediente.Name = "textNombreIngrediente";
            this.textNombreIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textNombreIngrediente.TabIndex = 4;
            // 
            // textCantidadIngrediente
            // 
            this.textCantidadIngrediente.Location = new System.Drawing.Point(114, 101);
            this.textCantidadIngrediente.Name = "textCantidadIngrediente";
            this.textCantidadIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textCantidadIngrediente.TabIndex = 5;
            // 
            // textPrecioIngrediente
            // 
            this.textPrecioIngrediente.Location = new System.Drawing.Point(114, 126);
            this.textPrecioIngrediente.Name = "textPrecioIngrediente";
            this.textPrecioIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textPrecioIngrediente.TabIndex = 6;
            // 
            // AceptarAgregaIngrediente
            // 
            this.AceptarAgregaIngrediente.Location = new System.Drawing.Point(114, 216);
            this.AceptarAgregaIngrediente.Name = "AceptarAgregaIngrediente";
            this.AceptarAgregaIngrediente.Size = new System.Drawing.Size(75, 23);
            this.AceptarAgregaIngrediente.TabIndex = 7;
            this.AceptarAgregaIngrediente.Text = "Aceptar";
            this.AceptarAgregaIngrediente.UseVisualStyleBackColor = true;
            this.AceptarAgregaIngrediente.Click += new System.EventHandler(this.AceptarAgregaIngrediente_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(313, 43);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(385, 277);
            this.dgvIngredientes.TabIndex = 8;
            this.dgvIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.AceptarAgregaIngrediente);
            this.Controls.Add(this.textPrecioIngrediente);
            this.Controls.Add(this.textCantidadIngrediente);
            this.Controls.Add(this.textNombreIngrediente);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.labelnombre);
            this.Name = "FormIngredientes";
            this.Text = "Ingredientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelcantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textNombreIngrediente;
        private System.Windows.Forms.TextBox textCantidadIngrediente;
        private System.Windows.Forms.TextBox textPrecioIngrediente;
        private System.Windows.Forms.Button AceptarAgregaIngrediente;
        private System.Windows.Forms.DataGridView dgvIngredientes;
    }
}

