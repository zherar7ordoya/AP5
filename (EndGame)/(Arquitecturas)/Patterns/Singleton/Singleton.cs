using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instancia;
        private string nombre;
        private int edad;

        private Singleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static Singleton ObtenInstancia()
        {
            if (instancia == null) instancia = new Singleton();
            Console.WriteLine("Instancia creada.");
            return instancia;
        }

        public override string ToString()
        {
            return string.Format("Persona {0} tiene {1} años", nombre, edad);
        }

        public void PonerDatos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void AlgunProceso()
        {
            Console.WriteLine("{0} está trabajando en algo.", nombre);
        }
    }
}
