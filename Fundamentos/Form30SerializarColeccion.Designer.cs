
namespace Fundamentos
{
    partial class Form30SerializarColeccion
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
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLeer = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(285, 46);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(120, 121);
            this.lstProductos.TabIndex = 17;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Productos";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(171, 130);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 39);
            this.btGuardar.TabIndex = 15;
            this.btGuardar.Text = "Guardar productos";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(171, 83);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(75, 41);
            this.btLeer.TabIndex = 14;
            this.btLeer.Text = "Leer productos";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(33, 93);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(41, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(171, 40);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 37);
            this.btInsertar.TabIndex = 9;
            this.btInsertar.Text = "Insertar producto";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // Form30SerializarColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 203);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInsertar);
            this.Name = "Form30SerializarColeccion";
            this.Text = "Form30SerializarColeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btLeer;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInsertar;
    }
}