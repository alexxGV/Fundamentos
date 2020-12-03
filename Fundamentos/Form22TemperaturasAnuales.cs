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
    public partial class Form22TemperaturasAnuales : Form
    {
        List<String> meses;
        Random rand;
        List<int> temperaturas;
        public Form22TemperaturasAnuales()
        {
            temperaturas = new List<int>();
            rand = new Random();
            InitializeComponent();

        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                string mes;
                switch (i)
                {
                    case 0:
                        mes = "Enero " + this.rand.Next(-15, 45).ToString();
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 1:
                        mes = "Febrero " + this.rand.Next(-15, 45).ToString();
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 2:
                        mes = "Marzo " + this.rand.Next(-15, 45).ToString();
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 3:
                        mes = "Abril " + this.rand.Next(-15, 45).ToString();
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 4:
                        mes = ("Mayo " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 5:
                        mes = ("Junio " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 6:
                        mes = ("Julio " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 7:
                        mes = ("Agosto " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 8:
                        mes = ("Septiembre " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 9:
                        mes = ("Octubre " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 10:
                        mes = ("Noviembre " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                    case 11:
                        mes = ("Diciembre " + this.rand.Next(-15, 45).ToString());
                        this.lstMeses.Items.Add(mes);
                        break;
                }

            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            this.temperaturas.Clear();
            for (int i = 0; i < this.lstMeses.Items.Count; i++)
            {
                this.temperaturas.Add(int.Parse(this.lstMeses.Items[i].ToString().Substring(this.lstMeses.Items[i].ToString().LastIndexOf(" "))));
            }
            this.txtMaxima.Text = this.temperaturas.Max().ToString();
            this.txtMinima.Text = this.temperaturas.Min().ToString();
            this.txtMedia.Text = Math.Truncate(this.temperaturas.Average()).ToString();
        }
    }
}
