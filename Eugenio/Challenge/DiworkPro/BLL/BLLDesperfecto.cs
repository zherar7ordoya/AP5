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
    public class BLLDesperfecto : IGestor<Desperfecto>
    {
        MPPDesperfecto mppdesperfecto;
        public BLLDesperfecto() 
        {
            mppdesperfecto = new MPPDesperfecto();
        }

        public bool Borrar(Desperfecto Objeto)
        {
            return mppdesperfecto.Borrar(Objeto);
        }

        public bool Guardar(Desperfecto Objeto)
        {
            return mppdesperfecto.Guardar(Objeto);
        }

        public List<Desperfecto> ListarTodo()
        {
            return mppdesperfecto.ListarTodo();
        }

        public bool Modificar(Desperfecto Objeto)
        {
            return mppdesperfecto.Guardar(Objeto);
        }
    }
}
