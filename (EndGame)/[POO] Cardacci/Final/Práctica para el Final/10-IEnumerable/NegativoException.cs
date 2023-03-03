using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneableEnumerableEnumerator
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
