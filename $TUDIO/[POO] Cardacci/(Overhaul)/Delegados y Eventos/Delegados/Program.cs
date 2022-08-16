//https://www.youtube.com/playlist?list=PLLGdqRi7N09ZpC4k8Aoz4dH4QYcdAyjwM

using static System.Console;

namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hay 3 sintaxis para declarar un delegado.
            DelegadoVoidEntero miDelegado1 = new DelegadoVoidEntero(ImprimirEntero);
            var miDelegado2 = new DelegadoVoidEntero(Suma10);

            var miDelegado3 = new DelegadoVoidCadena(ImprimirCadena);
            DelegadoVoidCadena miDelegado4 = ImprimirCadena;

            WriteLine("\nUsando delegados.");
            miDelegado1(5);
            miDelegado2(10);

            WriteLine("\nPasar delegado como parámetro.");
            PasarDelegadoVoid(miDelegado1);

            WriteLine("\nAgregando varios métodos a un delegado.");
            DelegadoVoidEntero miDelegado5 = ImprimirEntero;
            miDelegado5 += Suma10;
            miDelegado5(15);

            WriteLine("\nBorrando un método de un delegado.");
            miDelegado5 -= ImprimirEntero;
            miDelegado5(7);

            WriteLine("\nCon Invoke (ambas líneas hacen lo mismo).");
            miDelegado5(100);
            miDelegado5.Invoke(100);

            //Target es el objeto sobre el cual el método es llamado.
            WriteLine("\n¿Para qué sirve Target?");
            var cat = new Cat();
            miDelegado5 = cat.SomeCatMethod;
            miDelegado5(75);
            WriteLine(miDelegado5.Target?.GetType().Name);

            ReadKey();
        }

        public static void ImprimirEntero(int x)
        {
            WriteLine(x);
        }

        public static void ImprimirCadena(string x)
        {
            WriteLine(x);
        }

        public static void PasarDelegadoVoid(DelegadoVoidEntero delegado)
        {
            delegado(5);
        }

        public static void Suma10(int x)
        {
            WriteLine(x + 10);
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public void SomeCatMethod(int number) { }
    }
}
