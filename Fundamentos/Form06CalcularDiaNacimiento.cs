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
    public partial class Form06CalcularDiaNacimiento : Form
    {
        public Form06CalcularDiaNacimiento()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string[] tablaDias = { "Sabado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);
            string diaSemana = "";
            switch (mes)
            {
                case 1:
                    mes = 13;
                    anio -= 1;
                    break;
                case 2:
                    mes = 14;
                    anio -= 1;
                    break;
            }
            int paso1 = Math.Abs(((mes + 1) * 3) / 5);
            int paso2 = Math.Abs(anio/4);
            int paso3 = Math.Abs(anio / 100);
            int paso4 = Math.Abs(anio / 400);
            int paso5 = Math.Abs(dia + (mes * 2) + anio + paso1 + paso2 - paso3 + paso4 + 2);
            int paso6 = Math.Abs(paso5 / 7);
            int paso7 = Math.Abs(paso5 - (paso6 * 7));
            diaSemana = tablaDias[paso7];
            this.lblDiaSemana.Text = diaSemana;

        }
    }
}
