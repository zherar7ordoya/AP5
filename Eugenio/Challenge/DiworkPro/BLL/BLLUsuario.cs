using Abstract;
using BE;
using MAPPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario 
    {
        MPPUsuario mppusuario;
        public BLLUsuario() 
        {
            mppusuario = new MPPUsuario();
        }
        public bool Borrar(Usuario Objeto)
        {
            return mppusuario.Borrar(Objeto);
        }

        public bool Guardar(Usuario Objeto)
        {
            return mppusuario.Guardar(Objeto);
        }

        public List<Usuario> ListarTodo()
        {
            return mppusuario.ListarTodo();
        }

        public bool Modificar(Usuario Objeto)
        {
            return mppusuario.Guardar(Objeto);
        }
    }
}
