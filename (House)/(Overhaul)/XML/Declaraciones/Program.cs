using static System.Console;
using System.Xml.Linq;

/// <summary>
/// 
/// La idea de este proyecto es crear el archivo de la imagen (ver en la
/// carpeta Solution Items) "functional construction in linq to xml.png".
/// 
/// NOTAS:
/// XML Document use XDocument class
/// XML Declaration use XDeclaration class
/// XML Comment use XComment class
/// XML Element use XElement class
/// XML Attribute use XAttribute class
/// 
/// </summary>

namespace Declaraciones
{
    class Program
    {
        static void Main()
        {
            XDocument xmlDocument = new XDocument(

                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("Creating an XML Tree using LINQ to XML"),

                new XElement("Students",

                    new XElement("Student", new XAttribute("Id", 101),
                        new XElement("Name", "Mark"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 800)),

                    new XElement("Student", new XAttribute("Id", 102),
                        new XElement("Name", "Rosy"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", 900)),

                    new XElement("Student", new XAttribute("Id", 103),
                        new XElement("Name", "Pam"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", 850)),

                    new XElement("Student", new XAttribute("Id", 104),
                        new XElement("Name", "John"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 950)
                    )
                )
            );

            xmlDocument.Save(@"Data.xml");

            WriteLine(@"Archivo creado en bin\Debug");
            ReadKey();
        }
    }
}
