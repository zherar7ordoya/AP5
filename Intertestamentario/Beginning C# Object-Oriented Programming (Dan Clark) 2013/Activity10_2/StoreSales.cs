using System;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_2
{
    public class StoreSales
    {
        readonly string _connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=pubs;
            Integrated Security=True";


        public DataSet GetData()
        {
            DataSet storeSalesDataSet;
            storeSalesDataSet = new DataSet();
            SqlConnection pubConnection = new SqlConnection(_connString);

            try
            {
                //Fill «Store» table
                SqlCommand storeCommand = new SqlCommand
                {
                    Connection = pubConnection,
                    CommandText =
                            "SELECT [stor_id], [stor_name], [city], [state] " +
                            "FROM [stores]"
                };

                SqlDataAdapter storeDataAdapter = new SqlDataAdapter
                {
                    SelectCommand = storeCommand
                };

                storeDataAdapter.Fill(storeSalesDataSet, "Stores");


                //Fill «Sales» table
                SqlCommand salesCommand = new SqlCommand
                {
                    Connection = pubConnection,
                    CommandText =
                            "SELECT [stor_id], [ord_num], [ord_date], [qty] " +
                            "FROM [sales]"
                };

                SqlDataAdapter salesDataAdapter = new SqlDataAdapter
                {
                    SelectCommand = salesCommand
                };

                salesDataAdapter.Fill(storeSalesDataSet, "Sales");


                //Create relationship between tables
                DataColumn Store_StoreIdColumn = storeSalesDataSet.Tables["Stores"].Columns["stor_id"];
                DataColumn Sales_StoreIdColumn = storeSalesDataSet.Tables["Sales"].Columns["stor_id"];
                DataRelation StoreSalesRelation = new DataRelation("StoresToSales", Store_StoreIdColumn, Sales_StoreIdColumn);
                storeSalesDataSet.Relations.Add(StoreSalesRelation);

                return storeSalesDataSet;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { pubConnection.Close(); }
        }




    }
}
