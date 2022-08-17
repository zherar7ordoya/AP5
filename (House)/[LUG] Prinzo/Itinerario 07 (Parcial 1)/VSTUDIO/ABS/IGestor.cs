using System.Collections.Generic;

namespace ABS
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T objeto);
        bool Eliminar(T objeto);
        T Detallar(T objeto);
        List<T> Listar();
    }
}
