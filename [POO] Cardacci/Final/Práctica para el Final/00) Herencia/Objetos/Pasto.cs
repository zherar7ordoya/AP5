namespace Captura
{
    public class Pasto : Vegetacion, IAlimento
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public Pasto(string nombre)
        {
            Nombre = $"Pasto {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }
    }
}