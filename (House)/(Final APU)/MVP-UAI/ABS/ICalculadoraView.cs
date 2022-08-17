using System;

namespace ABS
{
    public interface ICalculadoraView
    {
        event EventHandler Sumar;
        event EventHandler Reiniciar;
        string Valor1 { get; set; }
        string Valor2 { get; set; }
        string Valor3 { get; set; }
        string Total { set; }
        string Acumulado { set; }
        void Show(); // Este Show es nativo del form (no tocar).
    }
}
