using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MediadorConsola
{
    internal class Program
    {
        static void Main()
        {
            // Creamos el mediador
            Mediador mediador = new Mediador();

            // Creamos los objetos que van a interactuar (colegas)
            ColegaA Ana = new ColegaA("Ana", mediador);
            ColegaA Luis = new ColegaA("Luis", mediador);
            ColegaB David = new ColegaB("David", mediador);

            Ana.Enviar("Saludos a todos");
            Luis.Enviar("¿Cómo están?");
            David.Enviar("Bien, gracias");

            WriteLine();

            ForegroundColor = ConsoleColor.White;
            WriteLine(" *** VERIFICAMOS CENSURA *** \n");
            Luis.Enviar("La palabrota no me gusta...");
            WriteLine();

            mediador.Bloqueo(Luis.Recibir);
            Ana.Enviar("Vean los vídeos");
            WriteLine();

            mediador.Suscribir(Luis.Recibir);
            David.Enviar("Me gusta C#");
            WriteLine();

            ReadKey();
        }
    }
}
