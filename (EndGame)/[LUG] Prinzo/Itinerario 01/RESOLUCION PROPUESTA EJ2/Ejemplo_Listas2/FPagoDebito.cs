using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Listas2
{
    internal class FPagoDebito: FormaPago
    {

        public override string ToString()
        {
            return Cod + " " + Forma;
        }
        internal override double CalcularPrecio(double Precio)
        {
            return Precio = (Precio - (Precio * 0.25));
        }
    }
}
