using static System.Console;

namespace Video5DLibrary
{
    /// <summary>
    /// 
    /// MÓDULO DE BAJO NIVEL
    /// 
    /// LOGGER depende de nadie, es pues, un módulo de bajo nivel.
    /// </summary>
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            WriteLine($"Write to Console: {message}");
        }
    }


}
