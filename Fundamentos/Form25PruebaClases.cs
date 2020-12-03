using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;


namespace Fundamentos
{
    public partial class Form25PruebaClases : Form
    {
        public Form25PruebaClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            this.lstDatos.Items.Clear();
            //TODA CLASE SE DEBE INSTANCIAR
            Persona person=new Persona();
            person.Nombre = "Gabri";
            person.Edad = 23;
            person[0] = "Mandubila Cuadrara";
            person[1]="Ojos Claros";
            //person[99] = "Probando fuera de rango";//ESTO DA ERROR OutOfRange, las propiedades indizadas, como tienen indice, ya esta controlado el error 
            person.Genero = TipoGenero.Masculino;
            person.Nacionalidad = Paises.EuskalHerria;
            this.lstDatos.Items.Add("Nombre: " + person.Nombre);
            this.lstDatos.Items.Add("Edad: " + person.Edad);
            this.lstDatos.Items.Add("Genero: " + person.Genero);
            this.lstDatos.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstDatos.Items.Add("Descripcion 0: " + person[0]);
            this.lstDatos.Items.Add("Descripcion 1: " + person[1]);
            this.lstDatos.Items.Add("Nombre Completo: " + person.GetNombreCompleto(true));
            person.Domicilio = new Direccion();
            person.Domicilio.Calle = "Calle Pez";
            this.lstDatos.Items.Add("Casa: " + person.Domicilio.Calle);
            person.DomicilioVacaciones = new Direccion();

            person.DomicilioVacaciones.Calle = "Calle Pececitos";
            this.lstDatos.Items.Add("Casa Vacaciones: " + person.DomicilioVacaciones.Calle);


        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.lstDatos.Items.Clear();
            Empleado emp = new Empleado();
            emp.Nombre = "Paco";
            emp.Apellido = "Porras";
            this.lstDatos.Items.Add("Datos completos: " + emp.GetNombreCompleto().ToString());
            Empleado empleado = new Empleado(emp.Nombre, emp.Apellido);
           
            Director dire = new Director();
            this.lstDatos.Items.Add("Director: " + dire.GetSalarioMinimo());
            this.lstDatos.Items.Add("Empleado: " + emp.GetSalarioMinimo());
            //this.lstDatos.Items.Add("Vacaciones Empleado: " + emp.GetVacaciones());
            this.lstDatos.Items.Add("Vacaciones Director: " + dire.GetVacaciones());
        }
    }
}
