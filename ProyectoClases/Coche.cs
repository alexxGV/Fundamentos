using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Coche
    {

        public Coche()
        {

        }

        public Coche(String marca, String modelo, byte[] imagen) 
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Imagen = imagen;
        }

        public String Marca { get; set; }
        public String Modelo { get; set; }
        public byte[] Imagen { get; set; }
    }
}
