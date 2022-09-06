using System.Collections.Generic;

namespace ABS
{
    public interface ICalculadoraModel
    {
        decimal Total { get; }
        decimal Acumulado { get; }
        void CalcularTotal(List<decimal> numeros);
        void ReiniciarTotal();
    }
}
