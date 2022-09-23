namespace BLL
{
    public class PiedraPapelTijera : Juego
    {
        public override int CalcularPuntaje(string estado)
        {
            switch (estado)
            {
                case "gana":
                    return 3;
                case "empata":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
