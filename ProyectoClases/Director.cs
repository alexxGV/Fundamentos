using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }
        public new int GetVacaciones()
        {
            int vacas = base.GetVacaciones();
            Debug.WriteLine("GetVacaciones() de Director");
            return vacas + 3;
        }

        //OVERRIDE
        //public override int GetVacaciones()
        //{
        //    int vacas = base.GetVacaciones();
        //    Debug.WriteLine("GetVacaciones() de Director");
        //    return vacas +3;
        //}

        
        //OVERLOAD
        public int GetVacaciones(int diasextras)
        {
            
            return this.GetVacaciones() +diasextras;
        }
    }
}
