namespace GCLibrary;

/// <summary>
/// Representa una persona.
/// </summary>
/// <remarks>
/// En inglés => PersonModel
/// </remarks>
public class PersonaModel
{
    /// <summary>
    /// Nombre de la persona.
    /// </summary>
    /// <remarks>
    /// En inglés => FirstName
    /// </remarks>
    public string? Nombre { get; set; }

    /// <summary>
    /// Apellido de la persona.
    /// </summary>
    /// <remarks>
    /// En inglés => LastName
    /// </remarks>
    public string? Apellido { get; set; }

    /// <summary>
    /// El correo electrónico de la persona.
    /// </summary>
    /// <remarks>
    /// En inglés => EmailAddress
    /// </remarks>
    public string? Email { get; set; }

    /// <summary>
    /// El número de celular de la persona.
    /// </summary>
    /// <remarks>
    /// En inglés => CellphoneNumber
    /// </remarks>
    public string? Celular { get; set; }
}
