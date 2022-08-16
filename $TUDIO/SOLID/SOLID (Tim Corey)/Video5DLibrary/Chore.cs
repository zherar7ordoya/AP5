namespace Video5DLibrary
{
    /// <summary>
    /// 
    /// MÓDULO DE ALTO NIVEL
    /// 
    /// CHORE también es un módulo de alto nivel: depende de LOGGER e/y EMAILER
    /// </summary>
    public class Chore : IChore
    {
        ILogger logger;
        IMessageSender messageSender;

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            this.logger = logger;
            this.messageSender = messageSender;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            logger.Log($"Completed {ChoreName}");
            messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }


}
