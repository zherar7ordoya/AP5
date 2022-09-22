using System;
using static System.Console;

// AMARILLO

namespace MediadorConsola
{
    public class ColegaA : IColega
    {
        private readonly Mediador mediador;
        private readonly string nombre;

        public ColegaA(string nombre, Mediador mediador)
        {
            this.nombre = nombre;
            this.mediador = mediador;
            mediador.Suscribir(Recibir);
        }

        public void Recibir(string emisor, string mensaje)
        {
            if (nombre != emisor)
            {
                // Lleva a cabo la recepción según su lógica
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Soy {0} (Tipo A) recibo de {1}: {2}", nombre, emisor, mensaje);
            }
        }

        public void Enviar(string mensaje)
        {
            // Lleva a cabo el envío según su lógica.
            // No necesariamente debe ser un parámetro.
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\nSoy {0} (tipo A) || {1}\n", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}
