using System.Configuration;

namespace DALInsumosOficina
{
    public static class DALConector
    {
        public static string ObtenerConexionSQL(string nombre)
        {
            string respuesta = null;
            ConnectionStringSettings configuracion = ConfigurationManager.ConnectionStrings[nombre];

            if (configuracion != null)
            {
                respuesta = configuracion.ConnectionString;
            }
            return respuesta;
        }
    }
}
