using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
