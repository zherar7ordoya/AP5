using System;
using static System.Console;

namespace ConVariosDatos
{
    class Program
    {
        public static void Main()
        {
            Bll bll = new Bll();
            bll.ProcesoCompletado += ProcesoCompletado; // register with an event
            bll.ComenzarProceso();
            ReadKey();
        }

        // event handler
        public static void ProcesoCompletado(object sender, ProcesoEventArgs e)
        {
            WriteLine("Process " + (e.IsCompletado ? "Completed Successfully" : "failed"));
            WriteLine("Completion Time: " + e.Duracion.ToLongDateString());
        }
    }

    public class ProcesoEventArgs : EventArgs
    {
        public bool IsCompletado { get; set; }
        public DateTime Duracion { get; set; }
    }

    public class Bll
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<ProcesoEventArgs> ProcesoCompletado;

        public void ComenzarProceso()
        {
            var datos = new ProcesoEventArgs();

            try
            {
                WriteLine("Process Started!");
                // some code here..
                datos.IsCompletado = true;
                datos.Duracion = DateTime.Now;
                OnProcesoCompletado(datos);
            }
            catch (Exception)
            {
                datos.IsCompletado = false;
                datos.Duracion = DateTime.Now;
                OnProcesoCompletado(datos);
            }
        }

        protected virtual void OnProcesoCompletado(ProcesoEventArgs e)
        {
            ProcesoCompletado?.Invoke(this, e);
        }
    }
}
