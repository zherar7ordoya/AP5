using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapturaFinal2022
{
    public class Animal
    {
        public int FechaInstancia
        {
            get => default;
            set
            {
            }
        }

        public int HoraInstancia
        {
            get => default;
            set
            {
            }
        }

        public List<IAlimento> ListaAlimentos { get; set; }

        public void Comer(IAlimento alimento)
        {
            throw new System.NotImplementedException();
        }
    }
}