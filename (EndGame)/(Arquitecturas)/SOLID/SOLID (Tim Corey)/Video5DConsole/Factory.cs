using Video5DLibrary;

namespace Video5DConsole
{
    /// <summary>
    /// The job of FACTORY is new up instances when I need them.
    /// i.e., one place that has all the dependencies.
    /// </summary>
    public static class Factory
    {
        public static IPerson CreatePerson() => new Person();

        public static IChore CreateChore() => new Chore(CreateLogger(), CreateEmailer());

        public static ILogger CreateLogger() => new Logger();

        public static IMessageSender CreateEmailer()
        {
            //return new Emailer();
            return new Texter();
        }
    }
}
