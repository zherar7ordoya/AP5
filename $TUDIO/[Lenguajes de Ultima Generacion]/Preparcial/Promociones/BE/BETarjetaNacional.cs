using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETarjetaNacional: BETarjeta
    {
        #region "Propiedades"
        public string Provincia { get; set; }
        #endregion

        #region "Metodo tostring"
        public override string ToString()
        {
            return Codigo + " " + Provincia;
        }
        #endregion
    }
}
