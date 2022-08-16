using static System.Console;

namespace ByDelegate
{
    public class CTarea
    {
        public void ComenzarTarea(DTarea callback)
        {
            WriteLine("I have started a new task.");
            callback?.Invoke("I have completed the task.");
        }
    }
}
