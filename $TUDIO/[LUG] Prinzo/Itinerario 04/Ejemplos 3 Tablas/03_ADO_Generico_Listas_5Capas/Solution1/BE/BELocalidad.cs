using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELocalidad
    {
        #region "Propiedades"
        //propiedades de Localidad

        public int Codigo { get; set; }
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
