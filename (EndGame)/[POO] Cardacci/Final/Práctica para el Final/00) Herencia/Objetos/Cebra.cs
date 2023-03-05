using System.Collections.Generic;

namespace Captura
{
    public class Cebra : Animal, IAlimento, IHerbivoro
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }

        public override List<IAlimento> ListaAlimentos { get; set; }

        public Cebra(string nombre)
        {
            Nombre = $"Cebra {nombre}";
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