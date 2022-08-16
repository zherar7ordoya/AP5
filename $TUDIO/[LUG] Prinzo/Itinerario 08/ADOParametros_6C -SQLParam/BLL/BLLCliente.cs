using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using MPP;

namespace BLL
{
    public class BLLCliente: IGestor<BECliente>
    {
        //defino el objeto del mapper usuario
        MPPCliente MPPoCliParam;
        public BLLCliente()
        {   //lo instancio en el constructor de la BLL
            MPPoCliParam = new MPPCliente();
        }
        public List<BECliente> ListarTodo()
        {
            return MPPoCliParam.ListarTodo();

        }

        public bool Guardar(BECliente oBECliente)
        {
            return MPPoCliParam.Guardar(oBECliente);

        }

        public bool Baja(BECliente oBECliente)
        {

            return MPPoCliParam.Baja(oBECliente);

        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new System.NotImplementedException();
        }



        public List<BECliente> BuscarClienteXApellido(BECliente oBECliente)
        {
            return MPPoCliParam.BuscarClienteXApellido(oBECliente);

        }
    }
}
