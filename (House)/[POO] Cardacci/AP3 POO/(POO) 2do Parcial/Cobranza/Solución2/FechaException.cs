using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    /// <summary>
    ///  //Salta cuando la fecha está fuera de los limites minimo y máximo
    /// </summary>
    public class FechaException : Exception
    {
       
        #region PROPIEDADES

        public DateTime Fecha { get; set; }

        #endregion

        #region CONSTRUCTORES

        public FechaException(DateTime pFechaMinima)
        {
            Fecha = pFechaMinima;
        }

        #endregion

        #region METODOS

        public override string Message => "La fecha ingresada tiene que estar entre 1/1/1900 " +
            "y 31/12/2100\n\nUsted ingresó " + Fecha.ToShortDateString();
        
        #endregion

        #region DESTRUCTOR

        ~FechaException()  { } 
        
        #endregion

    }
}
