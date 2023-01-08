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
    public class BLLPermisos
    {
        MPPPermisos mpppermisos;
        public BLLPermisos() 
        {
          mpppermisos = new MPPPermisos();
        }
        public bool Borrar(Permisos Objeto)
        {
            return mpppermisos.Borrar(Objeto);
        }

        public bool Guardar(Permisos Objeto)
        {
            return mpppermisos.Guardar(Objeto);
        }

        public List<Permisos> ListarTodo()
        {
            return mpppermisos.ListarTodo();
        }

        public bool Modificar(Permisos Objeto)
        {
            return mpppermisos.Guardar(Objeto);
        }
    }
}
