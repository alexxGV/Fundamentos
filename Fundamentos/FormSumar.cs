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
    public partial class FormSumar : Form
    {
        public FormSumar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Necesitamos los valores de las cajas, que son string, y necesitamos int
            //Hay que parsear
            int num1, num2, total;
            num1 = int.Parse(this.txtNum1.Text);
            num2 = int.Parse(this.txtNum2.Text);
            total = num1 + num2;
            this.lblResultado.Text = total.ToString();
        }

        private void FormSumar_Load(object sender, EventArgs e)
        {

        }
    }
}
