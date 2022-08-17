using System;
using System.Data.SqlClient;
namespace OfficeSupplyBLL
{
    class DALEmployee
    {
        public int LogIn(string username, string password)
        {
            string connString = DALUtility.GetSQLConnection("OSConnection");
            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Select EmployeeID from Employee where "
                         + " UserName = @username and Password = @password ";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int userId;
                    conn.Open();
                    userId = (int)cmd.ExecuteScalar();
                    if (userId > 0)
                    {
                        return userId;
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