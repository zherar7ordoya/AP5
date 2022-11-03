using System.Collections.Generic;

namespace BEL
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetProducts();
        bool Insert(Producto product);
        bool Update(Producto product);
        bool Delete(string ProductID);
    }
}
