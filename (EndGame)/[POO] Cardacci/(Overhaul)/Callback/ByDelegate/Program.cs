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
/// Delegate provides a way to pass a method as argument to other method. To
/// create a Callback in C#, function address will be passed inside a variable.
/// So, this can be achieved by using Delegate.
/// 
/// NOTA:
/// If you need more than one Callback method, then callback mechanism with the
/// use of delegate doesn't makes sense.
/// </summary>

namespace ByDelegate
{
    // Declarado a nivel espacio de nombres (pues se usa en dos clases).
    public delegate void DelegadoTarea(string texto);

    class Program
    {
        static void Main()
        {
            Prueba callback = new Prueba();
            callback.Probar();
            ReadLine();
        }
    }
}
