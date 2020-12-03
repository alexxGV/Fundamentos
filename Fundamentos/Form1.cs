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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcaja.Text = "Esto es un texto";
            //this INDICA LA CLASE SOBRE LA QUE ESTAMOS CURRANDO
            //por defecto si no lo ponemos recupera el nombre de variable por cercanía
            this.txtcaja.Width = 400;
            this.btnpulsar.Size = new Size(350, 250);
            this.BackColor = Color.Gainsboro;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
