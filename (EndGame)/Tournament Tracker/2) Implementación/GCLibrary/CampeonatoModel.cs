namespace GCLibrary;

/// <summary>
/// Representa un campeonato, con todas las rondas, partidos, premios y resultados.
/// </summary>
/// <remarks>
/// En inglés => TournamentModel
/// </remarks>
public class CampeonatoModel
{
    /// <summary>
    /// El nombre del campeonato.
    /// </summary>
    /// <remarks>
    /// En inglés => TournamentName
    /// </remarks>
    public string? Nombre { get; set; }

    /// <summary>
    /// La cantidad de dinero que cada equipo necesita pagar para participar.
    /// </summary>
    /// <remarks>
    /// En inglés => EntryFee
    /// </remarks>
    public decimal Tarifa { get; set; } = new decimal();

    /// <summary>
    /// El conjunto de equipos que se han inscripto.
    /// </summary>
    /// <remarks>
    /// En inglés => EnteredTeams
    /// </remarks>
    public List<EquipoModel> Inscriptos { get; set; } = new List<EquipoModel>();

    /// <summary>
    /// La lista de premios.
    /// </summary>
    /// <remarks>
    /// En inglés => Prizes
    /// </remarks>
    public List<PremioModel> Premios { get; set; } = new List<PremioModel>();

    /// <summary>
    /// La lista de rondas.
    /// </summary>
    /// <remarks>
    /// En inglés => Rounds
    /// </remarks>
    public List<List<PartidoModel>> Rondas { get; set; } = new List<List<PartidoModel>>();
}
