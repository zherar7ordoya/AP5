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
    public class BLLMoto : IGestor<Moto>
    {
        MPPMoto mppmoto;
        public BLLMoto()
        {
            mppmoto = new MPPMoto();
        }
        public bool Borrar(Moto Objeto)
        {
            return mppmoto.Borrar(Objeto);
        }

        public bool Guardar(Moto Objeto)
        {
            return mppmoto.Guardar(Objeto);
        }

        public List<Moto> ListarTodo()
        {
            return mppmoto.ListarTodo();
        }

        public bool Modificar(Moto Objeto)
        {
            return mppmoto.Guardar(Objeto);
        }
    }
}
