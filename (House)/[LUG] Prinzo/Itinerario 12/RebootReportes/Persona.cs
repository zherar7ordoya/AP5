using System;

namespace RebootReportes
{
    class Persona
    {
        public Persona()
        {
        }

        public Persona(int codigo, string nombre, string apellido, double sueldo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Sueldo = sueldo;
        }

        public Persona(int cod, string nombre, string apellido, int dni, string correo, DateTime nacimiento)
        {
            Codigo = cod;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            DNI = dni;
            Correo = correo ?? throw new ArgumentNullException(nameof(correo));
            FechaNac = nacimiento;
        }

        public int      Codigo      { get; set; }
        public string   Nombre   { get; set; }
        public string   Apellido { get; set; }
        public int      DNI      { get; set; }
        public string   Correo   { get; set; }
        public DateTime FechaNac { get; set; }
        public double Sueldo { get; set; }
    }
}
