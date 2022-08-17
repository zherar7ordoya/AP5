using System.Data;
using DALInsumosOficina;

namespace BLLInsumosOficina
{
    public class BLLCatalogo
    {
        public DataSet ObtenerInfoProducto()
        {
            DALCatalogo catalogo = new DALCatalogo();
            return catalogo.ObtenerInfoProducto();
        }
    }
}