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
    public partial class Form08Chars : Form
    {
        public Form08Chars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                //Queremos convertir cada int a char
                char caracter = (char)i;
                //Evaluamos 
                if (char.IsLetter(caracter))
                {
                    this.txtLetras.Text += caracter;
                }else if (char.IsNumber(caracter))
                {
                    this.txtNumeros.Text += caracter;
                }else if (char.IsSymbol(caracter))
                {
                    this.txtSimbolos.Text += caracter;
                }
                else if(char.IsPunctuation(caracter))
                {
                    this.txtPuntuacion.Text += caracter;
                }

            }
        }
    }
}
