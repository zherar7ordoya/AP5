using static System.Console;
using Video5DLibrary;

namespace Video5DConsole
{
    class Program
    {
        /// <summary>
        /// 
        /// MÓDULO DE ALTO NIVEL
        /// 
        /// MAIN es un módulo de alto nivel que llama a PERSON y a CHORE.
        /// Es decir, MAIN depende de esas dos clases.
        /// Por tanto, esas dos clases son sus dependencias.
        /// </summary>
        static void Main()
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            ReadLine();
        }
    }
}
