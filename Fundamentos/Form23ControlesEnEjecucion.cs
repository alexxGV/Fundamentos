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
    public partial class Form23ControlesEnEjecucion : Form
    {
        public Form23ControlesEnEjecucion()
        {
            
            InitializeComponent();
            this.txtValor.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int posx = 0;
            for(int i = 0; i <= 5; i++) {
                CheckBox check = new CheckBox();
                check.Text = random.Next(1, 50).ToString();
                check.Location = new Point(posx, 10);
                check.AutoSize=true;
                posx += 55;
                this.panel1.Controls.Add(check);
                check.CheckedChanged += RealizarOperacion;
            }

        }

        private void RealizarOperacion(object sender, EventArgs e)
        {
            int valor = int.Parse(this.txtValor.Text);
            CheckBox check = (CheckBox)sender;
            int num = int.Parse(check.Text);
            if (check.Checked)
            {
                valor += num;
            }
            else
            {
                valor -= num;
            }
            this.txtValor.Text = valor.ToString();

        }
    }
}
