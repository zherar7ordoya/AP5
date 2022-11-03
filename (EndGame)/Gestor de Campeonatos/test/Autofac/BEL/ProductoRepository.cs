using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace BEL
{
    public class ProductoRepository : IProductoRepository
    {
        public bool Delete(string ProductID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetProducts()
        {
            IDbConnection db = null;
            try
            {
                db = new SqlConnection(ConexionSQLServer.ConnectionString);
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return db.Query<Producto>(
                    $"SELECT ProductID, ProductName, UnitPrice, UnitsInStock " +
                    $"FROM Products",
                    commandType: CommandType.Text);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (db != null)
                {
                    db.Close();
                    db.Dispose();
                }
            }




            throw new NotImplementedException();
        }

        public bool Insert(Producto product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto product)
        {
            throw new NotImplementedException();
        }
    }
}
