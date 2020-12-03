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
    public partial class Form19MetodosEventoColecciones : Form
    {
        int contador; //SOLO SE DEBE DECLARAR. SE INICIALIZA EN EL CONSTRUCTOR
        List<Button> botones;
        //NUNCA SE INSTANCIA UN OBJETO AQUI. Se instancian en el constructor
        //List<Button>botones=new List<Button>; ESTA MAL HECHO
        //Si declaramos variables globales, siempre a nivel de clase
        public Form19MetodosEventoColecciones()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            //this.botones.Add(this.button3);
            //Ya que estamos hablando de colecciones en forms, hay una que
            //es CONTROLS, que tiene todos los controles de formulario
            //Si queremos guardar todos los botones del formulario, recorremos this.Controls
            //y almacenar solo los botones en la coleccion
            foreach(Control control in this.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
        }
        //NO tiene nada que ver un meto de evento (Cuando) con un metodo propio de la clase
        void AddEvents(bool activar)
        {
            if (activar)
            {
                foreach (Button boton in botones)
                {
                    boton.Click += MostrarMensaje;

                }
            }
            else
            {
                foreach (Button boton in botones)
                {
                    boton.Click -= MostrarMensaje;

                }
            }

        }
        private void chkAsociarMetodos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAsociarMetodos.Checked)
            {
                this.contador += 1;
                //Tiene acumulacion de evento, tantas veces checkees el boton, tantos MosrtarMensaje
                this.AddEvents(true);
            }
            else
            {
                this.contador -= 1;
                this.AddEvents(false);
            }
            this.lblNumeroEvento.Text = "Eventos asociados: " + this.contador;
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.LightBlue;
        }
    }
}
