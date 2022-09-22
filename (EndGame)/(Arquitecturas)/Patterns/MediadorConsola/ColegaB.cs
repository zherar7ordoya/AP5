using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MediadorConsola
{
    public class ColegaB : IColega
    {
        private Mediador mediador;
        private string nombre;
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
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Soy {0}, {1} dice (mensaje #{2}): {3}", nombre, emisor, conteo, mensaje);
            }
        }

        public void Enviar(string mensaje)
        {
            // Lleva a cabo el envío según su lógica.
            // No necesariamente debe ser un parámetro.
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Soy {0} enviando este mensaje: {1}\n", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}
