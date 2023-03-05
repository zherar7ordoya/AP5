using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    public class MenordeEdadEventArgs:EventArgs
    {
        public int Edad { get; set; }
        public MenordeEdadEventArgs(int pEdad)
        {
            Edad = pEdad;

        }
    }
}
