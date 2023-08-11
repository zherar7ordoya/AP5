// https://www.youtube.com/watch?v=i0lnTVtwYT8&list=PLLGdqRi7N09ZpC4k8Aoz4dH4QYcdAyjwM&index=3

/**
 * EVENTOS
 * Esencialmente, los eventos permiten suscribir a los cambios y recibir una
 * notificación cuando ese cambio sucede.
 * En este programa, queremos saber cada vez que la salud del gato cambia.
 * Cuando la salud de un gato llega a cero, removemos al gato.
 */

using static System.Console;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat
            {
                Id = 1,
                Name ="Tom",
                Health = 100
            };
            cat.OnHealthChanged += Cat_OnHealthChanged;
            cat.OnHealthChanged += Cat_IsDead;

            // Comencemos...
            cat.Health = 200;
            for (int i=0; i<10; i++)
            {
                cat.Health -= 20;
            }

            ReadKey();
        }

        private static void Cat_OnHealthChanged(object sender, int e)
        {
            var cat = (Cat)sender;
            WriteLine($"{cat.Name} has new health: {e}");
        }

        private static void Cat_IsDead(object sender, int e)
        {
            var cat = (Cat)sender;
            if (cat.Health <= 0)
            {
                WriteLine($"{cat.Name} is no longer alive...");
            }
        }
    }
}
