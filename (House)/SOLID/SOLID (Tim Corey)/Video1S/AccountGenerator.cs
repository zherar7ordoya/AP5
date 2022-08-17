using static System.Console;

namespace Video1S
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            WriteLine(
                "Your username is " +
                $"{user.FirstName.Substring(0, 1).ToLower()}" +
                $"{user.LastName.ToLower()}");
        }
    }
}
