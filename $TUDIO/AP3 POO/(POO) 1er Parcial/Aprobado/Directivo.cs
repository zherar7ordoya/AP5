namespace PrimerParcialPOO
{
    class Directivo : Empleado
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Directivo() { }
        /// <summary>
        /// Constructor con parametros heredados de Empleado
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sueldo"></param>
        public Directivo(int legajo, string nombre, string apellido, decimal sueldo) :base(legajo, nombre, apellido, sueldo)
        {

        }
        /// <summary>
        /// Ddestructor
        /// </summary>
        ~Directivo()
        {

        }
    }
}
