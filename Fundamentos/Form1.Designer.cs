
namespace Fundamentos
{
    partial class Form1
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
            this.btnpulsar = new System.Windows.Forms.Button();
            this.txtcaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpulsar
            // 
            this.btnpulsar.Location = new System.Drawing.Point(12, 103);
            this.btnpulsar.Name = "btnpulsar";
            this.btnpulsar.Size = new System.Drawing.Size(170, 36);
            this.btnpulsar.TabIndex = 0;
            this.btnpulsar.Text = "Pulsar";
            this.btnpulsar.UseVisualStyleBackColor = true;
            this.btnpulsar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcaja
            // 
            this.txtcaja.Location = new System.Drawing.Point(12, 63);
            this.txtcaja.Name = "txtcaja";
            this.txtcaja.Size = new System.Drawing.Size(170, 22);
            this.txtcaja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(450, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcaja);
            this.Controls.Add(this.btnpulsar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpulsar;
        private System.Windows.Forms.TextBox txtcaja;
        private System.Windows.Forms.Label label1;
    }
}

