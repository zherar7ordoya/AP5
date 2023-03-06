using System;

namespace Enumerable
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
