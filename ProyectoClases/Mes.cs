using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        #region Constructor
        public Mes()
        {

        }
        public Mes(string nombre,int max, int min)
        {
            this.Nombre = nombre;
            this.Maxima = max;
            this.Minima = min;
        }

        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }
        #endregion
        public double GetAvg()
        {
            return (this.Maxima + this.Minima) / 2;
        }
    }
}
