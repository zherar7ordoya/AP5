using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Listas2
{
   public class ErrorPersonalizado: Exception
    {
        public override string Message
        {
            get
            {
                return string.Format("Ya tiene contratado el pack seleccionado");
            }
        }
    }
}
