namespace Fundamentos
{
    partial class Form28FicheroProducto
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
            this.btInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLeer = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btPrimero = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btUltimo = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(175, 50);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 37);
            this.btInsertar.TabIndex = 0;
            this.btInsertar.Text = "Insertar producto";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(37, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(41, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(175, 93);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(75, 41);
            this.btLeer.TabIndex = 5;
            this.btLeer.Text = "Leer productos";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(175, 140);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 39);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar productos";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Productos";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(289, 56);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(120, 121);
            this.lstProductos.TabIndex = 8;
            // 
            // btPrimero
            // 
            this.btPrimero.Location = new System.Drawing.Point(26, 196);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(75, 23);
            this.btPrimero.TabIndex = 9;
            this.btPrimero.Text = "Primero";
            this.btPrimero.UseVisualStyleBackColor = true;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(126, 196);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(75, 23);
            this.btAnterior.TabIndex = 10;
            this.btAnterior.Text = "Anterior";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(236, 196);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btSiguiente.TabIndex = 11;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btUltimo
            // 
            this.btUltimo.Location = new System.Drawing.Point(349, 196);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(75, 23);
            this.btUltimo.TabIndex = 12;
            this.btUltimo.Text = "Ultimo";
            this.btUltimo.UseVisualStyleBackColor = true;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.ForeColor = System.Drawing.Color.Red;
            this.lblProducto.Location = new System.Drawing.Point(37, 235);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(83, 13);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Text = "Producto 1 de 5";
            // 
            // Form28FicheroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 267);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btUltimo);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.btPrimero);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInsertar);
            this.Name = "Form28FicheroProducto";
            this.Text = "Form28FicheroProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLeer;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Label lblProducto;
    }
}