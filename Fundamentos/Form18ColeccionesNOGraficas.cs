using System;
using System.Collections;
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
    public partial class Form18ColeccionesNOGraficas : Form
    {
        public Form18ColeccionesNOGraficas()
        {
            InitializeComponent();
            this.button1.Click += RealizarClick;
            //Colleccion de objetos
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //Esto daria error en el bucle. No se detecta y compila bien hasta que llega al error de conversion
            //Hay que abstraerse
            coleccion.Add(this.textBox1);
            //Si queremos cambiar el color de fondo
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            //Un bucle EACH permite la conversion de Object a una clase definida
            //  //foreach(Button boton in coleccion)
            //  //{
            //  //    boton.BackColor = Color.LightGoldenrodYellow;
            //  //}
            //Esto estaría bien hecho porque no daría error al hacer el casting
            //  //foreach(Control boton in coleccion)
            //  //{
            //  //    boton.BackColor = Color.LightGoldenrodYellow;
            //  //}

            //Colecciones genericas: Son mas eficientes , tienen tipado y es mas facil
            //encontrar errores (tipo generico -> <T>)

            //List<Button> botones = new List<Button>();
            List<Control> botones = new List<Control>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //El compilador detecta errores de programacion y no deja iniciar:
            //  //botones.Add(this.textBox1); -> no inicia si es List<Button>
            botones.Add(this.textBox1);
            //Hay que hacer la lista de controles en lugar de hacerla de botones
            //Ya vienen tipados
            botones[0].BackColor = Color.LightCoral;
            //Recorremos todos los objetos
            foreach(Control control in botones)
            {
                control.BackColor = Color.LightSalmon;
                //Si quereemos hacer algo solo con los TextBox, se pregunta la clase del obj
                //PAra preguntar si el objeto es de una clase en concreto se usa el operador IS
                if(control is TextBox)
                {
                    control.BackColor = Color.Azure;
                    //La clase TextBox tiene un metodo .Paste();
                    //Que pega del portapapeles en la caja
                    //Si ponemos control.Paste(); no hace nada xq el compilador no sabe que ese control
                    //es un TextBox. Hay que hacerle casting
                    ((TextBox)control).Paste();
                }

            }

           


        }

        private void RealizarClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
