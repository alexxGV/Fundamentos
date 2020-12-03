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
    public partial class Form09ValidarMail : Form
    {
        public Form09ValidarMail()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            if (email.Contains("@") == false)
            {
                this.lbldatos.Text = "No existe @";
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lbldatos.Text = "@al inicio o al final";
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lbldatos.Text = "Existe más de una @";
            }
            else if (email.Contains(".") == false)
            {
                this.lbldatos.Text = "No existe .";
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lbldatos.Text = "Punto después de la @";
            }
            else
            {
                int ultimopunto = email.LastIndexOf(".");
                string dominio = email.Substring(ultimopunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lbldatos.Text = "MAIL CORRECTISIMO!!";
                }
                else
                {
                    this.lbldatos.Text = "Dominio de 2 a 4 letras";
                }
            }
        }
    }
}
