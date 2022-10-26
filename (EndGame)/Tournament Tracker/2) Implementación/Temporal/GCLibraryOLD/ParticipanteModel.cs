namespace GCLibrary
{
    /// <summary>
    /// Representa un participante en un campeonato.
    /// </summary>
    /// <remarks>
    /// En inglés => MatchupEntryModel
    /// </remarks>
    public class ParticipanteModel
    {
        /// <summary>
        /// Representa un participante en un partido.
        /// </summary>
        /// <remarks>
        /// En inglés => TeamModel
        /// </remarks>
        public EquipoModel Equipo { get; set; } = new EquipoModel();

        /// <summary>
        /// Representa el puntaje de un participante en un partido.
        /// </summary>
        /// <remarks>
        /// En inglés => Score
        /// </remarks>
        public double Puntaje { get; set; } = new double();

        /// <summary>
        /// Representa el partido del que vino este equipo como ganador.
        /// </summary>
        /// <remarks>
        /// En inglés => MatchupModel
        /// </remarks>
        public PartidoModel PartidoAnterior { get; set; } = new PartidoModel();
    }
}