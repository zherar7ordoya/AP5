using System.Collections.Generic;

namespace Presentacion_IU
{
    public class ClsEquipo
    {

        #region "Propiedades"
        public string Nombre { get; set; }
        public string Color { get; set; }

        //relacion 1 a 1
        public ClsTecnico Tecnico { get; set; }

        //relacion de 1 a muchos
        internal List<ClsJugador> ListaJugadores = new List<ClsJugador>();
        #endregion
     

        #region "Metodos"
        public int ObtenerPuntajeEquipo()
        {
            int ptos = 0;

            foreach (ClsJugador jugador in ListaJugadores)
            {
                ptos += jugador.ObtenerPuntaje();
            }

            return ptos;
        }
        #endregion

    }
}
