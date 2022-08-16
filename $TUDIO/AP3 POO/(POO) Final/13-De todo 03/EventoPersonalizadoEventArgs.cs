using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_De_todo_03
{
    public class EventoPersonalizadoEventArgs:EventArgs
    {
        public string Patente { get; set; }

        public EventoPersonalizadoEventArgs(string pPatente)
        {
            Patente = pPatente;
        }
    }
}
