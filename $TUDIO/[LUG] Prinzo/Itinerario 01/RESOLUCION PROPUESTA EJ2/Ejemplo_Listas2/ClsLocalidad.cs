using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Listas2
{
   public class ClsLocalidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return ID + " " + Nombre;
        }
    }
}
