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
    public class BLLRepuesto : IGestor<Repuesto>
    {
        MPPRepuesto mpprepuesto;
        public BLLRepuesto() 
        {
            mpprepuesto = new MPPRepuesto();   
        }
        public bool Borrar(Repuesto Objeto)
        {
            return mpprepuesto.Borrar(Objeto);
        }

        public bool Guardar(Repuesto Objeto)
        {
            return mpprepuesto.Guardar(Objeto);
        }

        public List<Repuesto> ListarTodo()
        {
            return mpprepuesto.ListarTodo();
        }

        public bool Modificar(Repuesto Objeto)
        {
            return mpprepuesto.Guardar(Objeto);
        }
    }
}
