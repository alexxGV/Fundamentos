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
    public partial class Form05MayorTresNumeros : Form
    {
        public Form05MayorTresNumeros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int mayor = 0, menor = 0, intermedio = 0;
            //Evaluamos el mayor
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }
            //Evaluamos el menor
            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }
            else if (num2 <= num3 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }
            int suma = num1 + num2 + num3;
            intermedio = suma - mayor - menor;
            this.lblResultado.Text = "Mayor: " + mayor +
                "\nIntermedio: " + intermedio +
                "\nMenor: " + menor;
        }
    }
}
