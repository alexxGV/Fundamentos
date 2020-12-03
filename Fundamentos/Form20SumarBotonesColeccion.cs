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
    public partial class Form20SumarBotonesColeccion : Form
    {
        List<Button> botones;
        int suma;
        public Form20SumarBotonesColeccion()
        {
            Random aleatorio = new Random();
            InitializeComponent();
            suma = 0;
            this.botones = new List<Button>();
            foreach (Control boton in this.pnlNumeros.Controls)
            {
                if (boton is Button)
                {
                    boton.Text = aleatorio.Next(1, 1000).ToString();
                    this.botones.Add((Button)boton);
                }
            }

            foreach (Button boton in this.botones)
            {
                
                    boton.Click += Sumar;

               
            }


        }


        private void Sumar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.YellowGreen;
            suma += int.Parse(boton.Text);

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            this.txtSuma.Text = suma.ToString();
            foreach(Button boton in this.pnlNumeros.Controls)
            {
                boton.BackColor = Color.Transparent;
            }
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            suma = 0;
            this.txtSuma.Text = suma.ToString();
            foreach(Button boton in this.pnlNumeros.Controls)
            {
                boton.BackColor = Color.Transparent;
            }
        }
    }
}
