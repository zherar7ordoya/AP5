using System.Collections.Generic;

namespace Abstraccion
{
    public interface IGestor<T> where T :IEntidad
    {
        bool Guardar(T Objeto);
        bool Baja(T Objeto);

        List<T> ListarTodo();
        T ListarObjeto(T Objeto);
    }
}
