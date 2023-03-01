using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapturaFinal2022
{
    public class Cebra : Herbivoro, IAlimento
    {
        public string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public Cebra(string nombre)
        {
            Nombre = $"Cebra {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }

        public override void Comer(IAlimento alimento)
        {
            throw new NotImplementedException();
        }
    }
}