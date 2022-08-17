using System.Data.SqlClient;

namespace DALInsumosOficina
{
    public class DALEmpleado
    {
        public int LogIn(string usuario, string contraseña)
        {
            string cadena = DALConector.ObtenerConexionSQL("ConexionConBBDD");
            using (SqlConnection conexion = new SqlConnection(cadena))

            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText =
                        "SELECT ID_Empleado " +
                        "FROM Empleados " +
                        "WHERE Usuario = @usuario AND Contraseña = @contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    int id;
                    conexion.Open();
                    id = (int)comando.ExecuteScalar();
                    if (id > 0)
                    {
                        return id;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}