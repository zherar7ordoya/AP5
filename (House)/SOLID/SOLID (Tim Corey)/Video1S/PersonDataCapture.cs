using static System.Console;

namespace Video1S
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();

            Write("First name: ");
            user.FirstName = ReadLine();
            Write("Last name: ");
            user.LastName = ReadLine();

            return user;
        }
    }
}
