
namespace Fundamentos
{
    partial class Form10SumarNumeros
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(126, 46);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(234, 22);
            this.txtNumeros.TabIndex = 3;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(126, 103);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(146, 72);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Sumar Numeros";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(405, 50);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(58, 17);
            this.lblSuma.TabIndex = 7;
            this.lblSuma.Text = "lblSuma";
            // 
            // Form10SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form10SumarNumeros";
            this.Text = "Form10SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuma;
    }
}