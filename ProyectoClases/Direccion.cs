using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    
    public class Direccion
    {
        #region CONSTRUCTOR DE DIRECCION
        public Direccion()
        {
            Debug.WriteLine("Constructor de direccion simple");
        }
        //Por el polimorfismo, podemos tener varios constructores
        public Direccion(string Calle, string Ciudad) {
            //Iniciamos las props
            this.Calle = Calle;
            this.Ciudad = Ciudad;
            Debug.WriteLine("Constructor de direccion con params");

        }
        public Direccion(string Calle, string Ciudad, int cp)
        {
            //Iniciamos las props
            this.Calle = Calle;
            this.Ciudad = Ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor de direccion con MAS params");

        }
        #endregion
        ////Cuando no queremos comprobar valores de la propiedad se usan propiedades autoimplementadas
        //private string _Calle;
        //public string Calle
        //{
        //    get { return this._Calle; }
        //    set { this._Calle = value; }
        //}
        ////Cuando SI queremos comprobar algo, usamos propiedades extendidas
        ////No tenemos que escribir el campo, esta implementado dentro de la declaracion
        //public string Calle2 { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }



    }
}
