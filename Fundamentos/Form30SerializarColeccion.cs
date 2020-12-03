using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form30SerializarColeccion : Form
    {
        XmlSerializer serial;
        Productos productos;

        public Form30SerializarColeccion()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Productos));
            this.productos = new Productos();
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtNombre.Text;
            producto.Precio = int.Parse(this.txtPrecio.Text);
            this.productos.Add(producto);
            this.PintarProductos();
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
            this.txtNombre.Focus();
        }
        
        private void PintarProductos()
        {
            this.lstProductos.Items.Clear();
            foreach(Producto prod in this.productos)
            {
                this.lstProductos.Items.Add(prod.Nombre);
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstProductos.SelectedIndex != -1)
            {
                int indice = this.lstProductos.SelectedIndex;
                Producto producto = this.productos[indice];
                this.txtNombre.Text = producto.Nombre;
                this.txtPrecio.Text = producto.Precio.ToString();
            }
        }

        private async void btGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaproductos.xml");
            this.serial.Serialize(writer, this.productos);
            await writer.FlushAsync();
            writer.Close();
            this.productos.Clear();
            this.lstProductos.Items.Clear();


        }

        private void btLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            this.productos = (Productos) this.serial.Deserialize(reader);
            reader.Close();
            this.PintarProductos();
        }
    }
}
