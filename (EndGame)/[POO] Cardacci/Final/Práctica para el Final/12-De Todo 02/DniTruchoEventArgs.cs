using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_De_Todo_02
{
    public class DniTruchoEventArgs:EventArgs
    {
        public int Dni { get; set; }
        public DniTruchoEventArgs(int pDni)
        {
            Dni = pDni;
        }
    }
}
