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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            //Conversion automatica:
            double mayor = 101;
            int menor = 100;
            //Si igualamnos mayort capacidad a menor capadicad, hay conversion automatica
            mayor = menor;//Todo bien
                          //menor = mayor; No se puede, habria que hacerlo de forma explicita

            //CASTING ENTRE PRIMITIVOS.
            //Los primitivos están todos en minusculas.
            //(Tipo a convertir)Objeto
            short mini = 34;//Menor
            int numero = 123;//Mayor
            numero = mini;
            mini = (short)numero;
            //Conversion de String a primitivo
            //tipoprimitivo.Parse(string)
            string convertir = "2234";
            int num = int.Parse(convertir);
            //Conversion de primitivo a String
            //System.Object tiene un metodo para convertirlo: ToString()
            int value = 222;
            string dato = value.ToString();
            //Los metodos tambien puedden tenener ssobrecarga
            MessageBox.Show("Texto", "titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }
    }
}
