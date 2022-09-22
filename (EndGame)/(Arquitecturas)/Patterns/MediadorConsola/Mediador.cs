using System;
using static System.Console;

// BLANCO

namespace MediadorConsola
{
    public class Mediador
    {
        // Creamos un delegado que usaremos para invocar los métodos
        public delegate void MiDelegado(string emisor, string mensaje);
        MiDelegado DelegadoEnviarMensaje;

        // Añadimos los métodos que queremos invocar
        public void Suscribir(MiDelegado metodo)
        {
            DelegadoEnviarMensaje += metodo;
            ForegroundColor = ConsoleColor.White;
            WriteLine("(método suscripto)");
        }

        public void Enviar(string emisor, string mensaje)
        {
            // Usamos el mediador para censurar
            if (mensaje.Contains("PALABROTA")) mensaje = mensaje.Replace("PALABROTA", "*****");

            // Enviamos los mensajes correspondientes via delegado
            DelegadoEnviarMensaje(emisor, mensaje);
            ForegroundColor = ConsoleColor.White;
            WriteLine("\n(mensaje enviado)");
        }

        // Quitamos los métodos que ya no queremos invocar
        public void Bloquear(MiDelegado metodo)
        {
            DelegadoEnviarMensaje -= metodo;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\n========================= (bloqueo)");
        }
    }
}
