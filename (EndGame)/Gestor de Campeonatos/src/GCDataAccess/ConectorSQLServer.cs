using Dapper;
using GCModels;
using System.Data;
using System.Data.SqlClient;

namespace GCDataAccess
{
    public class ConectorSQLServer : IConexion
    {
        /// <summary>
        /// Guarda un nuevo premio en la base de datos
        /// </summary>
        /// <param name="modelo">Información sobre el premio</param>
        /// <returns>La información sobre el premio incluyendo la PK</returns>
        public PremioModel CrearPremio(PremioModel modelo)
        {
            using (IDbConnection conexion = new SqlConnection(ConfiguracionGlobal.CnnString("ConexionSQLServer")))
            {
                DynamicParameters premio = new DynamicParameters();
                premio.Add("@premio_id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                premio.Add("@puesto", modelo.Puesto);
                premio.Add("@nombre", modelo.Nombre);
                premio.Add("@monto", modelo.Monto);
                premio.Add("@porcentaje", modelo.Porcentaje);

                conexion.Execute("dbo.Premios_Insert", premio, commandType: CommandType.StoredProcedure);
                modelo.PremioID = premio.Get<int>("@premio_id");
                return modelo;
            }
        }
    }
}
