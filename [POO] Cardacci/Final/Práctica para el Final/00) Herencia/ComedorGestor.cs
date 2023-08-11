using System.Collections.Generic;
using System.Linq;

namespace Captura
{
    public class ComedorGestor
    {
        List<Animal> _listaAnimales = new List<Animal>();
        List<IAlimento> _listaAlimentos = new List<IAlimento>();

        public ComedorGestor()
        {
            _listaAnimales.Add(new Cebra("Yayita"));
            _listaAnimales.Add(new Ciervo("Rodolfo"));
            _listaAnimales.Add(new Leon("Gieco"));
            _listaAnimales.Add(new Tigre("Zucarita"));

            _listaAlimentos.Add(new Pasto("Californiano"));
            _listaAlimentos.Add(new Planta("Cactus"));

            // ¿Para qué esto? Para practicar el uso de LINQ (el truco: ToArray)
            var comibles = (from alimento in _listaAnimales
                            where alimento is IAlimento
                            select alimento as IAlimento).ToArray();

            // Se podría hacer directamente aquí usando la lista de animales y
            // añadiendo el "item as IAlimento" a la lista de alimentos
            foreach (var item in comibles)
            {
                if (item is IAlimento) _listaAlimentos.Add(item);
            }

            // Algo para el historial (que acepta repetidos: en la consigna, no
            // se especifica que no se puedan repetir). Es decir, no hay restricción
            foreach (var animal in _listaAnimales)
            {
                if (animal is ICarnivoro) animal.ListaAlimentos.Add(new Cebra("Roxana"));
                if (animal is ICarnivoro) animal.ListaAlimentos.Add(new Ciervo("Canada"));
                if (animal is IHerbivoro) animal.ListaAlimentos.Add(new Pasto("Montaraz"));
                if (animal is IHerbivoro) animal.ListaAlimentos.Add(new Planta("Ligustro"));

                if (animal is ICarnivoro) animal.ListaAlimentos.Add(new Cebra("Rayas"));
                if (animal is ICarnivoro) animal.ListaAlimentos.Add(new Ciervo("Cuernos"));
                if (animal is IHerbivoro) animal.ListaAlimentos.Add(new Pasto("Verde"));
                if (animal is IHerbivoro) animal.ListaAlimentos.Add(new Planta("Tupida"));
            }
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

        public void AgregaAnimal(Animal animal)
        {
            _listaAnimales.Add(animal);
        }

        public void AlimentaAnimal(Animal animal, IAlimento alimento)
        {
            var estomago = _listaAnimales.Find(x => x.Nombre == animal.Nombre);
            var comida = _listaAlimentos.Find(x => x.Nombre == alimento.Nombre);
            estomago.ListaAlimentos.Add(alimento);
            _listaAlimentos.Remove(alimento);
        }
    }
}
