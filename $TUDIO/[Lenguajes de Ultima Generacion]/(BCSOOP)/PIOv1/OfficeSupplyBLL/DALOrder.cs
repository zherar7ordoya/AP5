using System;
using System.Data;
using System.Data.SqlClient;

namespace OfficeSupplyBLL
{
    class DALOrder
    {
        public int PlaceOrder(string xmlOrder)
        {
            string connString = DALUtility.GetSQLConnection("OSConnection");
            using (SqlConnection cn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "up_PlaceOrder";
                    SqlParameter inParameter = new SqlParameter();
                    inParameter.ParameterName = "@xmlOrder";
                    inParameter.Value = xmlOrder;
                    inParameter.DbType = DbType.String;
                    inParameter.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(inParameter);
                    SqlParameter ReturnParameter = new SqlParameter();
                    ReturnParameter.ParameterName = "@OrderID";
                    ReturnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(ReturnParameter);
                    int intOrderNo;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    intOrderNo = (int)cmd.Parameters["@OrderID"].Value;
                    return intOrderNo;
                }
            }
        }
    }
}