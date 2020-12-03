using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Producto
    {

        public Producto() { }

        public Producto(String nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public String Nombre { get; set; }
        public int Precio { get; set; }

    }
}
