using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Proveedor : ABSTRACTA.IGestor<BE.BE_Proveedor>
    {
        readonly MPP.MPP_Proveedor MPP_PROVEEDOR;
        public BLL_Proveedor() => MPP_PROVEEDOR = new MPP.MPP_Proveedor();

        //              ▂▃▄▅▆▇█▓▒░ IMPLEMENTA INTERFAZ ░▒▓█▇▆▅▄▃▂

        public bool Eliminar(BE_Proveedor proveedor)
        {
            return MPP_PROVEEDOR.Eliminar(proveedor);
        }


        public bool Guardar(BE_Proveedor proveedor)
        {
            return MPP_PROVEEDOR.Guardar(proveedor);
        }


        public BE_Proveedor ListarObjeto(BE_Proveedor objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Proveedor> ListarTodo()
        {
            return MPP_PROVEEDOR.ListarTodo();
        }

        // •°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•

    }
}
