using System;

using static System.Console;

namespace ActionFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SomeMethod es PUBLIC
            Program clase = new Program();
            //Action action = clase.SomeMethod;

            // SomeMethod es STATIC
            Action action1 = SomeMethod1;

            // ACTION es, esencialmente, un delegado representando métodos VOID
            action1 += () => WriteLine("Else");
            action1();

            // Cuando ACTION recibe parámetros:
            Action<int> action2 = SomeMethod2;
            action2 += x => WriteLine(x);
            action2(10);

            Action<int, string, bool> action3 = SomeMethod3;
            action3 += (x, y, z) => WriteLine(x);

            // *---------------------------------------------------------=> ...

            // FUNC es casi lo mismo que ACTION pero tiene valores de retorno
            Func<int> func1 = SomeMethod4;

            // No se puede regresar varios valores de una función, así que solo
            // retornará el último.
            func1 += () => 24;
            WriteLine(func1());

            // El orden (el último es el retorno)
            Func<string, bool, int> func2 = SomeMethod5;
            WriteLine(func2("texto", true));

            // NOTA: Lo que permite...
            Func<int, int, int> sumFunc = (x, y) => x + y;
            WriteLine(sumFunc(7, 8));

            // Comienzan los gatos
            WriteLine("\nComienzan los gatos...");
            Action<Cat> catAction = cat => cat.SayMiau();
            var cat1 = new Cat
            {
                Name = "My Tested ASP.NET"
            };
            catAction(cat1);

            Func<Cat, string> catFunc = cat => cat.Name;
            WriteLine(catFunc(cat1));

            MiGato(cat => cat.Name);

            ReadKey();
        }

        /**
         * La palabra "static" delante de un atributo (una variable) de una
         * clase, indica que es una "variable de clase", es decir, que su valor
         * es el mismo para todos los objetos de la clase.
         * De igual modo, si un método (una función) está precedido por la
         * palabra "static", indica que es un "método de clase", es decir, un
         * método que se podría usar sin necesidad de declarar ningún objeto de
         * la clase.
         */
        static void SomeMethod1()
        {
            WriteLine("TEST");
        }
        static void SomeMethod2(int number)
        {
            WriteLine("TEST");
        }
        static void SomeMethod3(int number, string text, bool binario)
        {
            WriteLine("TEST");
        }
        static int SomeMethod4()
        {
            WriteLine("Calling...");
            return 42;
        }
        static int SomeMethod5(string text, bool binario)
        {
            WriteLine("Calling..." + text);
            return 100;
        }

        public static void MiGato(Func<Cat, string> func)
        {
            var cat = new Cat
            {
                Name = "Gris y disfónica"
            };
            WriteLine(func(cat));
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public void SayMiau()
        {
            WriteLine("Miau");
        }
    }
}
