using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace XML_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDocSload = XDocument.Load(Directory.GetCurrentDirectory() + @"\series.xml");

            var sList = xDocSload.Root.Elements("series").Select(element => element.Value).ToList();
            
            foreach (var x in sList)
            {
                if (x.Contains("Tordoya")) Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
