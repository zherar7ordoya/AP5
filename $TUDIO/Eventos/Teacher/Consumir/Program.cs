// ****************************************************
// https://www.tutorialsteacher.com/csharp/csharp-event
// ****************************************************

using static System.Console;

namespace Consumir
{
    public delegate void DNotifica(); //      Delegate (variable nivel espacio)

    public class Bll /* Clase Publicadora */
    {
        public event DNotifica ProcesoCompletado; // Event (propiedad de clase)

        public void ComenzarProceso()
        {
            WriteLine("Process Started!");
            OnProcesoCompletado();
        }

        /// <summary>
        /// "protected" and "virtual" enable derived classes to override the
        /// logic for raising the event. A derived class should always call the
        /// On<EventName> method of the base class to ensure that registered
        /// delegates receive the event.
        /// </summary>
        protected virtual void OnProcesoCompletado()
        {
            ProcesoCompletado?.Invoke();
        }
    }

    //================================== UIL ==================================

    class Program /* Clase Suscriptora */
    {
        static void Main() 
        {
            Bll bll = new Bll();
            bll.ProcesoCompletado += ProcesoCompletado; //       Register event
            bll.ComenzarProceso();
            ReadKey();
        }

        // *---------------------------------------------------=> Event Handler
        public static void ProcesoCompletado()
        {
            WriteLine("Process Completed!");
        }
    }

}
