using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELocalidad: Entidad
    {
        #region "Propiedades"
        //propiedades de Localidad

      
        public string Localidad { get; set; }

        #endregion

        #region "Metodos"
        public override string ToString()
        {
            return Codigo + " " + Localidad;
        }
        #endregion

    }
}
