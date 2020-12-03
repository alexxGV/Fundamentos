
namespace Fundamentos
{
    partial class Form26TemperaturasMesesClases
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 20;
            this.lstMeses.Location = new System.Drawing.Point(22, 81);
            this.lstMeses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(283, 384);
            this.lstMeses.TabIndex = 0;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona un mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minima";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(318, 280);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(124, 27);
            this.txtMin.TabIndex = 5;
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(316, 206);
            this.txtAvg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(124, 27);
            this.txtAvg.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(318, 129);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(124, 27);
            this.txtMax.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(318, 366);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(131, 61);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form26TemperaturasMesesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 569);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form26TemperaturasMesesClases";
            this.Text = "Form26TemperaturasMesesClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnGenerar;
    }
}