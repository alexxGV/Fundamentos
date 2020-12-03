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
    public partial class Form14SeleccionMultiple : Form
    {
        public Form14SeleccionMultiple()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtElemento.SelectAll();
            this.txtElemento.Focus();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach(int numero in this.lstElementos.SelectedIndices)
            {
                indices += numero+",";
            }
            
            foreach(object objeto in this.lstElementos.SelectedItems)
            {
                items += objeto + ",";
            }
            this.lblIndices.Text = indices.Trim(',');
            this.lblSeleccionados.Text = items.Trim(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //foreach(int indice in this.lstElementos.SelectedIndices)
            //{
            //    this.lstElementos.Items.RemoveAt(indice);
            //}
            //SI ELIMINAMOS MULTIPLES COSAS DESDE UNA COLECCION, HAY QUE HACERLO CON UN BUCLE for INVERSO
            int numelementos = this.lstElementos.SelectedIndices.Count-1;
            for (int i = numelementos; i >= 0; i--)
            {
                int seleccionado = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(seleccionado);
            }

        }
    }
}
