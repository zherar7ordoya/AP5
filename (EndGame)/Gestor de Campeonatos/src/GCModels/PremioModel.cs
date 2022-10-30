namespace GCModels
{
    /// <summary>
    /// Representa el premio para un puesto dado.
    /// </summary>
    /// <remarks>
    /// En inglés => PrizeModel
    /// </remarks>
    public class PremioModel
    {
        /// <summary>
        /// La PK para el premio.
        /// </summary>
        public int PremioID { get; set; }

        /// <summary>
        /// El identificador numérico del puesto (por ej.: 1 para el primer puesto).
        /// </summary>
        /// <remarks>
        /// En inglés => PlaceNumber
        /// </remarks>
        public int Puesto { get; set; } = new int();

        /// <summary>
        /// Nombre textual del puesto (por ej.: "Primer Puesto").
        /// </summary>
        /// <remarks>
        /// En inglés => PlaceName
        /// </remarks>
        public string Nombre { get; set; }

        /// <summary>
        /// El monto fijo monetario para este puesto (cero si no se usa).
        /// </summary>
        /// <remarks>
        /// En inglés => PrizeAmount
        /// </remarks>
        public decimal Monto { get; set; } = new decimal();

        /// <summary>
        /// El porcentaje (monetario) de los ingresos totales (cero si no se usa).
        /// </summary>
        /// <remarks>
        /// En inglés => PrizePercentage
        /// </remarks>
        public double Porcentaje { get; set; } = new double();


        // --- CONSTRUCTORES ---------------------------------------------------
        public PremioModel()
        {
            ;
        }

        public PremioModel(string puesto, string nombre, string monto, string porcentaje)
        {
            Puesto = int.Parse(puesto);
            Nombre = nombre;
            Monto = decimal.Parse(monto);
            Porcentaje = double.Parse(porcentaje);
        }
    }
}
