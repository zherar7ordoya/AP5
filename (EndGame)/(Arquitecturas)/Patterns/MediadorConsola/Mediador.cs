using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MediadorConsola
{
    public class Mediador
    {
        // Creamos un delegado que usaremos para invocar los métodos
        public delegate void DEnvio(string emisor, string mensaje);
        DEnvio enviarMensaje;

        // Añadimos los métodos que queremos invocar
        public void Suscribir(DEnvio metodo)
        {
            enviarMensaje += metodo;
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Se ha suscrito un nuevo método");
        }

        public void Enviar(string emisor, string mensaje)
        {
            // Usamos el mediador para censurar
            if (mensaje.Contains("palabrota")) mensaje = mensaje.Replace("palabrota", "*****");

            // Enviamos los mensajes correspondientes via delegado
            enviarMensaje(emisor, mensaje);
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\nMensaje enviado\n");
        }

        // Quitamos los métodos que ya no queremos invocar
        public void Bloqueo(DEnvio metodo)
        {
            enviarMensaje -= metodo;
            ForegroundColor = ConsoleColor.Red;
            WriteLine(" --- BLOQUEO --- ");
        }
    }
}
