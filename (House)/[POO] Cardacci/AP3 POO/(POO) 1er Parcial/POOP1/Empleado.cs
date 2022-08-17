namespace PrimerParcialPOO
{
    abstract class Empleado
    {
        public int Legajo { get; set; } //Propiedad del legajo del empleado
        public string Nombre { get; set; } //Propiedad del nombre del empleado
        public string Apellido { get; set; } //Propiedad del apellido del empleado
        public decimal Sueldo { get; set; } //Propiedad del sueldo del empleado
        /// <summary>
        /// Costructor sin parametros
        /// </summary>
        public Empleado() { }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sueldo"></param>
        public Empleado(int legajo, string nombre, string apellido, decimal sueldo) : this()
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Sueldo = sueldo;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Empleado() { }
    }
}
