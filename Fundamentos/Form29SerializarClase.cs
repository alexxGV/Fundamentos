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
    public partial class Form29SerializarClase : Form
    {
        XmlSerializer serial;
        public Form29SerializarClase()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Producto));
            
        }

        private async void btGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtNombre.Text;
            producto.Precio = int.Parse(this.txtPrecio.Text);

            StreamWriter writer = new StreamWriter("producto.xml");
            this.serial.Serialize(writer, producto);
            await writer.FlushAsync();
            writer.Close();
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
            this.lblInfo.Text = "Datos guardados";
        }

        private void btLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("producto.xml");
            Producto producto = (Producto)this.serial.Deserialize(reader);
            reader.Close();
            this.txtNombre.Text = producto.Nombre;
            this.txtPrecio.Text = producto.Precio.ToString();
            this.lblInfo.Text = "Producto leido";
        }
    }
}
