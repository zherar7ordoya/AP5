// ****************************************************
// https://www.tutorialsteacher.com/csharp/csharp-event
// ****************************************************

using System;
using static System.Console;

namespace SinDatos
{
    public class Bll
    {
        public event EventHandler ProcesoCompletado; // Event.

        public void ComenzarProceso()
        {
            WriteLine("Process Started!");
            OnProcesoCompletado(EventArgs.Empty);
        }

        protected virtual void OnProcesoCompletado(EventArgs e)
        {
            ProcesoCompletado?.Invoke(this, e);
        }
    }

    class Program
    {
        /**
         * This example can use EventHandler delegate without declaring a
         * custom Notify (DNotifica) delegate (ver proyecto "Consumir").
         */
        static void Main()
        {
            Bll bll = new Bll();
            bll.ProcesoCompletado += ProcesoCompletado; // Register with an event.
            bll.ComenzarProceso();
            ReadKey();
        }

        // Event Handler.
        public static void ProcesoCompletado(object sender, EventArgs e)
        {
            WriteLine("Process Completed!");
        }
    }

}
