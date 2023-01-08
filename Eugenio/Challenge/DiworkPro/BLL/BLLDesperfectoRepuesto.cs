using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using BE;
using MAPPER;

namespace BLL
{
    public class BLLDesperfectoRepuesto : IGestor<DesperfectoRepuesto>
    {
        MPPDesperfectoRepuesto mppdr;
        public BLLDesperfectoRepuesto()
        {
            mppdr = new MPPDesperfectoRepuesto();
        }

        public bool Borrar(DesperfectoRepuesto Objeto)
        {
            return mppdr.Borrar(Objeto);
        }

        public bool Guardar(DesperfectoRepuesto Objeto)
        {
            return mppdr.Guardar(Objeto);
        }

        public List<DesperfectoRepuesto> ListarTodo()
        {
            return mppdr.ListarTodo();
        }

        public bool Modificar(DesperfectoRepuesto Objeto)
        {
            return mppdr.Guardar(Objeto);
        }
    }
}
