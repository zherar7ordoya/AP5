using System.Collections.Generic;

namespace _5__D_
{
    interface IAuditable
    {
        IEnumerable<Producto> ObtenerProductos(int tipo);
    }
}
