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
    public partial class Form11ISBN : Form
    {
        public Form11ISBN()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string isbn = txtIsbn.Text;
            int suma = 0;
            for(int i = 0; i < isbn.Length; i++)
            {
                int numero = int.Parse(isbn[i].ToString());
                numero *= i + 1;
                suma += numero;
            }
            if (suma % 11 == 0)
            {
                this.lblDatos.ForeColor = Color.Green;
                this.lblDatos.Text = "El ISBN es CORRECTO";
            }
            else
            {
                this.lblDatos.ForeColor = Color.Red;
                this.lblDatos.Text = "El ISBN NO es correcto";
            }
        }
    }
}
