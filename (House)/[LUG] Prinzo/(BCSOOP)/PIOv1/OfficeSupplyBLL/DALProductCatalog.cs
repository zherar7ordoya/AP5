using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSupplyBLL
{
    public class DALProductCatalog
    {
        public DataSet GetProductInfo()
        {
            DataSet _dsProducts;
            string connString = DALUtility.GetSQLConnection("OSConnection");
            using (SqlConnection _conn = new SqlConnection(connString))
            {
                _dsProducts = new DataSet("Products");
                //Get category info
                String strSQL = "Select CategoryId, Name, Description from Category";
                using (SqlCommand cmdSelCategory = new SqlCommand(strSQL, _conn))
                {
                    using (SqlDataAdapter daCatagory = new SqlDataAdapter(cmdSelCategory))
                    {
                        daCatagory.Fill(_dsProducts, "Category");
                    }
                }

                //Get product info
                String strSQL2 = "Select ProductID, CategoryID, Name," +
                    "Description, UnitCost from Product";
                using (SqlCommand cmdSelProduct = new SqlCommand(strSQL2, _conn))
                {
                    using (SqlDataAdapter daProduct = new SqlDataAdapter(cmdSelProduct))
                    {
                        daProduct.Fill(_dsProducts, "Product");
                    }
                }
            }
            //Set up the table relation
            DataRelation drCat_Prod = new DataRelation("drCat_Prod",
                _dsProducts.Tables["Category"].Columns["CategoryID"],
                _dsProducts.Tables["Product"].Columns["CategoryID"], false);
            _dsProducts.Relations.Add(drCat_Prod);
            return _dsProducts;
        }
    }
}