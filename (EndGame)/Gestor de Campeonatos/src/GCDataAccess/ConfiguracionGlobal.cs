using System.Collections.Generic;
using System.Configuration;

namespace GCDataAccess
{
    public static class ConfiguracionGlobal
    {
        public static IConexion Conexion { get; private set; }
        
        public static void IniciarConexion(DatastoreType tipo)
        {
            switch (tipo)
            {
                case DatastoreType.SQLServer:
                    Conexion = new ConectorSQLServer();
                    break;
                case DatastoreType.ArchivoCSV:
                    Conexion = new ConectorArchivoCSV();
                    break;
                default:
                    break;
            }
        }

        public static string CnnString(string nombre)
        {
            return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
        }
    }
}
