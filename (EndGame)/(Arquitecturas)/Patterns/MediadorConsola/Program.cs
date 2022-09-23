﻿using System;
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
            ColegaA Ana = new ColegaA("Ana", mediador);
            ColegaA Luis = new ColegaA("Luis", mediador);
            ColegaB David = new ColegaB("David", mediador);

            Ana.Enviar("SALUDOS A TODOS");
            Luis.Enviar("¿CÓMO ESTÁN?");
            David.Enviar("BIEN, GRACIAS");

            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n============================================== (censura)");
            Luis.Enviar("DIGO PALABROTA AHORA");

            mediador.Bloquear(Luis.Recibir);
            Ana.Enviar("VEAN LOS VIDEOS");

            mediador.Suscribir(Luis.Recibir);
            David.Enviar("ME GUSTA CSHARP");

            ReadKey();
        }
    }
}
