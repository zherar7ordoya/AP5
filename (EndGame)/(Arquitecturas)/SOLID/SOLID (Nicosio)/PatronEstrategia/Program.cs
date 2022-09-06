using System;

namespace PatronEstrategia
{
    class Program
    {
        static void Main()
        {
            string dato = string.Empty, opcion = string.Empty;
            double x = 0, y = 0, r = 0;

            IOperacion operacion = new Suma();

            while (opcion != "5")
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicación, 4-División, 5-Salir");
                opcion = Console.ReadLine();
                if (opcion == "5") break;

                Console.Write("Valor de a: ");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.Write("Valor de b: ");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                switch (opcion)
                {
                    case "1":
                        operacion = new Suma();
                        break;
                    case "2":
                        operacion = new Resta();
                        break;
                    case "3":
                        operacion = new Multiplicacion();
                        break;
                    case "4":
                        operacion = new Division();
                        break;
                    default:
                        break;
                }
                r = operacion.Operacion(x, y);
                Console.WriteLine("El resultado es {0}", r);
            }
        }
    }
}
