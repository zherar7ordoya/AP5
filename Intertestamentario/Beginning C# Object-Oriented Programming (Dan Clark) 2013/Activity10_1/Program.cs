using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Author author = new Author();
                foreach (string name in author.GetAuthorList(25))
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine(author.CountAuthors());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
