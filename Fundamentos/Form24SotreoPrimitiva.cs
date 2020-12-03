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
    public partial class Form24SotreoPrimitiva : Form
    {
        List<int> seleccionados;
        List<int> premiados;
        bool puedeSeleccionar;

        public Form24SotreoPrimitiva()
        {
            InitializeComponent();
            seleccionados = new List<int>();
            premiados = new List<int>();
            puedeSeleccionar = true;
            Generar();
            
        }
        
        private void Seleccionar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int valor=int.Parse(btn.Text);
            if (this.seleccionados.Count < 6&&this.puedeSeleccionar) {
                if (btn.BackColor == Color.White)
                {
                    seleccionados.Add(valor);
                    btn.BackColor = Color.Yellow;
                }
                else
                {
                    btn.BackColor = Color.White;
                    seleccionados.Remove(valor);
                }
                if (this.seleccionados.Count == 6)
                {
                    this.puedeSeleccionar=false;
                }
            }
            else if(!this.puedeSeleccionar&&btn.BackColor==Color.Yellow){
                btn.BackColor = Color.White;
                seleccionados.Remove(valor);
                this.puedeSeleccionar = true;


            }
        }
        void Generar()
        {
            int contador = 0;
            this.panel1.Controls.Clear();
            this.seleccionados.Clear();
            this.premiados.Clear();
            int posX = 2;
            int posY = 2;
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.Text = (i + 1).ToString();
                btn.Width = 30;
                btn.Height = 30;

                btn.Location = new Point(posX, posY);
                posX += btn.Width;
                contador++;
                if (contador==5)
                {
                    posX = 2;
                    posY += btn.Height + 2;
                    contador = 0;
                }
                btn.Click += Seleccionar;
                this.panel1.Controls.Add(btn);

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.btnSortear.Enabled = true;
            this.puedeSeleccionar = true;
            Generar();
            

        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random random=new Random();
            for(int i = 0; i < 6; i++)
            {
                //int premiado = random.Next(1, 20);
                //this.premiados.Add(premiado);
                int premiado = i;
                this.premiados.Add(premiado);

            }
            foreach (int premio in this.premiados)
            {
                this.panel1.Controls[premio - 1].BackColor = Color.Red;
                if (this.seleccionados.Contains(premio))
                {
                    this.panel1.Controls[premio-1].BackColor = Color.Green;
                }
            }
            this.btnSortear.Enabled = false;
        }
    }

}
