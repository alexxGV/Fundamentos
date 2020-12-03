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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indice = this.lstElementos.SelectedIndex;
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items[indice] = elemento;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtElemento.SelectAll();
            this.txtElemento.Focus();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPosicion.Text = "Posicion: "+this.lstElementos.SelectedIndex;
            this.lblSeleccionado.Text = "Sleleccionado: " + this.lstElementos.SelectedItem;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);
        }
    }
}
