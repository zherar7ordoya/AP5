using System.Collections.Generic;
using BEL;

namespace BLL
{
    public class EquipoBLL
    {
        #region Métodos
        public int ObtenerPuntajeEquipo(EquipoBEL equipo)
        {
            int ptos = 0;
            foreach (AJugadorBEL jugador in equipo.ListaJugadores)
            {
                if (jugador is PrincipianteBEL)
                {
                    PrincipianteBLL principiante = new PrincipianteBLL();
                    ptos = principiante.ObtenerPuntaje(jugador) + ptos;
                }
                else
                {
                    ProfesionalBLL profesional = new ProfesionalBLL();
                    ptos = profesional.ObtenerPuntaje(jugador) + ptos;
                }
            }
            return ptos;
        }
        #endregion
    }
}
