using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
            int[] numeros = new int[3] { 132, 14, 32 };
            int suma = 0;
            foreach( int numero in numeros)
            {
                suma += numero;
                this.lblTiempo.Text = suma.ToString();
            }
        }


        private void btnReverseString_Click(object sender, EventArgs e)
        {
            //Queremos medir el tiempo de ejecucion del proceso
            Stopwatch krono=new Stopwatch();
            krono.Start();

            string texto = txtTexto.Text;
            for (int i = 0; i < texto.Length; i++)
            {
                //Recuperamos la letra
                char letra = texto[texto.Length - 1];
                //Se la metemos en la posicion i
                texto= texto.Insert(i, letra.ToString());
                //Quitamos la letra del final
                texto=texto.Remove(texto.Length - 1);
            

            }
            this.txtTexto.Text = texto;
            krono.Stop();
            TimeSpan intervalo = krono.Elapsed;
            this.lblTiempo.Text = "Segundos: " + intervalo.TotalSeconds 
                + "\nMilisegundos: " + intervalo.TotalMilliseconds;
        }

        private void btnReverseStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(this.txtTexto.Text);
            for(int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra);
            }
            this.txtTexto.Text = texto.ToString();
            krono.Stop();
            TimeSpan intervalo = krono.Elapsed;
            this.lblTiempo.Text = "Segundos: " + intervalo.TotalSeconds
                + "\nMilisegundos: " + intervalo.TotalMilliseconds;
        }
    }
}
