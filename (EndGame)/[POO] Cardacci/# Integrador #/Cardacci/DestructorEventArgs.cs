using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    public class DestructorEventArgs : EventArgs
    {
        Persona _persona;

        public DestructorEventArgs(Persona pPersona)
        {
            _persona = pPersona;
        }

        public Persona Persona { get { return _persona; } }
    }
}
