using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(HdeLeonEntities db = new HdeLeonEntities())
            {
                //People people = new People();
                //people.Nombre = "Claudia Tordoya";
                //people.Edad = 46;
                //people.idSexo = 2;

                //db.People.Add(people);
                //db.SaveChanges();

                //---

                //People people = db.People.Where(x => x.Nombre == "Irina Lobanova").First();
                //people.Nombre = "Kristina Dobrova";
                //db.Entry(people).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                //---

                People people = db.People.Find(9);
                db.People.Remove(people);
                db.SaveChanges();

                var lst = db.People.ToList();

                foreach (var p in lst)
                {
                    Console.Write($"\t{p.id}");
                    Console.Write($"\t{p.Nombre}");
                    Console.Write($"\t{p.Edad}");
                    Console.Write($"\t{p.idSexo}");
                    Console.WriteLine(string.Empty);
                }
            }
            Console.ReadKey();
        }
    }
}
