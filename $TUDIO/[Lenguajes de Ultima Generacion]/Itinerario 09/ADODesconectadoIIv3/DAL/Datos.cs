using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Datos
    {
        SqlConnection cnn = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=Ejemplos_LUG;
            Integrated Security=True");
    

        public void AbrirCnn()
        {
            try
            {
                cnn = new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;
                    Initial Catalog=Ejemplos_LUG;
                    Integrated Security=True ");
                cnn.Open();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void CerrarCnn()
        {
            try
            {
                cnn.Close();
                cnn = null;
                GC.Collect();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public DataSet Leer(string consulta)
        {
            DataSet Ds = new DataSet();
            try
            {
                // creo el data adapter y lleno el DataSet
                SqlDataAdapter Da = new SqlDataAdapter(consulta, cnn);
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return Ds;
        }
    }
}
