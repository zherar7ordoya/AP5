using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MediadorConsola
{
    public class ColegaA : IColega
    {
        private Mediador mediador;
        private string nombre;

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
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Soy {0}, recibí de {1}: {2}", nombre, emisor, mensaje);
            }
        }

        public void Enviar(string mensaje)
        {
            // Lleva a cabo el envío según su lógica.
            // No necesariamente debe ser un parámetro.
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Soy {0}, envío este mensaje: {1}\n", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}
