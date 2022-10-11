namespace GCLibrary;

/// <summary>
/// Representa el premio para un puesto dado.
/// </summary>
/// <remarks>
/// En inglés => PrizeModel
/// </remarks>
public class PremioModel
{
    /// <summary>
    /// El identificador numérico del puesto (por ej.: 1 para el primer puesto).
    /// </summary>
    /// <remarks>
    /// En inglés => PlaceNumber
    /// </remarks>
    public int PuestoNumero { get; set; } = new int();

    /// <summary>
    /// Nombre textual del puesto (por ej.: "Primer Puesto").
    /// </summary>
    /// <remarks>
    /// En inglés => PlaceName
    /// </remarks>
    public string? PuestoNombre { get; set; }

    /// <summary>
    /// El monto fijo monetario para este puesto (cero si no se usa).
    /// </summary>
    /// <remarks>
    /// En inglés => PrizeAmount
    /// </remarks>
    public decimal PremioMonto { get; set; } = new decimal();

    /// <summary>
    /// El porcentaje (monetario) de los ingresos totales (cero si no se usa).
    /// </summary>
    /// <remarks>
    /// En inglés => PrizePercentage
    /// </remarks>
    public double PremioPorcentaje { get; set; } = new double();
}