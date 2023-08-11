using System.Collections.Generic;

namespace Captura
{
    public abstract class Animal
    {
        public abstract string Nombre { get; }
        public abstract string FechaInstancia { get; }
        public abstract string HoraInstancia { get; }
        public abstract List<IAlimento> ListaAlimentos { get; set; }

        public abstract void Comer(IAlimento alimento);
    }
}