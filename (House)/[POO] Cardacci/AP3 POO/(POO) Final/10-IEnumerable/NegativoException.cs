using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IEnumerable
{
    class NegativoException : Exception
    {
        public int NumIngresado { get; set; }
        public NegativoException(int pNumero)
        {
            NumIngresado = pNumero;
        }

        public override string Message => "El numero que usted ingreso es negativo. Usted ingresó :"+NumIngresado;
    }
}
