
namespace Fundamentos
{
    partial class Form11ISBN
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
            this.btnComprobar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(77, 98);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(95, 72);
            this.btnComprobar.TabIndex = 0;
            this.btnComprobar.Text = "Comprobar ISBN";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero ISBN: ";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(178, 101);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(59, 17);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "lblDatos";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(181, 44);
            this.txtIsbn.MaxLength = 10;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(287, 22);
            this.txtIsbn.TabIndex = 3;
            // 
            // Form11ISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 298);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprobar);
            this.Name = "Form11ISBN";
            this.Text = "Form11ISBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtIsbn;
    }
}