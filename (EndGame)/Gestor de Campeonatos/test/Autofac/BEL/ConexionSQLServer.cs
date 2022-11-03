using System.Configuration;

namespace BEL
{
    public class ConexionSQLServer
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
