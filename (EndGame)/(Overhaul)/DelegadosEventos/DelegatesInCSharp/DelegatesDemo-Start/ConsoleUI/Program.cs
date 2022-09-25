using DemoLibrary;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI
{
    /// <summary>
    /// TIM COREY
    /// Delegates in C# - A practical demonstration, including Action and Func
    /// https://youtu.be/R8Blt5c-Vi4
    /// </summary>
    class Program
    {
        static readonly CarritoDeCompras carrito = new CarritoDeCompras();

        static void Main()
        {
            CargarCarrito();

            WriteLine($"El total para los {carrito.Items.Count} " +
                      $"item(s) de Carrito 1 es " +
                      // Aquí es donde obtengo mi dos returns:
                      $"{carrito.CalcularTotal(MostrarSubtotal, CalcularDescuento, InformarUsuario):C2}.");

            WriteLine();

            decimal total = carrito.CalcularTotal
                (
                subtotal => WriteLine($"Carrito 2 Subtotal:\t{subtotal:C2}"),
                (items, subtotal) =>
                {
                    if (items.Count > 3) return subtotal * 0.5M;
                    else { return subtotal; }
                },
                message => WriteLine($"Carrito 2 Informa:\t{message}")
                );
            WriteLine($"Carrito 2 Total:\t{total:C2}");
            
            WriteLine();

            Write("Pulse cualquier tecla para salir de la aplicación...");

            ReadKey();
        }

        // -------------------------------------------------------------------*
        
        private static void CargarCarrito()
        {
            carrito.Items.Add(new Producto { Nombre = "Cereal", Precio = 3.63M });
            carrito.Items.Add(new Producto { Nombre = "Milk", Precio = 2.95M });
            carrito.Items.Add(new Producto { Nombre = "Strawberries", Precio = 7.51M });
            carrito.Items.Add(new Producto { Nombre = "Blueberries", Precio = 8.84M });
        }

        private static void MostrarSubtotal(decimal subtotal)
        {
            WriteLine($"Su subtotal es {subtotal:C2}.");
        }

        private static decimal CalcularDescuento(List<Producto> items, decimal subtotal)
        {
            if (subtotal > 100) return subtotal * 0.80M;
            if (subtotal > 50) return subtotal * 0.85M;
            if (subtotal > 10) return subtotal * 0.95M;
            return subtotal;
        }

        private static void InformarUsuario(string mensaje)
        {
            WriteLine(mensaje);
        }
    }
}
