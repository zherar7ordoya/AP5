using System.Collections.Generic;

namespace ABSTRACTA
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T objeto);
        bool Remover(T objeto);
        T DetallarObjeto(T objeto);
        List<T> RecopilarObjetos();
    }
}
