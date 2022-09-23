using DemoLibrary;
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
                      $"{carrito.CalcularTotal(AlertarSubtotal):C2}.");

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
            carrito.Items.Add(new Producto { Nombre = "Blueberries", Precio = 8.84M });
        }

        private static void AlertarSubtotal(decimal subtotal)
        {
            WriteLine($"Your subtotal is {subtotal:C2}.");
        }
    }
}
