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
    public partial class Form15ColeccionNumeroListBox : Form
    {
        public Form15ColeccionNumeroListBox()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random aleatorio = new Random();
            for (int i = 0; i <= 10; i++)
            {
                
                this.lstNumeros.Items.Add(aleatorio.Next(1, 100));
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int pares = 0;
            int impares = 0;
            int suma = 0;
            foreach(object objeto in this.lstNumeros.Items)
            {
                int numero = (int)objeto;
                suma += numero;
                if (numero % 2 == 0)
                {
                    pares += numero;
                }
                else
                {
                    impares += numero;
                }

            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();


        }
    }
}
