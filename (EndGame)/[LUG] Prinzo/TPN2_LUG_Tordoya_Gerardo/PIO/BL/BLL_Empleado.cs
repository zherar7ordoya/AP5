using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Empleado : ABSTRACTA.IGestor<BE.BE_Empleado>
    {
        readonly MPP.MPP_Empleado MPP_EMPLEADO;
        public BLL_Empleado() => MPP_EMPLEADO = new MPP.MPP_Empleado();

        //__________________________________________________IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Empleado empleado)
        {
            return MPP_EMPLEADO.Eliminar(empleado);
        }


        public bool Guardar(BE_Empleado empleado)
        {
            return MPP_EMPLEADO.Guardar(empleado);
        }


        public BE_Empleado ListarObjeto(BE_Empleado objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Empleado> ListarTodo()
        {
            return MPP_EMPLEADO.ListarTodo();
        }

        //...................................................................||

    }
}
