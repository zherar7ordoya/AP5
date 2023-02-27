using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>() {
            new Producto() {Id=1},
            new Producto() {Id=2},
            new Producto() {Id=3}
        };
            bool respuesta = productos.Exists(x => x.Id == 1);
            Console.WriteLine($"Con lamba explícita: {respuesta}");
        }
    }


    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }
    }
}
