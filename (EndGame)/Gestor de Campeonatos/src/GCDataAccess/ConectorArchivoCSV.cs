using GCModels;
using GCDataAccess.ProcesadorCSV;
using System.Collections.Generic;
using System.Linq;

namespace GCDataAccess
{
    public class ConectorArchivoCSV : IConexion
    {

        // ┌── EMPIEZA NOMBRES ARCHIVOS CSV ───────────────────────────────────┐
        private const string CampeonatosArchivo = "Campeonatos.csv";
        private const string EquiposArchivo = "Equipos.csv";
        private const string PartidoJugadoresArchivo = "PartidoJugadores.csv";
        private const string PartidosArchivo = "Partidos.csv";
        private const string PersonasArchivo = "Personas.csv";
        private const string PremiosArchivo = "Premios.csv";
        // └── TERMINA NOMBRES ARCHIVOS CSV ───────────────────────────────────┘
        

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
            if (premios.Count > 0)  // Si ya hay premios en el archivo CSV
            {
                modelo.PremioID = premios.OrderByDescending(x => x.PremioID).First().PremioID + 1;
            }
            else                    // Si aún no hay premios en el archivo CSV
            {
                modelo.PremioID = 1;
            }
            premios.Add(modelo);

            // Convierto los premios a List<string> y guardo la List<string> al archivo CSV
            premios.GuardarArchivoPremios(PremiosArchivo);

            return modelo;
        }
    }
}
