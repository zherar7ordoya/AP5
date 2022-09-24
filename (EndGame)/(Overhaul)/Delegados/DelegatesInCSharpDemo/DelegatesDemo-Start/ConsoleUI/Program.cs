using DemoLibrary;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI
{
    class Program
    {
        // VARIABLES GLOBALES.-------------------------------------------------
        static readonly CarritoDeCompras carrito = new CarritoDeCompras();

        // MÉTODO PRINCIPAL.---------------------------------------------------
        static void Main()
        {
            CargarCarrito();

            WriteLine($"Your total for this {carrito.Items.Count} " +
                      $"item(s) order is " +
                      // Aquí es donde obtengo mi dos returns:
                      $"{carrito.CalcularTotal(AlertarSubtotal, CalculateLeveledDiscount, AlertUser):C2}.");

            WriteLine();

            decimal total = carrito.CalcularTotal
                (
                subtotal => WriteLine($"Subtotal 2: {subtotal:C2}"),
                (items, subtotal) =>
                {
                    if (items.Count > 3) return subtotal * 0.5M;
                    else { return subtotal; }
                },
                message => WriteLine($"Cart 2 Alert: {message}")
                );
            WriteLine($"The total for Cart 2 is {total:C2}");
            
            WriteLine();

            Write("Please press any key to exit the application...");
            ReadKey();
        }

        // OTROS MÉTODOS.------------------------------------------------------
        private static void CargarCarrito()
        {
            carrito.Items.Add(new Producto { Nombre = "Cereal", Precio = 3.63M });
            carrito.Items.Add(new Producto { Nombre = "Milk", Precio = 2.95M });
            carrito.Items.Add(new Producto { Nombre = "Strawberries", Precio = 7.51M });
            //carrito.Items.Add(new Producto { Nombre = "Blueberries", Precio = 8.84M });
        }

        private static void AlertarSubtotal(decimal subtotal)
        {
            WriteLine($"Your subtotal is {subtotal:C2}.");
        }

        private static decimal CalculateLeveledDiscount(List<Producto> items, decimal subtotal)
        {
            if (subtotal > 100) return subtotal * 0.80M;
            if (subtotal > 50) return subtotal * 0.85M;
            if (subtotal > 10) return subtotal * 0.95M;
            return subtotal;
        }

        private static void AlertUser(string message)
        {
            WriteLine(message);
        }
    }
}
