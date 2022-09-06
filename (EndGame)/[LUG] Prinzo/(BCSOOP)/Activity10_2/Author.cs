using System;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_2
{
    public class Author
    {
        readonly string _connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=pubs;
            Integrated Security=True";


        public DataSet GetData()
        {
            DataSet authorDataSet;

            SqlConnection pubConnection = new SqlConnection
            {
                ConnectionString = _connString
            };

            SqlCommand selectCommand = new SqlCommand
            {
                CommandText =
                        "SELECT au_id, au_lname, au_fname " +
                        "FROM authors",
                Connection = pubConnection
            };

            try
            {
                SqlDataAdapter pubDataAdapter = new SqlDataAdapter
                {
                    SelectCommand = selectCommand
                };
                authorDataSet = new DataSet();
                pubDataAdapter.Fill(authorDataSet, "Author");
                return authorDataSet;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { pubConnection.Close(); }
        }



        public void UpdateData(DataSet changedData)
        {
            SqlConnection pubConnection = new SqlConnection
            {
                ConnectionString = _connString
            };

            SqlCommand updateCommand = new SqlCommand
            {
                CommandText =
                "UPDATE authors " +
                "SET au_lname = @au_lname, au_fname = @au_fname " +
                "WHERE au_id = @au_id"
            };

            updateCommand.Parameters.Add("@au_id", SqlDbType.VarChar, 11, "au_id");
            updateCommand.Parameters.Add("@au_lname", SqlDbType.VarChar, 40, "au_lname");
            updateCommand.Parameters.Add("@au_fname", SqlDbType.VarChar, 40, "au_fname");
            updateCommand.Connection = pubConnection;

            try
            {
                SqlDataAdapter pubDataAdapter = new SqlDataAdapter
                {
                    UpdateCommand = updateCommand
                };
                pubDataAdapter.Update(changedData, "Author");
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { pubConnection.Close(); }
        }


    }
}
