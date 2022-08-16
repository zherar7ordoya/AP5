namespace Entidades_de_Negocio_BE
{
    public class BEClsNumero
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public override string ToString() => $"{Numero1} {Numero2}";

        public BEClsNumero() { }

        public BEClsNumero(int n1, int n2) 
        {
            Numero1 = n1;
            Numero2 = n2;
        }
    }
}
