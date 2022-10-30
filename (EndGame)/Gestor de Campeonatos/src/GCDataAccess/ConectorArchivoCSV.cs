using GCModels;

namespace GCDataAccess
{
    public class ConectorArchivoCSV : IConexion
    {
        /// <summary>
        /// Guarda un nuevo premio en el archivo CSV
        /// </summary>
        /// <param name="modelo">Información sobre el premio</param>
        /// <returns>La información sobre el premio incluyendo el ID</returns>
        public PremioModel CrearPremio(PremioModel modelo)
        {
            // Cargo el archivo
            // Convierto el archivo a List<PremioModel>
            // Encuentro el máximo ID
            // Agrego el nuevo registro con un nuevo ID (máximo + 1)
            // Convierto los premios a List<string>
            // Guardo la List<string> al archivo CSV
        }
    }
}
