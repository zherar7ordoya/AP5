using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsEquipo
    {
        #region "Propiedades"
        public string Nombre { get; set; }
        public string Color { get; set; }

        //relacion 1 a 1
        public BEClsTecnico Tecnico { get; set; }

        //relacion de 1 a muchos
        public List<BEClsJugador> ListaJugadores = new List<BEClsJugador>();
        #endregion

    }
}
