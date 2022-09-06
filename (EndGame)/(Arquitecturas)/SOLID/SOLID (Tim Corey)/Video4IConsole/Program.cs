using Video4ILibrary;
using static System.Console;

namespace Video4IConsole
{
    class Program
    {
        static void Main()
        {
            IBorrowableDVD dvd = new DVD();

            // La prueba: acceder a las propiedades de "dvd".

            dvd.Borrower = "Tim Corey";

            ReadKey();
        }
    }
}
