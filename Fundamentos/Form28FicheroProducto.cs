using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form28FicheroProducto : Form
    {
        List<Producto> productos;
        int posicion;
        public Form28FicheroProducto()
        {
            InitializeComponent();
            productos = new List<Producto>();
            posicion = 0;
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;
            int precio = int.Parse(this.txtPrecio.Text);

            Producto producto = new Producto(nombre, precio);
            this.lstProductos.Items.Add(producto.Nombre + " : " + producto.Precio + "€");

            this.GetProductos();
        }

        async private void btGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            DialogResult respuesta = save.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = save.FileName;

                FileInfo file = new FileInfo(path);

                using(TextWriter writer = file.CreateText())
                {
                    await writer.WriteAsync(this.GetProductos());
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstProductos.Items.Clear();
            }
        }

        async private void btLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    String contenido = await reader.ReadToEndAsync();
                    reader.Close();

                    this.productos = this.FomatearProductos(contenido);
                }
            }
            foreach(Producto pr in this.productos)
            {
                this.lstProductos.Items.Add(pr.Nombre + " : " + pr.Precio + "€");
            }
            this.PintarProducto();
            this.ComprobarPosicion();
        }

        public String GetProductos()
        {
            String dato = "";
            String productos = "";
            foreach(String pro in this.lstProductos.Items)
            {
                char[] charsToTrim = { '€', ' ' };
                
                dato = pro.Trim(charsToTrim);
                dato = dato.Replace(" ", "");

                productos += dato + ";";
                //String[] salida = dato.Split(':');
            }
            productos = productos.Trim(';');
            return productos;
        }

        public List<Producto> FomatearProductos(String p)
        {
            
            List<Producto> productos = new List<Producto>();
            String[] productos_plano = p.Split(';');
            foreach (String pro in productos_plano)
            {
                Producto producto = new Producto();

                String[] produc_plano = pro.Split(':');

                producto.Nombre = produc_plano[0];
                producto.Precio = int.Parse(produc_plano[1]);
                productos.Add(producto);

            }

            return productos;
        }

        private void btPrimero_Click(object sender, EventArgs e)
        {
            this.posicion = 0;

            this.PintarProducto();
            this.ComprobarPosicion();
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            this.posicion= this.productos.Count()-1;

            this.PintarProducto();
            this.ComprobarPosicion();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            this.posicion--;
            if (this.posicion >= 0)
            {
                this.PintarProducto();
            }
            else
            {
                this.posicion++;
            }
            this.ComprobarPosicion();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            
            this.posicion++;
            if (this.posicion <= (this.productos.Count()-1)) {
                this.PintarProducto();
            }else
            {
                this.posicion--;
            }
            this.ComprobarPosicion();
        }

        private void PintarProducto()
        {
            this.txtNombre.Text = this.productos[this.posicion].Nombre;
            this.txtPrecio.Text = this.productos[this.posicion].Precio.ToString();
            this.lblProducto.Text = "Producto " + this.posicion+ " de " + (this.productos.Count() - 1).ToString();
        }

        public void ComprobarPosicion()
        {
            if (this.posicion >= this.productos.Count()-1)
            {
                this.btSiguiente.Enabled = false;
                this.btAnterior.Enabled = true;
            }
            else if (this.posicion <= 0)
            {
                this.btAnterior.Enabled = false;
                this.btSiguiente.Enabled = true;
            }else
            {
                this.btAnterior.Enabled = true;
                this.btSiguiente.Enabled = true;
            }
        }
    }
}
