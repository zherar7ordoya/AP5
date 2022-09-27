using DemoLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        //  ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ VARIABLES DE CLASE  ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶

        private readonly List<PersonModel> people = new();


        //  ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ CONSTRUCTOR  ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel { Id = 2, FirstName = "Sue", LastName = "Storm" });
            people.Add(new PersonModel { Id = 3, FirstName = "Gerardo", LastName = "Tordoya" });
        }


        //  ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ MÉTODOS  ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶ ̶̶̶̶̶̶

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new()
            {
                FirstName = firstName,
                LastName = lastName,
                Id = people.Max(x => x.Id) + 1
            };
            people.Add(p);
            return p;
        }
    }
}
