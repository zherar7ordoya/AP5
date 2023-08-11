namespace PrimerParcialPOO
{
    class Administrativo : Empleado
    {
       /// <summary>
       /// Constructor sin parametros
       /// </summary>
        public Administrativo() { }
        /// <summary>
        /// Constructor con parametros heredados de Empleado
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sueldo"></param>
        public Administrativo(int legajo, string nombre, string apellido, decimal sueldo) : base(legajo, nombre, apellido, sueldo)
        {
            
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Administrativo()
        {

        }
    }
}
