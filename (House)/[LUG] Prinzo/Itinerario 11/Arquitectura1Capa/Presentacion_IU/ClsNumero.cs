namespace Presentacion_IU
{
    public class ClsNumero
    { 
        internal int Numero1 { get; set; }
        internal int Numero2 { get; set; }

        internal int SUMAR()
        {
            return Numero1 + Numero2;
         }

        internal int MULTIPLICAR()
        {
            return Numero1 * Numero2;
        }
    }
}
