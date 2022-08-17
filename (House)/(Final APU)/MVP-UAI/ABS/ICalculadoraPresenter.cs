using System;

namespace ABS
{
    public interface ICalculadoraPresenter
    {
        void Sumar(object sender, EventArgs e);
        void Reiniciar(object sender, EventArgs e);
        decimal ObtenerNumero(string texto);
    }
}
