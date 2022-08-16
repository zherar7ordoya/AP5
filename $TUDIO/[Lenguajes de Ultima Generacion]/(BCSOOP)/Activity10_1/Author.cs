using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_1
{
    public class Author
    {
        readonly string _connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=pubs;
            Integrated Security=True";



        public int CountAuthors()
        {
            SqlConnection pubConnection = new SqlConnection(_connString);

            SqlCommand pubCommand = new SqlCommand
            {
                Connection = pubConnection,
                CommandText = "Select Count(au_id) from authors"
            };

            try
            {
                pubConnection.Open();
                return (int)pubCommand.ExecuteScalar();
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { pubConnection.Dispose(); }
        }


        public List<string> GetAuthorList(int royalty)
        {
            List<string> nameList = new List<string>();

            SqlConnection pubConnection = new SqlConnection(_connString);

            SqlCommand authorsCommand = new SqlCommand
            {
                Connection = pubConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "byroyalty"
            };

            SqlParameter inputParameter = new SqlParameter
            {
                ParameterName = "@percentage",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Value = royalty
            };

            authorsCommand.Parameters.Add(inputParameter);

            try
            {
                pubConnection.Open();
                SqlDataReader authorDataReader = authorsCommand.ExecuteReader();

                while (authorDataReader.Read())
                {
                    nameList.Add(authorDataReader.GetString(0));
                }
                return nameList;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { pubConnection.Dispose(); }
        }



    }
}
