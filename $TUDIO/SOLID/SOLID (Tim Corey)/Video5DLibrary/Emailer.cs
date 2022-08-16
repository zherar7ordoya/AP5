using static System.Console;

namespace Video5DLibrary
{
    /// <summary>
    /// 
    /// MÓDULO DE BAJO NIVEL
    /// 
    /// EMAILER depende de nadie, es pues, un módulo de bajo nivel.
    /// </summary>
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }


}
