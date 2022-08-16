using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraccion;
using BE;
using MPP;

namespace BLL
{
    public abstract class BLLTarjeta
    {

        public BLLTarjeta() {

            
        }

        #region "Metodo abstracto"
        public abstract double AplicarDescuento(double importe);

        #endregion

    }
}
