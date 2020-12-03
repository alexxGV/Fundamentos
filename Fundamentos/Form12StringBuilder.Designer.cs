
namespace Fundamentos
{
    partial class Form12StringBuilder
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
            this.btnReverseString = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnReverseStringBuilder = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            // 
            // btnReverseString
            // 
            this.btnReverseString.Location = new System.Drawing.Point(556, 74);
            this.btnReverseString.Name = "btnReverseString";
            this.btnReverseString.Size = new System.Drawing.Size(140, 87);
            this.btnReverseString.TabIndex = 2;
            this.btnReverseString.Text = "Reverse String";
            this.btnReverseString.UseVisualStyleBackColor = true;
            this.btnReverseString.Click += new System.EventHandler(this.btnReverseString_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.ForeColor = System.Drawing.Color.Red;
            this.lblTiempo.Location = new System.Drawing.Point(93, 317);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(69, 17);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "lblTiempo";
            // 
            // btnReverseStringBuilder
            // 
            this.btnReverseStringBuilder.Location = new System.Drawing.Point(556, 243);
            this.btnReverseStringBuilder.Name = "btnReverseStringBuilder";
            this.btnReverseStringBuilder.Size = new System.Drawing.Size(140, 91);
            this.btnReverseStringBuilder.TabIndex = 4;
            this.btnReverseStringBuilder.Text = "Reverse String Builder";
            this.btnReverseStringBuilder.UseVisualStyleBackColor = true;
            this.btnReverseStringBuilder.Click += new System.EventHandler(this.btnReverseStringBuilder_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(96, 98);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(377, 180);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.Text = "";
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnReverseStringBuilder);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnReverseString);
            this.Controls.Add(this.label1);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReverseString;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnReverseStringBuilder;
        private System.Windows.Forms.RichTextBox txtTexto;
    }
}