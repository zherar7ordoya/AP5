using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Captura
{
    public abstract class Animal
    {
        public abstract string Nombre { get; }
        public abstract string FechaInstancia { get; }
        public abstract string HoraInstancia { get; }

        public abstract void Comer(IAlimento alimento);

        public abstract List<IAlimento> ListaAlimentos { get; set; }
    }
}