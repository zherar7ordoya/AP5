using System;
using static System.Console;

// CYAN

namespace MediadorConsola
{
    public class ColegaB : IColega
    {
        private readonly Mediador mediador;
        private readonly string nombre;
        private int conteo;

        public ColegaB(string nombre, Mediador mediador)
        {
            this.nombre = nombre;
            this.mediador = mediador;
            mediador.Suscribir(Recibir);
        }

        public void Recibir(string emisor, string mensaje)
        {
            conteo++;
            
            if (nombre != emisor) {
                // Lleva a cabo la recepción según su lógica
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Soy {0} (Tipo B) recido de {1}: {2} [#{3}]", nombre, emisor, mensaje, conteo);
            }
        }

        public void Enviar(string mensaje)
        {
            // Lleva a cabo el envío según su lógica.
            // No necesariamente debe ser un parámetro.
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\nSoy {0} (Tipo B) || {1}\n", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}
