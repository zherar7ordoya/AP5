namespace Negocio_BLL
{
    public abstract class BLLClsJugador
    {
        public string Nombre { get; set; }
        public int CantidadAmarillas { get; set; }
        public int CantidadRojas { get; set; }
        public int GolesRealizados { get; set; }

        public abstract int ObtenerPuntaje();
    }
}
