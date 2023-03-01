using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapturaFinal2022
{
    public abstract class Carnivoro : Animal
    {
        public abstract string FechaInstancia { get; }
        public abstract string HoraInstancia { get; }

        public abstract void Comer(IAlimento alimento);
    }
}