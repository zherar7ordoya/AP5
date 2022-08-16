using System.Collections.Generic;

namespace BLL
{
    public class BLL_Cliente : Abstraccion.IGestor<BE.BE_Cliente>
    {
        //defino el objeto del mapper usuario
        readonly MPP.MPP_Cliente cliente;


        public BLL_Cliente()
        {   //lo instancio en el constructor de la BLL
            cliente = new MPP.MPP_Cliente();
        }


        public List<BE.BE_Cliente> ListarTodo()
        {
            return cliente.ListarTodo();
        }


        public bool Guardar(BE.BE_Cliente _cliente)
        {
            return cliente.Guardar(_cliente);
        }


        public bool Eliminar(BE.BE_Cliente _cliente)
        {
            return cliente.Eliminar(_cliente);
        }


        public List<BE.BE_Cliente> BuscarClienteXApellido(BE.BE_Cliente _cliente)
        {
            return cliente.BuscarClienteXApellido(_cliente);
        }


        public BE.BE_Cliente ListarObjeto(BE.BE_Cliente _cliente)
        {
            throw new System.NotImplementedException();
        }


    }
}
