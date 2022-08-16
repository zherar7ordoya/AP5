using System.Collections.Generic;

namespace Negocio_BLL
{
    public class BLLClsEquipo
    {
        #region "Propiedades"
        public string Nombre { get; set; }
        public string Color { get; set; }

        //relacion 1 a 1
        public BLLClsTecnico Tecnico { get; set; }

        //relacion de 1 a muchos
        public  List<BLLClsJugador> ListaJugadores = new List<BLLClsJugador>();
        #endregion



        #region "Metodos"
        public int ObtenerPuntajeEquipo()
        {
            int ptos = 0;

            foreach (BLLClsJugador jugador in ListaJugadores)
            {
                ptos = jugador.ObtenerPuntaje() + ptos;
            }
            return ptos;
        }
        #endregion
    }
}
