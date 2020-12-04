
namespace Fundamentos
{
    partial class Form31Coches
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
            this.MARCA = new System.Windows.Forms.Label();
            this.MODELO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.fotoCoche = new System.Windows.Forms.PictureBox();
            this.btCargarCoche = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCoches = new System.Windows.Forms.ListBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCoche)).BeginInit();
            this.SuspendLayout();
            // 
            // MARCA
            // 
            this.MARCA.AutoSize = true;
            this.MARCA.Location = new System.Drawing.Point(37, 26);
            this.MARCA.Name = "MARCA";
            this.MARCA.Size = new System.Drawing.Size(45, 13);
            this.MARCA.TabIndex = 0;
            this.MARCA.Text = "MARCA";
            // 
            // MODELO
            // 
            this.MODELO.AutoSize = true;
            this.MODELO.Location = new System.Drawing.Point(40, 95);
            this.MODELO.Name = "MODELO";
            this.MODELO.Size = new System.Drawing.Size(53, 13);
            this.MODELO.TabIndex = 1;
            this.MODELO.Text = "MODELO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagen Coche";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(40, 43);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(40, 112);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // fotoCoche
            // 
            this.fotoCoche.Location = new System.Drawing.Point(40, 182);
            this.fotoCoche.Name = "fotoCoche";
            this.fotoCoche.Size = new System.Drawing.Size(205, 157);
            this.fotoCoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoCoche.TabIndex = 5;
            this.fotoCoche.TabStop = false;
            // 
            // btCargarCoche
            // 
            this.btCargarCoche.Location = new System.Drawing.Point(43, 345);
            this.btCargarCoche.Name = "btCargarCoche";
            this.btCargarCoche.Size = new System.Drawing.Size(205, 23);
            this.btCargarCoche.TabIndex = 6;
            this.btCargarCoche.Text = "Cargar Coche";
            this.btCargarCoche.UseVisualStyleBackColor = true;
            this.btCargarCoche.Click += new System.EventHandler(this.btCargarCoche_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coches";
            // 
            // lstCoches
            // 
            this.lstCoches.FormattingEnabled = true;
            this.lstCoches.Location = new System.Drawing.Point(279, 43);
            this.lstCoches.Name = "lstCoches";
            this.lstCoches.Size = new System.Drawing.Size(203, 342);
            this.lstCoches.TabIndex = 8;
            this.lstCoches.SelectedIndexChanged += new System.EventHandler(this.lstCoches_SelectedIndexChanged);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(516, 138);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(96, 23);
            this.btInsertar.TabIndex = 9;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(516, 190);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(96, 23);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar datos";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(516, 243);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(96, 23);
            this.btLeer.TabIndex = 11;
            this.btLeer.Text = "Leer datos";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // Form31Coches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 415);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.lstCoches);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCargarCoche);
            this.Controls.Add(this.fotoCoche);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MODELO);
            this.Controls.Add(this.MARCA);
            this.Name = "Form31Coches";
            this.Text = "Form31Coches";
            ((System.ComponentModel.ISupportInitialize)(this.fotoCoche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MARCA;
        private System.Windows.Forms.Label MODELO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.PictureBox fotoCoche;
        private System.Windows.Forms.Button btCargarCoche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCoches;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btLeer;
    }
}