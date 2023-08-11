using System.Collections.Generic;

namespace Captura
{
    public class Ciervo : Animal, IAlimento, IHerbivoro
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }
        public override List<IAlimento> ListaAlimentos { get; set; }

        public Ciervo(string nombre)
        {
            Nombre = $"Ciervo {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
            ListaAlimentos = new List<IAlimento>();
        }

        public override void Comer(IAlimento alimento)
        {
            if (alimento is Animal) throw new AlimentoException($"{Nombre} es herbívoro");
        }
    }
}