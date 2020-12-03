
namespace Fundamentos
{
    partial class Form09ValidarMail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.lbldatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(50, 96);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(192, 36);
            this.btnComprobar.TabIndex = 2;
            this.btnComprobar.Text = "Comprobar Mail";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.ForeColor = System.Drawing.Color.Coral;
            this.lbldatos.Location = new System.Drawing.Point(405, 53);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(57, 17);
            this.lbldatos.TabIndex = 3;
            this.lbldatos.Text = "lbldatos";
            // 
            // Form09ValidarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form09ValidarMail";
            this.Text = "Form09ValidarMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label lbldatos;
    }
}