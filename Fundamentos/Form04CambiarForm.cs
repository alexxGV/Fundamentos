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
    public partial class Form04CambiarForm : Form
    {
        public Form04CambiarForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posX, posY;
            posX = int.Parse(txtPosicionX.Text);
            posY = int.Parse(this.txtPosicionY.Text);
            //Sintaxis IF
            if (posX > 0)
            {
                this.label1.Text = "Positivo";
            }
            else if (posX == 0)
            {
                this.label1.Text = "Zero";
            }
            else
            {
                this.label1.Text = "Negativo";
            }
            //Sintaxis Switch
            int numero = 1;
            switch (numero)
            {
                case 0:
                case 1:
                    this.label1.Text = "Valor 0 o 1";
                    break;
                case 2: 
                    this.label2.Text = "Valor 2";
                    break;
                default:
                    this.label1.Text = "Otros valores";
                    break;
            }

            btnPosicion.Location = new Point(posX, posY);

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int red, green, blue;
            red = int.Parse(txtRed.Text);
            green = int.Parse(txtGreen.Text);
            blue = int.Parse(txtBlue.Text);
            this.BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
