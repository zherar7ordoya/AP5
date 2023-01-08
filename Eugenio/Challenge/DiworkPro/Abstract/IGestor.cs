using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T Objeto);
        bool Borrar(T Objeto);
        bool Modificar (T Objeto);
        List<T> ListarTodo();
    }
}
