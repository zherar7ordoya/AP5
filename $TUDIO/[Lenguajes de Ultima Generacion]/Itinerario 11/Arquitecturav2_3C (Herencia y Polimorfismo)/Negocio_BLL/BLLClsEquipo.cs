using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio_BLL
{
    public class BLLClsEquipo
    {



        #region "Metodos"
        public int ObtenerPuntajeEquipo(BEClsEquipo oBEEquipo)
        {
            int ptos = 0;

            foreach (BEClsJugador jugador in oBEEquipo.ListaJugadores)
            {
                if (jugador is BEClsPrincipiante)
                {
                    BLLClsPrincipiante oBLLprin = new BLLClsPrincipiante();
                    ptos = oBLLprin.ObtenerPuntaje(jugador) + ptos;

                }
                else
                {
                    BLLClsProfesional oBLLprof = new BLLClsProfesional();
                    ptos = oBLLprof.ObtenerPuntaje(jugador) + ptos;
                }

            }
            return ptos;
        }
        #endregion
    }
}
