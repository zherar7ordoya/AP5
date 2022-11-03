namespace BEL
{
    public class Modelo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        override public string ToString()
        {
            return $"El código que obtuviste es {Codigo}";
        }
    }
}
