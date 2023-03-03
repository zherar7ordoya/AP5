using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captura
{
    public class AnimalGestor
    {
        List<Animal> _listaAnimales = new List<Animal>();
        List<IAlimento> _listaAlimentos = new List<IAlimento>();

        public AnimalGestor()
        {
            _listaAnimales.Add(new Cebra("Rayada"));
            _listaAnimales.Add(new Ciervo("Bambi"));
            _listaAnimales.Add(new Leon("Fred"));
            _listaAnimales.Add(new Tigre("Tom"));

            foreach (var item in _listaAnimales)
            {
                if (item is IAlimento) _listaAlimentos.Add(item as IAlimento);
            }

            _listaAlimentos.Add(new Pasto("California"));
            _listaAlimentos.Add(new Planta("Cactus"));
        }

        public List<Animal> GetAnimales()
        {
            return _listaAnimales;
        }

        public List<IAlimento> GetAlimentos()
        {
            return _listaAlimentos;
        }

        public List<IAlimento> GetHistorial(Animal animal)
        {
            var estomago = _listaAnimales.Find(x => x.Nombre == animal.Nombre);
            return estomago.ListaAlimentos;
        }
    }
}
