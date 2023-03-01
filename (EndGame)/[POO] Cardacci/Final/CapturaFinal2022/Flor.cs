using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapturaFinal2022
{
    public class Flor : Vegetacion
    {
        public string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public Flor(string nombre)
        {
            Nombre = $"Flor {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }
    }
}