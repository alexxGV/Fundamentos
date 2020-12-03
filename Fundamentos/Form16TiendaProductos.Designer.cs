namespace Fundamentos
{
    partial class Form16TiendaProductos
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTienda = new System.Windows.Forms.ListBox();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnMoverSeleccionados = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAlmacen = new System.Windows.Forms.ListBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(51, 134);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(191, 53);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(51, 202);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(191, 53);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(52, 276);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(191, 53);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(51, 347);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(191, 53);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(51, 75);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(189, 30);
            this.txtProducto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tienda";
            // 
            // lstTienda
            // 
            this.lstTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTienda.FormattingEnabled = true;
            this.lstTienda.ItemHeight = 25;
            this.lstTienda.Location = new System.Drawing.Point(276, 75);
            this.lstTienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTienda.Name = "lstTienda";
            this.lstTienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTienda.Size = new System.Drawing.Size(197, 304);
            this.lstTienda.TabIndex = 7;
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverTodos.Location = new System.Drawing.Point(528, 175);
            this.btnMoverTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(117, 43);
            this.btnMoverTodos.TabIndex = 8;
            this.btnMoverTodos.Text = "Todos =>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // btnMoverSeleccionados
            // 
            this.btnMoverSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverSeleccionados.Location = new System.Drawing.Point(501, 239);
            this.btnMoverSeleccionados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoverSeleccionados.Name = "btnMoverSeleccionados";
            this.btnMoverSeleccionados.Size = new System.Drawing.Size(169, 71);
            this.btnMoverSeleccionados.TabIndex = 9;
            this.btnMoverSeleccionados.Text = "Seleccionados =>";
            this.btnMoverSeleccionados.UseVisualStyleBackColor = true;
            this.btnMoverSeleccionados.Click += new System.EventHandler(this.btnMoverSeleccionados_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Almacen";
            // 
            // lstAlmacen
            // 
            this.lstAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlmacen.FormattingEnabled = true;
            this.lstAlmacen.ItemHeight = 25;
            this.lstAlmacen.Location = new System.Drawing.Point(695, 75);
            this.lstAlmacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAlmacen.Name = "lstAlmacen";
            this.lstAlmacen.Size = new System.Drawing.Size(197, 304);
            this.lstAlmacen.TabIndex = 11;
            // 
            // btnSubir
            // 
            this.btnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.Location = new System.Drawing.Point(901, 175);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(136, 68);
            this.btnSubir.TabIndex = 12;
            this.btnSubir.Text = "Subir Elemento";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajar.Location = new System.Drawing.Point(901, 239);
            this.btnBajar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(136, 71);
            this.btnBajar.TabIndex = 13;
            this.btnBajar.Text = "Bajar Elemento";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // Form16TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 475);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lstAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMoverSeleccionados);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.lstTienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form16TiendaProductos";
            this.Text = "Form16TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTienda;
        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnMoverSeleccionados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAlmacen;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
    }
}