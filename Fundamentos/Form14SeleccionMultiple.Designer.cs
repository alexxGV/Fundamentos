
namespace Fundamentos
{
    partial class Form14SeleccionMultiple
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(468, 138);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(232, 29);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSeleccionados.ForeColor = System.Drawing.Color.Magenta;
            this.btnSeleccionados.Location = new System.Drawing.Point(468, 197);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(232, 29);
            this.btnSeleccionados.TabIndex = 1;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = false;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Location = new System.Drawing.Point(468, 249);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(232, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item:";
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.ForeColor = System.Drawing.Color.Blue;
            this.lblIndices.Location = new System.Drawing.Point(46, 448);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(75, 20);
            this.lblIndices.TabIndex = 4;
            this.lblIndices.Text = "lblIndices";
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.ForeColor = System.Drawing.Color.Magenta;
            this.lblSeleccionados.Location = new System.Drawing.Point(46, 482);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(128, 20);
            this.lblSeleccionados.TabIndex = 5;
            this.lblSeleccionados.Text = "lblSeleccionados";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 20;
            this.lstElementos.Location = new System.Drawing.Point(42, 122);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstElementos.Size = new System.Drawing.Size(282, 304);
            this.lstElementos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elementos";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(468, 86);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(232, 26);
            this.txtElemento.TabIndex = 8;
            // 
            // Form14SeleccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.btnInsertar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form14SeleccionMultiple";
            this.Text = "Form14SeleccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnSeleccionados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.Label lblSeleccionados;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento;
    }
}