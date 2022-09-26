using static System.Console;

namespace ByDelegate
{
    public class Tarea
    {
        public void ComenzarTarea(DelegadoTarea callback)
        {
            WriteLine("I have started a new task.");
            callback?.Invoke("I have completed the task.");
        }
    }
}
