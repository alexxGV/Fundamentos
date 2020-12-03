using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form16TiendaProductos : Form
    {
        public Form16TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            int elementos = this.lstTienda.Items.Count;
            if (this.lstTienda.Items.Count == 0)
            {
                this.lstTienda.Items.Add(producto);
            }
            else
            {
                //for (int i = 0; i < elementos; i++)
                //{
                if (!this.lstTienda.Items.Contains(producto))
                {
                    this.lstTienda.Items.Add(producto);
                }
                else
                {
                    this.lstTienda.SetSelected(this.lstTienda.Items.IndexOf(producto), true);
                }
                //}
            }
            this.txtProducto.Text = "";
            this.txtProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (this.lstTienda.Items.Count != 0)
            {

                int elementos = this.lstTienda.SelectedIndices.Count - 1;
                for (int i = elementos; i >= 0; i--)
                {
                    this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
                }
            }
            this.txtProducto.Text = "";
            this.txtProducto.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
            this.txtProducto.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            this.lstTienda.Items[this.lstTienda.SelectedIndex] = producto;
            this.txtProducto.Text = "";
            this.txtProducto.Focus();
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
        foreach(object item in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(item);

            }
            this.lstTienda.Items.Clear();
        }

        private void btnMoverSeleccionados_Click(object sender, EventArgs e)
        {
            int seleccionados = this.lstTienda.SelectedItems.Count-1;
            for (int i = seleccionados; i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.SelectedItems[i]);
                this.lstTienda.Items.Remove(this.lstTienda.SelectedItems[i]);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            object subir = this.lstAlmacen.SelectedItem;
            int posicion = this.lstAlmacen.SelectedIndex-1;
            this.lstAlmacen.Items.Insert(this.lstAlmacen.SelectedIndex - 1,subir);
            
            this.lstAlmacen.Items.RemoveAt(this.lstAlmacen.SelectedIndex);
            this.lstAlmacen.SetSelected(posicion,true);
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            object bajar = this.lstAlmacen.SelectedItem;
            int posicion = this.lstAlmacen.SelectedIndex+1;
            this.lstAlmacen.Items.Insert(this.lstAlmacen.SelectedIndex, bajar);
            this.lstAlmacen.Items.RemoveAt(this.lstAlmacen.SelectedIndex);
            this.lstAlmacen.SetSelected(posicion, true);
        }
    }
}
