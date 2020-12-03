namespace Fundamentos
{
    partial class Form27FicherosPlanos
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLeer = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(31, 58);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(233, 245);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduca un texto";
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(298, 60);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(75, 23);
            this.btLeer.TabIndex = 2;
            this.btLeer.Text = "Leer Fichero";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(298, 99);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 54);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar Fichero";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(406, 60);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 4;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(512, 99);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(120, 95);
            this.lstNombres.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(512, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // Form27FicherosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 329);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form27FicherosPlanos";
            this.Text = "Form27FicherosPlanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLeer;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.TextBox txtNombre;
    }
}