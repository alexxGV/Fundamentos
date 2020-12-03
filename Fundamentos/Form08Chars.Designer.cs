namespace Fundamentos
{
    partial class Form08Chars
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(47, 54);
            this.txtLetras.Multiline = true;
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(247, 140);
            this.txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(47, 237);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(247, 140);
            this.txtNumeros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numeros";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new System.Drawing.Point(314, 54);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new System.Drawing.Size(247, 140);
            this.txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Simbolos";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(314, 237);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(247, 140);
            this.txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuacion";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(608, 170);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(199, 97);
            this.btnRecorrer.TabIndex = 8;
            this.btnRecorrer.Text = "Recorrer ASCII";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form08Chars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.label1);
            this.Name = "Form08Chars";
            this.Text = "Form08Chars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSimbolos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecorrer;
    }
}