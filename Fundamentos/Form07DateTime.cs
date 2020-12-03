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
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();
            this.txtFechaACtual.Text = DateTime.Now.ToString();
        }
        private void Form07DateTime_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Se recupera la fecha de la caja
            DateTime fecha = DateTime.Parse(this.txtFechaACtual.Text);
            if (this.chkCambiarFormato.Checked == true)
            {
                this.txtFechaACtual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaACtual.Text = fecha.ToShortDateString();
            }
        }
        private void txtFechaACtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaACtual.Text);
            if (rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (rdbMeses.Checked)
            {
                fecha = fecha.AddMonths(incremento);

            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
            this.lblDatos.Text="Bisiesto: "+DateTime.IsLeapYear(fecha.Year)+"\nDia Semana: "+fecha.DayOfWeek+"\nDia Año: "+fecha.DayOfYear;


        }
    }
}
