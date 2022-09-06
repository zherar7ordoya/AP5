using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class EquipoBEL
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Color { get; set; }

        //Relación 1 a 1
        public TecnicoBEL Tecnico { get; set; }

        //Relación 1 a Muchos
        public List<AJugadorBEL> ListaJugadores = new List<AJugadorBEL>();
        #endregion
    }
}
