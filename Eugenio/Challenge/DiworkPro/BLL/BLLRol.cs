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
    public class BLLRol
    {
        MPPRol mpprol;
        public BLLRol() 
        {
            mpprol = new MPPRol();
        }
        public bool Borrar(Rol Objeto)
        {
            return mpprol.Borrar(Objeto);
        }

        public bool Guardar(Rol Objeto)
        {
            return mpprol.Guardar(Objeto);
        }

        public List<Rol> ListarTodo()
        {
            return mpprol.ListarTodo();
        }

        public bool Modificar(Rol Objeto)
        {
            return mpprol.Guardar(Objeto);
        }
    }
}
