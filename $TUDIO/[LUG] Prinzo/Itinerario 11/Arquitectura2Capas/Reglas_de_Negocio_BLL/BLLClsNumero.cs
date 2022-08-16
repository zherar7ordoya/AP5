namespace Reglas_de_Negocio_BLL
{
    public class BLLClsNumero
    {
       public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int SUMAR()
        {
            return Numero1 + Numero2;
        }

        public int MULTIPLICAR()
        {
            return Numero1 * Numero2;
        }
    }
}
