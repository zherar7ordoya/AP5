using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captura
{
    public class AlimentoException : Exception
    {
        readonly Animal _estomago;

        public AlimentoException(Animal animal)
        {
            _estomago = animal;
        }

        public override string ToString()
        {
            string categoria = _estomago is ICarnivoro ? "carnívoro" : "herbívoro";
            return $"{_estomago.Nombre} es {categoria}";
        }
    }
}
