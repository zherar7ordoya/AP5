using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUrbainskyAlexis
{
    class ImporteElevadoEventArgs : EventArgs
    {
        #region campos
        decimal _ImporteTotal;
        #endregion

        #region Constructores

        public ImporteElevadoEventArgs(decimal pImporteTotal)
        {
            _ImporteTotal = pImporteTotal;
        }
        #endregion

        #region Propiedades
        public decimal ImporteTotal
        {
            get
            {
                return _ImporteTotal;
            }
        }

        #endregion
    }
}
