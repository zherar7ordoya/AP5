using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Listas2
{
    internal class ClsPaquete:ICloneable    
    {
        #region "Propiedades"
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public  double PrecioU { get; set; }
        internal DateTime FechaPago { get; set; }
        public double Abono { get; set; }

        #endregion


        #region "TOString"
        public override string ToString()
        {
            return Cod + " " + Nombre + " " + Tipo;
        }

        #endregion

        #region "IClonable"

        public object Clone()
        {      //clona todo el objeto en forma superficial
            return this.MemberwiseClone();

        }

        #endregion


    }
}
