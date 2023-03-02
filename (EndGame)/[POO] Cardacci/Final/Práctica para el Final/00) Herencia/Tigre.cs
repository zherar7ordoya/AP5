using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Tigre : Animal
    {
        public override string Nombre { get; }
        public override string Categoria { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }
        public override List<IAlimento> ListaAlimentos { get; set; }

        public Tigre(string nombre)
        {
            Nombre = $"Tigre {nombre}";
            Categoria = "Carnívoro";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }

        public override void Comer(IAlimento alimento)
        {
            throw new NotImplementedException();
        }
    }
}