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
    public partial class Form16MetodoReferencia : Form
    {
        public Form16MetodoReferencia()
        {
            InitializeComponent();
        }

        //Metodo para comprobar valor en tipos WRAPPER
        void DobleNumero(int num)
        {
            num *= 2;
        }
        //Metodo que recibe una clase por referencia
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.DarkRed;
            boton.ForeColor = Color.White;
        }
        //ESTO NO ES NORMAL; MAS BIEN ES ANTIGUO
        //Metodo que recibe un WRAPPER o primitivo y lo usa como referencia
        void DobleReferencia(ref int num)
        {
            num *= 2;
        }
        //Si devolvemos algo, no es void, es el tipo que devolvamos
        int GetDoble(int num)
        {
            return (num *= 2);
        }
        private void btnLlamada_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //  //Llamamos al metodo con la variable por valor
            //this.DobleNumero(numero);
            //this.lblResultado.Text = "Doble: " + numero;
            //  //Llamamos al metodo que recibe un objeto por referencia
            //this.CambiarColor(this.btnLlamada);
            //  //Llamamos al metodo por referencia
            //  //Aunque si enviamos la referencia, hay que incluir la palabra "ref"
            //  //Tambien hay que ponerla en la definicion del metodo
            //this.DobleReferencia(ref numero);
            // //Llamamos al metodo que devuelve el doble
            this.lblResultado.Text ="Doble: "+ this.GetDoble(numero).ToString();
            
        }
    }
}
