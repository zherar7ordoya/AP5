using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Pasto : Vegetacion, IAlimento
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public Pasto(string nombre)
        {
            Nombre = nombre;
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }
    }
}