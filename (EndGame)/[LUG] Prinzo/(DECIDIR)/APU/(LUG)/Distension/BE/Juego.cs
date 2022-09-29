using System.Collections.Generic;

namespace BE
{
    public class Juego : Entidad
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}
