using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Item : ABSTRACTA.IGestor<BE.BE_Item>
    {
        readonly MPP.MPP_Item MPP_ITEM;
        public BLL_Item() => MPP_ITEM = new MPP.MPP_Item();

        //__________________________________________________IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Item producto)
        {
            return MPP_ITEM.Eliminar(producto);
        }


        public bool Guardar(BE_Item producto)
        {
            return MPP_ITEM.Guardar(producto);
        }


        public BE_Item ListarObjeto(BE_Item objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Item> ListarTodo()
        {
            return MPP_ITEM.ListarTodo();
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

    }
}
