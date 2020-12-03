namespace Fundamentos
{
    partial class Form16MetodoReferencia
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnLlamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(45, 148);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "lblResultado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(112, 49);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(85, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnLlamada
            // 
            this.btnLlamada.Location = new System.Drawing.Point(48, 100);
            this.btnLlamada.Name = "btnLlamada";
            this.btnLlamada.Size = new System.Drawing.Size(149, 23);
            this.btnLlamada.TabIndex = 3;
            this.btnLlamada.Text = "Llamada";
            this.btnLlamada.UseVisualStyleBackColor = true;
            this.btnLlamada.Click += new System.EventHandler(this.btnLlamada_Click);
            // 
            // Form16MetodoReferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamada);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Name = "Form16MetodoReferencia";
            this.Text = "Form16MetodoReferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnLlamada;
    }
}