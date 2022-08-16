using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio_BLL
{
   public class BLLClsProfesional: BLLClsJugador
    {

        public override int ObtenerPuntaje(BEClsJugador oBEJug)
        {
            int puntaje = 0;
            puntaje = 20 * oBEJug.GolesRealizados - 4 * oBEJug.CantidadRojas - 2 * oBEJug.CantidadAmarillas;
            return puntaje;
        }
      
    }
}
