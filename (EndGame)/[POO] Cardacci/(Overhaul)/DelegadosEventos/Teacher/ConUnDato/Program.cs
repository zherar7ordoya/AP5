// ****************************************************
// https://www.tutorialsteacher.com/csharp/csharp-event
// ****************************************************

using System;
using static System.Console;

/// <summary>
/// 
/// BUILT-IN EVENTHANDLER DELEGATE
/// 
/// .NET Framework includes built-in delegate types EventHandler and
/// EventHandler<TEventArgs> for the most common events. Typically, any event
/// should include two parameters: the source of the event and event data.
/// 
///     *) Use the EventHandler delegate for all events that do not include
///        event data to be sent to handlers.
/// 
///     *) Use EventHandler<TEventArgs> delegate for all events that include
///        data to be sent to handlers.
/// 
/// </summary>
namespace ConUnDato
{
    class Program
    {
        public static void Main()
        {
            Bll bll = new Bll();
            bll.ProcesoCompletado += ProcesoCompletado; // Register with an event.
            bll.ComenzarProceso();
            ReadKey();
        }

        // Event Handler.
        public static void ProcesoCompletado(object sender, bool IsCompletado)
        {
            WriteLine("Process " + (IsCompletado ? "Completed Successfully" : "failed"));
        }
    }

    public class Bll
    {
        // Declaring an event using built-in EventHandler.
        public event EventHandler<bool> ProcesoCompletado;

        public void ComenzarProceso()
        {
            try
            {
                WriteLine("Process Started!");
                // Some code here...
                OnProcesoCompletado(true);
            }
            catch (Exception)
            {
                OnProcesoCompletado(false);
            }
        }

        protected virtual void OnProcesoCompletado(bool IsCompletado)
        {
            ProcesoCompletado?.Invoke(this, IsCompletado);
        }
    }

}
