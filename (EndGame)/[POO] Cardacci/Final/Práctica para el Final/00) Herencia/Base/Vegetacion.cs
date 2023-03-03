using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Captura
{
    public abstract class Vegetacion
    {
        public abstract string Nombre { get; }
        public abstract string FechaInstancia { get; }
        public abstract string HoraInstancia { get; }
    }
}