using System;
using System.Collections.Generic;
using System.Xml;

namespace BLL
{
    public class Jugador : ABSTRACTA.IGestor<BE.Jugador>
    {
        /* ----------------------------------------------------------------- *\
         * ARRANQUE                                                          *
        \* ----------------------------------------------------------------- */

        public MPP.Jugador JUGADOR;
        public Jugador() => JUGADOR = new MPP.Jugador();

        /* ----------------------------------------------------------------- *\
         * IMPLEMENTACIÓN                                                    *
        \* ----------------------------------------------------------------- */

        public BE.Jugador DetallarObjeto(BE.Jugador objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE.Jugador jugador)
        {
            return JUGADOR.Guardar(jugador);
        }

        public List<BE.Jugador> RecopilarObjetos()
        {
            return JUGADOR.RecopilarObjetos();
        }

        public bool Remover(BE.Jugador jugador)
        {
            return JUGADOR.Remover(jugador);
        }

        /* ----------------------------------------------------------------- *\
         * MÉTODOS                                                           *
        \* ----------------------------------------------------------------- */

        public XmlNodeList ListarJugadores()
        {
            return JUGADOR.ListarJugadores();
        }

    }
}
