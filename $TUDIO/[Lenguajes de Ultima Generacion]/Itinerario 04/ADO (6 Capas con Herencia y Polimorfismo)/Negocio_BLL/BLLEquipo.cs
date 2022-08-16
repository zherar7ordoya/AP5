using System;
using System.Collections.Generic;
using BE;
using Abstraccion;
using MPP;

namespace Negocio_BLL
{
    public class BLLEquipo:IGestor<EquipoBE>
    {
        public BLLEquipo()
        {
            oMPPEquipo = new MPPEquipo();
        }

        MPPEquipo oMPPEquipo;

        #region "Metodo Propio"
        public int ObtenerPuntajeEquipo(EquipoBE oBEEquipo)
        {
            int ptos = 0;

            foreach (JugadorBE jugador in oBEEquipo.ListaJugadores)
            {
                if (jugador is BEPrincipiante)
                {
                    BLLPrincipiante oBLLprin = new BLLPrincipiante();
                    ptos = oBLLprin.ObtenerPuntaje(jugador) + ptos;

                }
                else
                {
                    BLLProfesional oBLLprof = new BLLProfesional();
                    ptos = oBLLprof.ObtenerPuntaje(jugador) + ptos;
                }

            }
            return ptos;
        }
        #endregion

        public List<EquipoBE> ListarTodo()
        {
            return oMPPEquipo.ListarTodo();
        }

        public bool Guardar(EquipoBE oBEEquipo)
        {
            return oMPPEquipo.Guardar(oBEEquipo);
        }

        public bool Baja(EquipoBE Objeto)
        {
            throw new NotImplementedException();
        }

        public EquipoBE ListarObjeto(EquipoBE Objeto)
        {
            throw new NotImplementedException();
        }

       

    }
}
