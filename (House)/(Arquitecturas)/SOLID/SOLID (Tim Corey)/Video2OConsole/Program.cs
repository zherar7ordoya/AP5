using System;
using System.Collections.Generic;
using Video2OLibrary;

namespace Video2OConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel{FirstName="Tim", LastName="Corey"},
                new ManagerModel{FirstName="Sue", LastName="Storm"},
                new ExecutiveModel{FirstName="Sid", LastName="Roman"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine(
                    $"{emp.FirstName} " +
                    $"{emp.LastName}: " +
                    $"{emp.EmailAddress} " +
                    $"\tIsManager: {emp.IsManager} " +
                    $"\tIsExecutive: {emp.IsExecutive}");
            }

            Console.ReadKey();
        }
    }
}
