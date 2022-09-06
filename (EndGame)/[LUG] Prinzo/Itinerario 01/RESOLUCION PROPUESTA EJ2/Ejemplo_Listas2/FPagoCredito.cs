using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Listas2
{
    internal class FPagoCredito:FormaPago
    {
        public override string ToString()
        {
            return Cod + " " + Forma;
        }

        internal override double CalcularPrecio(double Precio)
        {
           return  Precio =  (Precio*1.1); 
      
        }
    }
}
