using BEL;

namespace BLL
{
    public class ProfesionalBLL : AJugadorBLL
    {
        public override int ObtenerPuntaje(AJugadorBEL jugador)
        {
            int puntaje = 20 * jugador.GolesRealizados - 4 * jugador.CantidadRojas - 2 * jugador.CantidadAmarillas;
            return puntaje;
        }
    }
}
