using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETarjetaInternacional: BETarjeta
    {
        #region "Propiedades"
        public string Pais { get; set; }
        #endregion

        #region "Metodo tostring"
        public override string ToString()
        {
            return Codigo + " " + Pais;
        }
        #endregion
    }
}
