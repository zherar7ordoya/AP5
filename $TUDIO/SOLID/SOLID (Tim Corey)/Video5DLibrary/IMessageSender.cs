namespace Video5DLibrary
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}