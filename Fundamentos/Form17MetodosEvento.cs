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
    public partial class Form17MetodosEvento : Form
    {
        public Form17MetodosEvento()
        {
            InitializeComponent();
        }

        private void lblRaton_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ",Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled impide escribir
            //e.KeyChar-->char
            
            //Ahora queremos que tambien funcione la tecla de borrar
            //Hay que aislarla. Podemos recuperar el codigo ASCII de una tecla que no se puede recuperar
            //O preguntamos a San Google, o tiramos de la enumeracion que nos devuelve todos los codigos ASCII
            //Back-->8
            //char c = (char)8;
            char teclaBack = (char)Keys.Back;
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=teclaBack)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }


        }
    }
}
