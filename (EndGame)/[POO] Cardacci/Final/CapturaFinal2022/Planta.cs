using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapturaFinal2022
{
    public class Planta : Vegetacion, IAlimento
    {
        public string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public Planta(string nombre)
        {
            Nombre = $"Planta {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }
    }
}