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
    public class BLLAutomovil : IGestor<Automovil>
    {
        MPPAutomovil mppautomovil;
        public BLLAutomovil() 
        {
            mppautomovil = new MPPAutomovil();
        }

        public bool Borrar(Automovil Objeto)
        {
            return mppautomovil.Borrar(Objeto);
        }

        public bool Guardar(Automovil Objeto)
        {
            return mppautomovil.Guardar(Objeto);
        }

        public List<Automovil> ListarTodo()
        {
            return mppautomovil.ListarTodo();
        }

        public bool Modificar(Automovil Objeto)
        {
            return mppautomovil.Guardar(Objeto);
        }
    }
}
