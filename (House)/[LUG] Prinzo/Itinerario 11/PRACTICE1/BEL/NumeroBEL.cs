using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NumeroBEL
    {
        #region CONSTRUCTORES
        public NumeroBEL()
        {
        }

        public NumeroBEL(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }
        #endregion

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public override string ToString() { return $"{Numero1} {Numero2}"; }
    }
}
