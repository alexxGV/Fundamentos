namespace Fundamentos
{
    partial class Form22TemperaturasAnuales
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 18;
            this.lstMeses.Location = new System.Drawing.Point(74, 71);
            this.lstMeses.Margin = new System.Windows.Forms.Padding(4);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(300, 472);
            this.lstMeses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meses";
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(508, 71);
            this.btnMeses.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(150, 50);
            this.btnMeses.TabIndex = 2;
            this.btnMeses.Text = "Generar Meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(508, 129);
            this.btnDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(150, 50);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Mostrar Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Media";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(508, 248);
            this.txtMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(148, 24);
            this.txtMaxima.TabIndex = 7;
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(508, 295);
            this.txtMinima.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(148, 24);
            this.txtMinima.TabIndex = 8;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(508, 342);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(148, 24);
            this.txtMedia.TabIndex = 9;
            // 
            // Form22TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 587);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form22TemperaturasAnuales";
            this.Text = "Form22TemeraturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.TextBox txtMedia;
    }
}