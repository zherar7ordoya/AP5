using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    public abstract class Figura
    {
        public abstract decimal CalcularSuperficie(decimal a, decimal b);
    }
    public class Cuadrado : Figura
    {
        public override decimal CalcularSuperficie(decimal a, decimal b)
        {
            return a * b;
        }
    }
    public class Triangulo : Figura
    {
        public override decimal CalcularSuperficie(decimal a, decimal b)
        {
            return (a * b)/2;
        }
    }
}
