namespace Negocio_BLL
{
    public class BLLClsProfesional: BLLClsJugador
    {
        public override int ObtenerPuntaje()
        {
            int puntaje = 20 * GolesRealizados - 4 * CantidadRojas - 2 * CantidadAmarillas;
            return puntaje;
        }
    }
}
