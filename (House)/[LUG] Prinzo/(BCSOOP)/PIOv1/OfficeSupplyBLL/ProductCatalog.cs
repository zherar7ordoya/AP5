using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSupplyBLL
{
    public class ProductCatalog
    {
        public DataSet GetProductInfo()
        {
            //perform any business logic befor passing to client.
            // None needed at this time.
            DALProductCatalog prodCatalog = new DALProductCatalog();
            return prodCatalog.GetProductInfo();
        }
    }
}