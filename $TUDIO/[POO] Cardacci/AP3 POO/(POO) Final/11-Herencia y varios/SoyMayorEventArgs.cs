using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Herencia_y_varios
{
    public class SoyMayorEventArgs
    {
        public int Edad { get; set; }
        public SoyMayorEventArgs(int pEdad)
        {
            Edad = pEdad;
        }
    }
}
