using static System.Console;
using Video3LLibrary;

namespace Video3LConsole
{
    class Program
    {
        static void Main()
        {
            IManager vicepresidente = new CEO
            {
                FirstName = "Emma",
                LastName = "Stone"
            };
            vicepresidente.CalculatePerHourRate(4);

            IManaged empleado = new Employee
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            empleado.AssignManager(vicepresidente);
            empleado.CalculatePerHourRate(2);

            WriteLine($"{empleado.FirstName}'s salary is ${empleado.Salary}/hour.");
            WriteLine($"El jefe es {empleado.Manager.FirstName} {empleado.Manager.LastName}.");

            ReadKey();
        }
    }
}
