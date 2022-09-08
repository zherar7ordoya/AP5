using ABS;
using System.Collections.Generic;
using System.Linq;

namespace BEL
{
    public class CalculadoraModel : ICalculadoraModel
    {
        public decimal Total { get; private set; }
        public decimal Acumulado { get; private set; }

        public void CalcularTotal(List<decimal> numeros)
        {
            Total = numeros.Sum();
            Acumulado += Total;
        }

        public void ReiniciarTotal()
        {
            Total = 0;
            Acumulado = 0;
        }
    }
}

// Comentario corto
/**
 * Comentario largo
 */ 