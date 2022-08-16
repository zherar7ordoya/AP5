using Entidades_de_Negocio_BE;

namespace Reglas_de_Negocio_BLL
{
    public class BLLClsNumero
    {
        public int SUMAR(BEClsNumero BENum) => BENum.Numero1 + BENum.Numero2;
        public int MULTIPLICAR(BEClsNumero BENum) => BENum.Numero1 * BENum.Numero2;
    }
}
