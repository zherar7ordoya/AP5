using System.Collections.Generic;

namespace ABSTRACTA
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T objeto);
        bool Eliminar(T objeto);
        T ListarObjeto(T objeto);
        List<T> ListarTodo();
    }
}
