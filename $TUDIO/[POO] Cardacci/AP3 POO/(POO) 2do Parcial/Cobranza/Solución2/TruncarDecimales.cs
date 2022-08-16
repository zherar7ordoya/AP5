using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class TruncarDecimales
    {
        //Esta clase la tengo solo para truncar los decimales de los valores doubles.
        
        /// <summary>
        /// Metodo para truncar a 2 decimales los valores doubles
        /// </summary>
        public static double Truncar(double num)
        {           
            return (Math.Truncate(num * 100) / 100);
        }

        ~TruncarDecimales() { }
    }
}
