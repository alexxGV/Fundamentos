using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{


    public enum TipoGenero
    {
        Masculino = 0, Femenino = 1
    }
    public enum Paises
    {
        España = 0, Francia = 1, EuskalHerria = 2,
    }
    public class Persona
    {
        #region Constructores persona
        public Persona()
        {
            Debug.WriteLine("Constructor vacio Persona");
        }
        public Persona(string name, string surname)
        {
            Debug.WriteLine("Constructor Persona con params");
            this.Nombre = name;
            this.Apellido = surname;
        }
        public Persona(string nom, string ape, string completo)
        {
            Debug.WriteLine("Constructor vacio Persona");
        }
        #endregion

        #region Propiedades
        private Direccion _Domicilio;
        public Direccion Domicilio
        {
            get { return this._Domicilio; }
            set { this._Domicilio = value; }

        }
        public Direccion DomicilioVacaciones { get; set; }
        //Todo lo que pongamos aqui, lo podremos desplegar/colapsar
        /*
         * Campos de la clase:
             Un campo suele ser privado, y una herramienta de clase (es una variable)
            Modificadores de acceso Tiene que ver con la encapsulacion:
                -Public y Private
         */
        // public string Nombre;
        //public int Edad;
        //En Visual Studio no se crean campos accesibles, se crean siempre propiedades
        //Una propiedad es un campo con un codigo, donde nos permite controlar elementos de codigo
        //(GETTER & SETTER)
        //Sintaxis:
        //Las propiedades son SIEMPRE publicas si quiero dejar que se acceda a ellas
        ////public TipoDato NombrePropiedad
        ////{
        ////    get { return valor; }
        ////    set { /*Tenemos VALUE para recuperar el dato*/ }
        ////}
        //Las propiedades tienen siempre un campo de control: _Propiedad
        //Este es el campo de la propiedad
        //Cuando cambias la propiedad, no se cambia de por si, sino el campo de control
        private String _Nombre;

        public string Nombre
        {
            get
            {
                //Devolvemos un valor
                return this._Nombre;
            }
            set
            {
                //Establecemos un valor
                this._Nombre = value;
            }
        }
        private String _Apellido;

        public string Apellido
        {
            get
            {
                //Devolvemos un valor
                return this._Apellido;
            }
            set
            {
                //Establecemos un valor
                this._Apellido = value;
            }
        }
        //Campo de la propiedad
        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //Tenemos un codigo para controlar los valores asignaos a la propiedad
                if (value < 0)
                {
                    //Valor por defecto si no cumple nuestros requisitos
                    //Error silencioso
                    //this._Edad = 0;
                    //Si queremos una excepcion en concreto:
                    //throw new TipoDeExcepcion
                    throw new Exception("Edad Negativa: " + value);
                }
                else
                {
                    this._Edad = value;
                }

            }
        }
        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                //Hay que manejar los errores, y comparar para ver si lo que nos envian, coincide con las posibilidades
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Rango de Generos not supported, coleguita");
                }

                this._Genero = value;
            }

        }
        private Paises _Nacionalidad;
        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value; }
        }
        //Una propiedad Indizada contiene multiples elementos
        //Es un conjunto, y necesitamos si o tambien un campo para manejar la propiedad
        //Quiero crear una prop que tenga espacio para descripciones de la persona
        private string[] _Descripciones = new string[5];
        //UNA PROPIEDAD INDIZADA NO TIENE NAME, SE USA this PARA CREARLA
        public string this[int indice]
        {
            get { return this._Descripciones[indice]; }
            set { this._Descripciones[indice] = value; }
        }
        #endregion
        #region Metodos de la clase Persona
        //Seguimos teniendo Metodos void y Metodos return
        //Tambien Metodos con params opcionales
        /*
         * public void MetodoParamsOpcionales(int numero, int opcional = 99)
         *  {
         *  //Numero es obligatorio, Opcional, al estar igualado por defecto, es opcional
         *  //Aqui el Codigo
         *  }
         */
        //SOBRECARGA DE UN METODO
        //Es decir, un metodo tiene diferentes formas, o sea, distintos codigos.
        //Para poder hacer sobrecarga, el metodo tiene que llamarse igual y tener distintos parametros y tipos
        public string GetNombreCompleto()
        {
            return this.Nombre + ", " + this.Apellido;
        }
        public string GetNombreCompleto(bool ordenacion)
        {
            if (ordenacion)
            {
                return this.Apellido + ", " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }
        #endregion
    }
}
