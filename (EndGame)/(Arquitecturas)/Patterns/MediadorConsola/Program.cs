//  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  \\
// ▐░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▌ \\
// ▐░░█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█░░▌ \\
// ▐░░▌ Title:       PATRÓN MEDIADOR                                    ▐░░▌ \\
// ▐░░▌ Description: Patrones de diseño                                 ▐░░▌ \\
// ▐░░▌ Author:      Gerardo Tordoya                                    ▐░░▌ \\
// ▐░░▌ Date:        2022-09-25                                         ▐░░▌ \\
// ▐░░▌ Source:      https://youtu.be/s4j92Rj7TJk                       ▐░░▌ \\
// ▐░░█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█░░▌ \\
// ▐░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▌ \\
//  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  \\


using System;
using static System.Console;

// VERDE

namespace MediadorConsola
{
    internal class Program
    {
        static void Main()
        {
            // Creamos el mediador
            Mediador mediador = new Mediador();

            // Creamos los objetos que van a interactuar (colegas)
            IColega Ana = new ColegaA("Ana", mediador);
            IColega Luis = new ColegaA("Luis", mediador);
            IColega David = new ColegaB("David", mediador);

            Ana.Enviar("SALUDOS A TODOS");
            Luis.Enviar("¿CÓMO ESTÁN?");
            David.Enviar("BIEN, GRACIAS");

            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n---------------------------------------------- [Censura]");
            Luis.Enviar("DIGO PALABROTA AHORA");

            mediador.Bloquear(Luis.Recibir);
            Ana.Enviar("VEAN LOS VIDEOS");

            mediador.Suscribir(Luis.Recibir);
            David.Enviar("ME GUSTA CSHARP");

            ReadKey();
        }
    }
}
