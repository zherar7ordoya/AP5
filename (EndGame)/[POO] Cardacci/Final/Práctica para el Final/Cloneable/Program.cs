using System;

namespace Cloneable
{
    internal class Program
    {
        static void Main()
        {
            Persona persona1 = new Persona
            {
                Edad = 42,
                Nombre = "Sam",
                Id = new Identificacion(6565)
            };

            Persona persona2 = persona1.CopiaSuperficial();

            Console.WriteLine("VALORES ORIGINALES DE PERSONA1 Y PERSONA2:");
            Console.WriteLine("   Valores de instancia de Persona1:");
            MuestraValores(persona1);
            Console.WriteLine("   Valores de instancia de Persona2:");
            MuestraValores(persona2);

            // Change the value of p1 properties and display the values of p1 and p2.
            persona1.Edad = 32;
            persona1.Nombre = "Frank";
            persona1.Id.Id = 7878;

            Console.WriteLine("\nVALORES DE PERSONA1 Y PERSONA2 DESPUÉS DE HACER CAMBIOS EN PERSONA1:");
            Console.WriteLine("   Valores de instancia de Persona1:");
            MuestraValores(persona1);
            Console.WriteLine("   Valores de instancia de Persona2:");
            MuestraValores(persona2);

            Persona persona3 = persona1.CopiaProfunda();
            persona1.Nombre = "George";
            persona1.Edad = 39;
            persona1.Id.Id = 8641;

            Console.WriteLine("\nVALORES DE PERSONA1 Y PERSONA3 DESPUÉS DE HACER CAMBIOS EN PERSONA1:");
            Console.WriteLine("   Valores de instancia de Persona1:");
            MuestraValores(persona1);
            Console.WriteLine("   Valores de instancia de Persona3:");
            MuestraValores(persona3);

            Console.WriteLine();
        }

        public static void MuestraValores(Persona p)
        {
            Console.WriteLine("      Nombre: {0:s}, Edad: {1:d}", p.Nombre, p.Edad);
            Console.WriteLine("      Valor: {0:d}", p.Id.Id);
        }
    }

    public class Identificacion
    {
        public int Id;

        public Identificacion(int id)
        {
            this.Id = id;
        }
    }

    public class Persona // : ICloneable
    {
        public int Edad;
        public string Nombre;

        // Aquí está la diferencia: copia profunda también copia esto...
        public Identificacion Id;

        // Este método podría ser el Clone de ICloneable
        public Persona CopiaSuperficial()
        {
            return (Persona)MemberwiseClone();
        }

        // Y este método también podría ser el Clone de ICloneable
        public Persona CopiaProfunda()
        {
            Persona otra = (Persona)MemberwiseClone();

            // ...aquí
            otra.Id = new Identificacion(Id.Id);
            
            otra.Nombre = string.Copy(Nombre);
            return otra;
        }
    }
}
