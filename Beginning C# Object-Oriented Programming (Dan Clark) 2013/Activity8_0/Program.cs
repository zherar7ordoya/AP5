using System.Collections.Generic;
using static System.Console;

namespace Activity8_0
{
    /// <summary>
    /// A class to define a person
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        //Our delegate
        // "Please feel free to assign any method that matches this signature to
        // the delegate and it will be called each time my delegate is called."
        public delegate bool FilterDelegate(Person person);

        static void Main()
        {

            //Create 4 Person objects
            Person person1 = new Person() { Name = "John", Age = 41 };
            Person person2 = new Person() { Name = "Jane", Age = 69 };
            Person person3 = new Person() { Name = "Jake", Age = 12 };
            Person person4 = new Person() { Name = "Jessie", Age = 25 };

            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { person1, person2, person3, person4 };

            //Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            //Stop me
            ReadKey();
        }

        /// <summary>
        /// A method to filter out the people you need
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="filter">A filter</param>
        /// <returns>A filtered list</returns>
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            WriteLine(title);
            foreach (Person person in people)
            {
                if (filter(person)) { WriteLine($"{person.Name}, {person.Age} years old"); }
            }
            Write("\n\n");
        }

        /*====================================FILTERS====================================*/
        static bool IsChild(Person person) { return person.Age < 18; }
        static bool IsAdult(Person person) { return person.Age >= 18 && person.Age < 65; }
        static bool IsSenior(Person person) { return person.Age >= 65; }
    }
}
