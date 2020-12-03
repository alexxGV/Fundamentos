namespace Fundamentos
{
    partial class Form25PruebaClases
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnCrearPersona = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(16, 60);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(541, 340);
            this.lstDatos.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            this.btnCrearPersona.Location = new System.Drawing.Point(585, 60);
            this.btnCrearPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(196, 50);
            this.btnCrearPersona.TabIndex = 2;
            this.btnCrearPersona.Text = "Crear Persona";
            this.btnCrearPersona.UseVisualStyleBackColor = true;
            this.btnCrearPersona.Click += new System.EventHandler(this.btnCrearPersona_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(585, 142);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(196, 50);
            this.btnEmpleado.TabIndex = 3;
            this.btnEmpleado.Text = "Crear Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // Form25PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 416);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnCrearPersona);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form25PruebaClases";
            this.Text = "Form25PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnCrearPersona;
        private System.Windows.Forms.Button btnEmpleado;
    }
}