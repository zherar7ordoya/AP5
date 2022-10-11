namespace GCLibrary;

/// <summary>
/// Equipo de un campeonato.
/// </summary>
/// <remarks>
/// En inglés => TeamModel
/// </remarks>
public class EquipoModel
{
    /// <summary>
    /// Personas que integran el equipo.
    /// </summary>
    /// <remarks>
    /// En inglés => TeamMembers
    /// </remarks>
    public List<PersonaModel> Miembros { get; set; } = new List<PersonaModel>();

    /// <summary>
    /// El nombre del equipo.
    /// </summary>
    /// <remarks>
    /// En inglés => TeamName
    /// </remarks>
    public string? Nombre { get; set; }
}
