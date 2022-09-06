using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;


namespace OSOBLL
{
    public class DALProductCatalog
    {
        SqlConnection conn;
        DataSet dsProducts;

        public DALProductCatalog()
        {
            string connString = DALUtility.GetSQLConnection();
            conn = new SqlConnection(connString);
        }
        public DataSet GetProductInfo()
        {
            try
            {
                //Get category info 
                String strSQL = "Select CatId, Name, Description from Category";
                SqlCommand cmdSelCategory = new SqlCommand(strSQL, conn);
                SqlDataAdapter daCatagory = new SqlDataAdapter(cmdSelCategory);
                dsProducts = new DataSet("Products");
                daCatagory.Fill(dsProducts, "Category");
                //Get product info 
                String strSQL2 = "Select ProductID, CatID, Name," +
                    "Description, UnitCost from Product";
                SqlCommand cmdSelProduct = new SqlCommand(strSQL2, conn);
                SqlDataAdapter daProduct = new SqlDataAdapter(cmdSelProduct);
                daProduct.Fill(dsProducts, "Product");
                //Set up the table relation 
                DataRelation drCat_Prod = new DataRelation("drCat Prod",
                     dsProducts.Tables["Category"].Columns["CatID"],
                     dsProducts.Tables["Product"].Columns["CatID"], false);
                dsProducts.Relations.Add(drCat_Prod);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return dsProducts;
        }

    }
}