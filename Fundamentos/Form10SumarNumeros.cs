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
    public partial class Form10SumarNumeros : Form
    {
        public Form10SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textonumeros = this.txtNumeros.Text;
            int suma = 0;
            //Hay que recorrer todos los caracteres
            for(int i = 0; i < textonumeros.Length; i++)
            {
                //Esta converion recupera el ascii, nosotros necesitamos el literal
                char caracter = textonumeros[i];
                int num = int.Parse(caracter.ToString());
                suma += num;
            }
            this.lblSuma.Text = suma.ToString();
        }
    }
}
