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
    public partial class Form21TablaMultiplicar : Form
    {
        List<TextBox> cajas;
        public Form21TablaMultiplicar()
        {
            InitializeComponent();
            cajas = new List<TextBox>();
            foreach (Control caja in this.gbxResultados.Controls)
            {
                if(caja is TextBox) { 
                TextBox cajaMultiplicar = (TextBox)caja;
                this.cajas.Add(cajaMultiplicar);
                }
            }
            this.cajas.Reverse();
        }



        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            int length = this.cajas.Count;
            for (int i = 1; i <= length; i++)
            {
                cajas[i - 1].Text = (numero * i).ToString();
            }
        }
    }
}
