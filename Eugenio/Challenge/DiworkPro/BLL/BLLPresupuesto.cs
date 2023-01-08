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
    public class BLLPresupuesto : IGestor<Presupuesto>
    {
        MPPPresupuesto mpppresupuesto;
        public BLLPresupuesto() 
        {
            mpppresupuesto = new MPPPresupuesto();
        }
        public bool Borrar(Presupuesto Objeto)
        {
            return mpppresupuesto.Borrar(Objeto);
        }

        public bool Guardar(Presupuesto Objeto)
        {
            return mpppresupuesto.Guardar(Objeto);
        }

        public List<Presupuesto> ListarTodo()
        {
            return mpppresupuesto.ListarTodo();
        }

        public bool Modificar(Presupuesto Objeto)
        {
            return mpppresupuesto.Guardar(Objeto);
        }
    }
}
