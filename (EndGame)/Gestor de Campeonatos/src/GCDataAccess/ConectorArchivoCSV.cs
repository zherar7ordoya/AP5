using GCModels;
using GCDataAccess.ProcesadorCSV;
using System.Collections.Generic;
using System.Linq;

namespace GCDataAccess
{
    public class ConectorArchivoCSV : IConexion
    {

        // ┌── EMPIEZA NOMBRES ARCHIVOS CSV ───────────────────────────────────┐
        private const string ArchivoCampeonatos = "Campeonatos.csv";
        private const string ArchivoEquipos = "Equipos.csv";
        private const string ArchivoPartidoJugadores = "PartidoJugadores.csv";
        private const string ArchivoPartidos = "Partidos.csv";
        private const string ArchivoPersonas = "Personas.csv";
        private const string ArchivoPremios = "Premios.csv";
        // └── TERMINA NOMBRES ARCHIVOS CSV ───────────────────────────────────┘
        

        /// <summary>
        /// Guarda un nuevo premio en el archivo CSV
        /// </summary>
        /// <param name="modelo">Información sobre el premio</param>
        /// <returns>La información sobre el premio incluyendo el ID</returns>

        public PremioModel CrearPremio(PremioModel modelo)
        {
            // Cargo el archivo y convierto el archivo a List<PremioModel>
            List<PremioModel> premios = ArchivoPremios.ArchivoPath().ConvertirArchivoTextoEnListaString().ConvertirListaStringEnListaPremioModel();

            // Encuentro el máximo ID y agrego el nuevo registro con un nuevo ID (máximo + 1)

            if (premios.Count > 0)  // Si ya hay premios en el archivo CSV
            {
                modelo.PremioID = premios.OrderByDescending(x => x.PremioID).First().PremioID + 1;
            }
            else  // Si aún no hay premios en el archivo CSV
            {
                modelo.PremioID = 1;
            }
            premios.Add(modelo);

            // Convierto los premios a List<string> y guardo la List<string> al archivo CSV
            premios.GuardarArchivoPremios(ArchivoPremios);

            return modelo;
        }
    }
}
