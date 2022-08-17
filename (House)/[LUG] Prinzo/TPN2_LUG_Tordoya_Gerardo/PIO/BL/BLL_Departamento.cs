using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Departamento : ABSTRACTA.IGestor<BE.BE_Departamento>
    {
        readonly MPP.MPP_Departamento MPP_DEPARTAMENTO;
        public BLL_Departamento() => MPP_DEPARTAMENTO = new MPP.MPP_Departamento();

        //__________________________________________________IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Departamento departamento)
        {
            return MPP_DEPARTAMENTO.Eliminar(departamento);
        }


        public bool Guardar(BE_Departamento departamento)
        {
            return MPP_DEPARTAMENTO.Guardar(departamento);
        }


        public BE_Departamento ListarObjeto(BE_Departamento objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Departamento> ListarTodo()
        {
            return MPP_DEPARTAMENTO.ListarTodo();
        }
    }
}
