
// https://stackoverflow.com/questions/2019402/when-why-to-use-delegates

// ================================HERRAMIENTAS================================

using System.Collections.Generic;
using static System.Console;

// ===================================CÓDIGO===================================

namespace DelegateApp
{
    /// <summary>
    /// A class to define a person
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // ================================PROGRAMA================================

    class Program
    {
        //Our delegate
        public delegate bool FilterDelegate(Person person);

        static void Main()
        {
            //Create 4 Person objects
            Person person1 = new Person() { Name = "John", Age = 41 };
            Person person2 = new Person() { Name = "Jane", Age = 69 };
            Person person3 = new Person() { Name = "Jake", Age = 12 };
            Person person4 = new Person() { Name = "Jessie", Age = 25 };

            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>()
            { 
                person1,
                person2,
                person3,
                person4
            };

            //Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            Read();
        }

        //===============================MÉTODOS===============================

        /// <summary>
        /// A method to filter out the people you need
        /// </summary>
        /// <param name="title">Una etiqueta para el grupo</param>
        /// <param name="people">A list of people</param>
        /// <param name="filter">A filter</param>
        /// <returns>A filtered list</returns>
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            WriteLine(title);

            foreach (Person person in people)
            {
                if (filter(person)) WriteLine("{0}, {1} years old", person.Name, person.Age);
            }

            Write("\n\n");
        }

        //===============================FILTERS===============================

        static bool IsChild(Person person) => person.Age < 18;
        static bool IsAdult(Person person) => person.Age >= 18 && person.Age < 65;
        static bool IsSenior(Person person) => person.Age >= 65;

        //===============================THE END===============================

    }
}

/*
 * OUTPUT
 * 
 * Children:
 * Jake, 12 years old
 * 
 * Adults:
 * John, 41 years old
 * Jessie, 25 years old
 * 
 * Seniors:
 * Jane, 69 years old
 * 
*/
