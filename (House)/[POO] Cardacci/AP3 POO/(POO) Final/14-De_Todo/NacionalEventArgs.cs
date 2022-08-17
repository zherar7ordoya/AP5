using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_De_Todo
{
    public class NacionalEventArgs:EventArgs
    {
        public string Nombre { get; set; }
        public NacionalEventArgs(string pNombre)
        {
            Nombre = pNombre;

        }
    }
}
