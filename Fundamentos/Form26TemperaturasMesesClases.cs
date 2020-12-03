using ProyectoClases;
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
    public partial class Form26TemperaturasMesesClases : Form
    {
        List<Mes> meses;
        public Form26TemperaturasMesesClases()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {


            this.lstMeses.Items.Clear();
            this.txtAvg.Clear();
            this.txtMin.Clear();
            this.txtMax.Clear();
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                int max = random.Next(15, 45);
                int min = random.Next(-15, 15);
                int avg = Math.Abs((max + min) / 2);

                switch (i)
                {
                    case 0:
                        this.lstMeses.Items.Add("Enero ");

                        break;
                    case 1:
                        this.lstMeses.Items.Add("Febrero ");
                        break;
                    case 2:
                        this.lstMeses.Items.Add("Marzo ");
                        break;
                    case 3:
                        this.lstMeses.Items.Add("Abril ");
                        break;
                    case 4:
                        this.lstMeses.Items.Add("Mayo ");
                        break;
                    case 5:
                        this.lstMeses.Items.Add("Junio ");
                        break;
                    case 6:
                        this.lstMeses.Items.Add("Julio ");
                        break;
                    case 7:
                        this.lstMeses.Items.Add("Agosto ");
                        break;
                    case 8:
                        this.lstMeses.Items.Add("Septiembre ");
                        break;
                    case 9:
                        this.lstMeses.Items.Add("Octubre ");
                        break;
                    case 10:
                        this.lstMeses.Items.Add("Noviembre ");
                        break;
                    case 11:
                        this.lstMeses.Items.Add("Diciembre ");
                        break;
                }

                Mes month = new Mes(this.lstMeses.Items[i].ToString(), min, avg);
                this.meses.Add(month);


            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstMeses.SelectedIndex;
            Mes mes = this.meses[indiceSeleccionado];
            this.txtMax.Text = mes.Maxima.ToString();
            this.txtMin.Text = mes.Minima.ToString();
            this.txtAvg.Text = mes.GetAvg().ToString();

        }
    }
}
