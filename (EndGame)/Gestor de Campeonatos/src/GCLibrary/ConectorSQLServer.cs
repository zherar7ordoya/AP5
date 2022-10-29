namespace GCLibrary
{
    public class ConectorSQLServer : IConexion
    {
        public PremioModel CrearPremio(PremioModel modelo)
        {
            // TODO Guardar el premio en la base de datos
            modelo.PremioID = 1;
            return modelo;
        }
    }
}
