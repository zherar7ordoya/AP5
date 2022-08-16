using BEL;

namespace BLL
{
    public class PrincipianteBLL : AJugadorBLL
    {
        public override int ObtenerPuntaje(AJugadorBEL jugador)
        {
            int puntaje = 10 * jugador.GolesRealizados - 2 * jugador.CantidadRojas - 2 * jugador.CantidadAmarillas;
            return puntaje;
        }
    }
}
