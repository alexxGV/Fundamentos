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

namespace Fundamentos
{
    public partial class Form27FicherosPlanos : Form
    {
        public Form27FicherosPlanos()
        {
            InitializeComponent();
        }

        async private void btGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //ShowDialog() --> DialogResult 
            DialogResult respuesta = save.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = save.FileName;
                
                //MANEJAR CUALQUIER FICHERO
                FileInfo file = new FileInfo(path);
                //PODEMOS CREAR OBJETOS PARA LEER BYTES O PLANOS
                
                //UTILIZAREMOS USING PARA CREAR EL OBJETO, UTILIZARLO Y DESTRUIRLO
                using(TextWriter writer = file.CreateText())
                {
                    //ESCRIBIR
                    //writer.Write(this.txtTexto.Text);
                    //await writer.WriteAsync(this.txtTexto.Text);
                    await writer.WriteAsync(this.GetStringNombres());
                    //AL ESCRIBIR DEBEMOS LIBERAR FLUJO DE MEMORIA Y CERRAR EL FICHERO
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstNombres.Items.Clear();
                this.txtTexto.Text = "";
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
                    this.txtTexto.Text = contenido;
                    this.SetStringNombres(contenido);
                }
            }
        }
        public String GetStringNombres()
        {
            String datos = "";
            foreach(String nombre in this.lstNombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtNombre.Text = "";
            this.txtNombre.Focus();
        }

        public void SetStringNombres(String data)
        {
            String[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach(String nombre in nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }
    }
}
