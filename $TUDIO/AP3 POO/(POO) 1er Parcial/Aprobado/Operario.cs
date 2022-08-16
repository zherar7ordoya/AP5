namespace PrimerParcialPOO
{
    class Operario : Empleado
    {
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Operario() { }
        /// <summary>
        /// Constructor con parametros heredados de Empleado
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sueldo"></param>
        public Operario(int legajo, string nombre, string apellido, decimal sueldo) : base(legajo, nombre, apellido, sueldo)
        {

        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Operario() { }
    }
}
