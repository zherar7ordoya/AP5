using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Captura
{
    public class Tigre : Animal, ICarnivoro
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }
        public override List<IAlimento> ListaAlimentos { get; set; }

        public Tigre(string nombre)
        {
            Nombre = $"Tigre {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
            ListaAlimentos = new List<IAlimento>();
        }

        public override string Comer(IAlimento alimento)
        {
            if (alimento is Vegetacion) throw new AlimentoException(this);
            return string.Empty;
        }
    }
}