namespace Captura
{
    public class Planta : Vegetacion, IAlimento
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public Planta(string nombre)
        {
            Nombre = $"Planta {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }
    }
}