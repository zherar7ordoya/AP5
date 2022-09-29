using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Orden : ABSTRACTA.IGestor<BE.BE_Orden>
    {
        readonly MPP.MPP_Orden MPP_ORDEN;
        public BLL_Orden() => MPP_ORDEN = new MPP.MPP_Orden();

        //__________________________________________________IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Orden orden)
        {
            return MPP_ORDEN.Eliminar(orden);
        }


        public bool Guardar(BE_Orden orden)
        {
            return MPP_ORDEN.Guardar(orden);
        }


        public BE_Orden ListarObjeto(BE_Orden objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Orden> ListarTodo()
        {
            return MPP_ORDEN.ListarTodo();
        }

        ///////////////////////////////////////////////////////////////////////

    }
}
