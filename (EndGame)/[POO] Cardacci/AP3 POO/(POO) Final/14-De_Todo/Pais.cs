using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_De_Todo
{
    public class Pais<T> : ICloneable
    {
        public T Codigo { get; set; }
        public string Nombre { get; set; }

        
        public object Clone()
        {
            return MemberwiseClone();
        }

        public string RetornaCadena<T>(T pParametro)
        {
            return pParametro.GetType().ToString();
        }
    }
}
