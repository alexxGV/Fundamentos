
namespace Fundamentos
{
    partial class Form17MetodosEvento
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
            this.lblRaton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRaton
            // 
            this.lblRaton.BackColor = System.Drawing.Color.PeachPuff;
            this.lblRaton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRaton.Location = new System.Drawing.Point(46, 161);
            this.lblRaton.Name = "lblRaton";
            this.lblRaton.Size = new System.Drawing.Size(683, 253);
            this.lblRaton.TabIndex = 0;
            this.lblRaton.Text = "lblRaton";
            this.lblRaton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRaton.MouseHover += new System.EventHandler(this.lblRaton_MouseHover);
            this.lblRaton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblRaton_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solo Numeros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solo Letras:";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(183, 31);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(247, 22);
            this.txtNumeros.TabIndex = 3;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(183, 77);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(247, 22);
            this.txtLetras.TabIndex = 4;
            this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // Form17MetodosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRaton);
            this.Name = "Form17MetodosEvento";
            this.Text = "Form17MetodosEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TextBox txtLetras;
    }
}