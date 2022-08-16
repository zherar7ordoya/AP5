using System.Data;
using System.Data.SqlClient;

namespace DALInsumosOficina
{
    public class DALOrden
    {
        public int RealizarPedido(string xml)
        {
            string cadena = DALConector.ObtenerConexionSQL("ConexionConBBDD");
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "RealizarPedido";
                    SqlParameter parametro = new SqlParameter
                    {
                        ParameterName = "@xml",
                        Value = xml,
                        DbType = DbType.String,
                        Direction = ParameterDirection.Input
                    };
                    comando.Parameters.Add(parametro);
                    SqlParameter respuesta = new SqlParameter
                    {
                        ParameterName = "@id",
                        Direction = ParameterDirection.ReturnValue
                    };
                    comando.Parameters.Add(respuesta);

                    int id;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    id = (int)comando.Parameters["@id"].Value;
                    return id;
                }
            }
        }
    }
}