namespace Fundamentos
{
    partial class Form07DateTime
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
            this.chkCambiarFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbAnios = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnMostrarFecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtFechaACtual = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // chkCambiarFormato
            // 
            this.chkCambiarFormato.AutoSize = true;
            this.chkCambiarFormato.Location = new System.Drawing.Point(37, 77);
            this.chkCambiarFormato.Name = "chkCambiarFormato";
            this.chkCambiarFormato.Size = new System.Drawing.Size(105, 17);
            this.chkCambiarFormato.TabIndex = 1;
            this.chkCambiarFormato.Text = "Cambiar Formato";
            this.chkCambiarFormato.UseVisualStyleBackColor = true;
            this.chkCambiarFormato.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnMostrarFecha);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbAnios);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Location = new System.Drawing.Point(37, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(6, 19);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(46, 17);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(6, 42);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(56, 17);
            this.rdbMeses.TabIndex = 3;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnios
            // 
            this.rdbAnios.AutoSize = true;
            this.rdbAnios.Location = new System.Drawing.Point(6, 66);
            this.rdbAnios.Name = "rdbAnios";
            this.rdbAnios.Size = new System.Drawing.Size(49, 17);
            this.rdbAnios.TabIndex = 4;
            this.rdbAnios.TabStop = true;
            this.rdbAnios.Text = "Años";
            this.rdbAnios.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Incremento:";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(125, 42);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 20);
            this.txtIncremento.TabIndex = 6;
            // 
            // btnMostrarFecha
            // 
            this.btnMostrarFecha.Location = new System.Drawing.Point(125, 69);
            this.btnMostrarFecha.Name = "btnMostrarFecha";
            this.btnMostrarFecha.Size = new System.Drawing.Size(128, 23);
            this.btnMostrarFecha.TabIndex = 7;
            this.btnMostrarFecha.Text = "Mostrar Fecha";
            this.btnMostrarFecha.UseVisualStyleBackColor = true;
            this.btnMostrarFecha.Click += new System.EventHandler(this.btnMostrarFecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(43, 224);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(360, 20);
            this.txtNuevaFecha.TabIndex = 4;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.ForeColor = System.Drawing.Color.Red;
            this.lblDatos.Location = new System.Drawing.Point(43, 268);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(45, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "lblDatos";
            // 
            // txtFechaACtual
            // 
            this.txtFechaACtual.Location = new System.Drawing.Point(37, 47);
            this.txtFechaACtual.Name = "txtFechaACtual";
            this.txtFechaACtual.Size = new System.Drawing.Size(557, 20);
            this.txtFechaACtual.TabIndex = 6;
            this.txtFechaACtual.TextChanged += new System.EventHandler(this.txtFechaACtual_TextChanged);
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 326);
            this.Controls.Add(this.txtFechaACtual);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCambiarFormato);
            this.Controls.Add(this.label1);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.Load += new System.EventHandler(this.Form07DateTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCambiarFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarFecha;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAnios;
        private System.Windows.Forms.RadioButton rdbMeses;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtFechaACtual;
    }
}