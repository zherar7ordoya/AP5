/** https://www.c-sharpcorner.com/UploadFile/1c8574/delegate-used-for-callback-operation/
 * 
 * A "callback" is a term that refers to a coding design pattern. In this
 * design pattern, executable code is passed as an argument to other code and 
 * it is expected to call back at some time. This callback can be synchronous
 * or asynchronous. So, in this way, large piece of the internal behavior of a 
 * method from the outside of a method can be controlled. It is basically a 
 * function pointer that is being passed into another function.
 * 
 * Delegate is a famous way to implement Callback in C#.
 * But, it can also be implemented by Interface.
 */

using static System.Console;

/// <summary>
/// Delegate is a good way to implement Callback. But, you could use interfaces
/// for this. Suppose you have two methods (one for the success and another for
/// error) and these methods will use callback. If you will use delegates, you
/// will have to take two delegates.
/// If you need more than one callback method, then use of delegates doesn't
/// makes sense. The use of interfaces provides flexible and well-performing
/// callback mechanisms for this scenario.
/// </summary>
namespace ByInterface
{
    class Program
    {
        static void Main()
        {
            RealizarEncuentro meetingExecution = new RealizarEncuentro();
            meetingExecution.PerformMeeting();
            ReadLine();
        }
    }

    //=========================================================================

    public interface IEncuentro
    {
        void MostrarAgenda(string agenda);
        void EmpleadoAsisteEncuentro(string empleado);
        void EmpleadoAbandonaEncuentro(string empleado);
    }

    //=========================================================================

    public class Encuentro : IEncuentro
    {
        public void MostrarAgenda(string agenda) => WriteLine("Agenda Details: " + agenda);

        public void EmpleadoAsisteEncuentro(string empleado) => WriteLine("Employee Attended Meeting: " + empleado);

        public void EmpleadoAbandonaEncuentro(string empleado) => WriteLine("Employee Left Meeting: " + empleado);
    }

    //=========================================================================

    public class SalonEncuentro
    {
        private readonly string mensaje;

        public SalonEncuentro(string mensaje) => this.mensaje = mensaje;

        public void ComenzarEncuentro(IEncuentro encuentro)
        {
            // Its a callback
            if (encuentro != null) encuentro.MostrarAgenda(mensaje);
        }
    }

    //=========================================================================

    public class RealizarEncuentro
    {
        public void PerformMeeting()
        {
            IEncuentro encuentro = new Encuentro();
            SalonEncuentro ReunionComienza = new SalonEncuentro("Code Quality Improvement.");
            ReunionComienza.ComenzarEncuentro(encuentro);
        }
    }

    ///////////////////////////////////////////////////////////////////////////

}
