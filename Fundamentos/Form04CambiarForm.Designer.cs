
namespace Fundamentos
{
    partial class Form04CambiarForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posicion X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posicion Y:";
            // 
            // txtPosicionX
            // 
            this.txtPosicionX.Location = new System.Drawing.Point(125, 26);
            this.txtPosicionX.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosicionX.Name = "txtPosicionX";
            this.txtPosicionX.Size = new System.Drawing.Size(76, 20);
            this.txtPosicionX.TabIndex = 2;
            this.txtPosicionX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPosicionY
            // 
            this.txtPosicionY.Location = new System.Drawing.Point(125, 71);
            this.txtPosicionY.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosicionY.Name = "txtPosicionY";
            this.txtPosicionY.Size = new System.Drawing.Size(76, 20);
            this.txtPosicionY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Green";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Blue";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(324, 26);
            this.txtRed.Margin = new System.Windows.Forms.Padding(2);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(76, 20);
            this.txtRed.TabIndex = 7;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(324, 58);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(2);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(76, 20);
            this.txtGreen.TabIndex = 8;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(324, 92);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(2);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(76, 20);
            this.txtBlue.TabIndex = 9;
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(107, 119);
            this.btnPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(94, 54);
            this.btnPosicion.TabIndex = 10;
            this.btnPosicion.Text = "Posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(298, 119);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(101, 54);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Info:Dentro de la clase Color tenemos un metodo From...";
            // 
            // Form04CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 222);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicionY);
            this.Controls.Add(this.txtPosicionX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form04CambiarForm";
            this.Text = "Form04CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label6;
    }
}