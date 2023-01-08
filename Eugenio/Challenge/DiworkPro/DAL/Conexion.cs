using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class Conexion
    {
        private SqlConnection oCnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Presupuestador;Integrated Security=True");
        string CadeCon = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Presupuestador;Integrated Security=True";

        SqlTransaction Transac;
        SqlCommand cmd;

        public bool EscribirGenerico(string ConsultaSql, Hashtable hash)
        {
            if (oCnn.State == ConnectionState.Closed)
            {
                oCnn.ConnectionString = CadeCon;
                oCnn.Open();
            }
            try
            {
                Transac = oCnn.BeginTransaction();
                cmd = new SqlCommand(ConsultaSql, oCnn, Transac);
                cmd.CommandType = CommandType.StoredProcedure;
                if (hash != null)
                {
                    foreach (string item in hash.Keys)
                    {
                        cmd.Parameters.AddWithValue(item, hash[item]);
                    }
                }
                int respuesta = cmd.ExecuteNonQuery();
                Transac.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                Transac.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                Transac.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                oCnn.Close();
            }
        }
        public bool EscribirGenerico(string ConsultaSql, ArrayList arr)
        {
            if (oCnn.State == ConnectionState.Closed)
            {
                oCnn.ConnectionString = CadeCon;
                oCnn.Open();
            }
            try
            {
                Transac = oCnn.BeginTransaction();
                cmd = new SqlCommand(ConsultaSql, oCnn, Transac);
                cmd.CommandType = CommandType.StoredProcedure;
                if (arr != null)
                {
                    foreach (SqlParameter item in arr)
                    {
                        cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                    }
                }
                int respuesta = cmd.ExecuteNonQuery();
                Transac.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                Transac.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                Transac.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                oCnn.Close();
            }
        }
        public DataTable Leer(string ConsultaSql, ArrayList ArList)
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter da;
            cmd = new SqlCommand(ConsultaSql, oCnn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                da = new SqlDataAdapter(cmd);
                if ((ArList != null))
                {

                    foreach (SqlParameter dato in ArList)
                    {

                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            da.Fill(Dt);
            return Dt;
        }
    }
}
