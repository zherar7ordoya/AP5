using BEL;

namespace BLL
{
    public class NumeroBLL
    {

        public int SUMAR(NumeroBEL numero)
        {
            return numero.Numero1 + numero.Numero2;
        }

        public int MULTIPLICAR(NumeroBEL numero)
        {
            return numero.Numero1 * numero.Numero2;
        }
    }
}
