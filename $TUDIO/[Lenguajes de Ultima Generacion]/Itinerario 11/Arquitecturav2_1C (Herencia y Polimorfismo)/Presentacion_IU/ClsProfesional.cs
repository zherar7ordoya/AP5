namespace Presentacion_IU
{
    public class ClsProfesional : ClsJugador
    {

        public override int ObtenerPuntaje()
        {
            int puntaje = 20 * GolesRealizados - 4 * CantidadRojas - 2 * CantidadAmarillas;
            return puntaje;
        }


    }
}
