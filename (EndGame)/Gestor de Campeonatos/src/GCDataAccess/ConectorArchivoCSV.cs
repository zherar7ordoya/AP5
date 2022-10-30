using GCModels;
using GCDataAccess.ProcesadorCSV;
using System.Collections.Generic;
using System.Linq;

namespace GCDataAccess
{
    public class ConectorArchivoCSV : IConexion
    {
        private const string PremiosArchivo = "Premios.csv";
        /// <summary>
        /// Guarda un nuevo premio en el archivo CSV
        /// </summary>
        /// <param name="modelo">Información sobre el premio</param>
        /// <returns>La información sobre el premio incluyendo el ID</returns>
        public PremioModel CrearPremio(PremioModel modelo)
        {
            // Cargo el archivo y convierto el archivo a List<PremioModel>
            List<PremioModel> premios = PremiosArchivo.ArchivoPath().CargarArchivo().ConvertirEnPremioModel();

            // Encuentro el máximo ID y agrego el nuevo registro con un nuevo ID (máximo + 1)
            int SiguienteID = premios.OrderByDescending(x => x.PremioID).First().PremioID + 1;
            modelo.PremioID = SiguienteID;
            premios.Add(modelo);

            // Convierto los premios a List<string> y guardo la List<string> al archivo CSV
            premios.GuardarArchivoPremios(PremiosArchivo);

            return modelo;
        }
    }
}
