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
            WriteLine("---------------------- [Se ha suscripto un nuevo método]");
        }

        public void Enviar(string emisor, string mensaje)
        {
            // Usamos el MODERADOR para censurar
            // Aquí moderador es una "regla", pero para evaluaciones más
            // complejas será una clase aparte.
            if (mensaje.Contains("PALABROTA")) mensaje = mensaje.Replace("PALABROTA", "*****");

            // Enviamos los mensajes correspondientes via delegado
            DelegadoEnviarMensaje(emisor, mensaje);
            ForegroundColor = ConsoleColor.White;
            WriteLine("\n-------------------------------------- [Mensaje Enviado]");
        }

        // Quitamos los métodos que ya no queremos invocar
        public void Bloquear(MiDelegado metodo)
        {
            DelegadoEnviarMensaje -= metodo;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\n---------------------------------------------- [Bloqueo]");
        }
    }
}
