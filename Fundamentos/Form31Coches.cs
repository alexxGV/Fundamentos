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
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form31Coches : Form
    {
        Coches Coches;
        XmlSerializer serial;

        public Form31Coches()
        {
            InitializeComponent();
            this.Coches = new Coches();
            this.serial = new XmlSerializer(typeof(Coches));
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            String marca = this.txtMarca.Text;
            String modelo = this.txtModelo.Text;
            byte[] fotoByte = this.ImageToByteArray(this.fotoCoche.Image);
            Coche coche = new Coche(marca, modelo, fotoByte);
            this.Coches.Add(coche);
            this.PintarLista();


            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
            this.fotoCoche.Image = null;

        }


        private async void btGuardar_Click(object sender, EventArgs e)
        {
            //CREAR FICHERO SIN SELECCIONAR
            //StreamWriter writer = new StreamWriter("coches.xml");
            //this.serial.Serialize(writer, this.Coches);
            //await writer.FlushAsync();
            //writer.Close();
            //this.Coches.Clear();
            //this.lstCoches.Items.Clear();

            //CREAR FICHERO PROPIO
            SaveFileDialog save = new SaveFileDialog();
            DialogResult respuesta = save.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = save.FileName;

                FileInfo file = new FileInfo(path);

                using (StreamWriter writer = file.CreateText())
                {
                    this.serial.Serialize(writer, this.Coches);
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.Coches.Clear();
                this.lstCoches.Items.Clear();
            }
        }

        private async void btLeer_Click(object sender, EventArgs e)
        {
            //LEER COCHES AUTOMATICAMENTE
            //StreamReader reader = new StreamReader("coches.xml");
            //this.Coches = (Coches)this.serial.Deserialize(reader);
            //reader.Close();
            //this.PintarLista();

            //LEER FICHERO PROPIO
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (StreamReader reader = file.OpenText())
                {
                    this.Coches = (Coches)this.serial.Deserialize(reader);
                    reader.Close();
                }
            }
            this.PintarLista();
        }

        private void btCargarCoche_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            try
            {
                if (respuesta == DialogResult.OK)
                {
                    string imagen = open.FileName;
                    fotoCoche.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void PintarLista()
        {
            this.lstCoches.Items.Clear();
            foreach (Coche c in this.Coches)
            {
                this.lstCoches.Items.Add(c.Marca + " " + c.Modelo);
                using (var ms = new MemoryStream(c.Imagen))
                {
                    this.txtMarca.Text = c.Marca;
                    this.txtModelo.Text = c.Modelo;
                    this.fotoCoche.Image = Image.FromStream(ms);
                }
            }
        }
        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lstCoches.SelectedIndex;
            this.txtMarca.Text = Coches[indice].Marca;
            this.txtModelo.Text = Coches[indice].Modelo;
            using (var ms = new MemoryStream(this.Coches[indice].Imagen))
            {
                this.fotoCoche.Image = Image.FromStream(ms);
            }
        }
    }
}
