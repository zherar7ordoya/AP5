using System;

namespace _5__D_
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen();
            double total = 0;

            // 0-Alimento 1-Medicina 2-Ropa
            almacen.AdicionarProducto(new Producto("Tomate", 0, 15.50));
            almacen.AdicionarProducto(new Producto("Banana", 0, 30));
            almacen.AdicionarProducto(new Producto("Analgésico", 1, 23.80));
            almacen.AdicionarProducto(new Producto("Jeans", 2, 450.99));
            almacen.AdicionarProducto(new Producto("Manzana", 0, 12.38));
            almacen.AdicionarProducto(new Producto("Antiácido", 1, 38.50));
            almacen.AdicionarProducto(new Producto("Blusa", 2, 200.88));

            Console.WriteLine("-----------------");

            Auditor auditor = new Auditor(almacen);
            total = auditor.TotalesAlimentos();

            Console.WriteLine("El total en alimentos es {0}", total);

            Console.ReadKey();
        }
    }
}
