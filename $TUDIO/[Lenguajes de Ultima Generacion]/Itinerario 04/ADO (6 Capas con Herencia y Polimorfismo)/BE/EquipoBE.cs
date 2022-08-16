using System.Collections.Generic;

namespace BE
{
    public class EquipoBE : Entidad
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        // Relación 1 a 1
        public TecnicoBE Tecnico { get; set; }

        // Relación 1 a M
        public List<JugadorBE> ListaJugadores = new List<JugadorBE>();
    }
}
