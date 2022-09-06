using static System.Console;

namespace Video5DLibrary
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            WriteLine($"I am texting {person.FirstName} to say {message}");
        }
    }
}
