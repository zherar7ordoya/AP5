using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Categoria : Informacion, ABSTRACTA.IGestor<BE.BE_Categoria>
    {
        readonly MPP.MPP_Categoria MPP_CATEGORIA;
        public BLL_Categoria()
        {
            MPP_CATEGORIA = new MPP.MPP_Categoria();
            Informar();
        }
        public BLL_Categoria(string mensaje = "Soy un constructor huérfano.")
        {
            MPP_CATEGORIA = new MPP.MPP_Categoria();
            System
                .Diagnostics
                .Debug
                .WriteLine(mensaje + "Existo, pero sin uso.");
        }

        //__________________________________________________IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Categoria categoria)
        {
            return MPP_CATEGORIA.Eliminar(categoria);
        }


        public bool Guardar(BE_Categoria categoria)
        {
            return MPP_CATEGORIA.Guardar(categoria);
        }


        public BE_Categoria ListarObjeto(BE_Categoria objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Categoria> ListarTodo()
        {
            return MPP_CATEGORIA.ListarTodo();
        }

        //*********************************************************************

        public override void Informar()
        {
            System
                .Diagnostics
                .Debug
                .WriteLine(
                "Soy la clase CATEGORÍA " +
                "y soy la elite de la aplicación .");
        }
    }
}
