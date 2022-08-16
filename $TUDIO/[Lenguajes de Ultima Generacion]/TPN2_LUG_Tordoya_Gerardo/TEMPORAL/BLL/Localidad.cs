using System;
using System.Collections.Generic;


namespace BLL
{
    public class Localidad : Abstraccion.IGestor<BE.Localidad>
    {
        readonly MPP.Localidad localidad;


        //instancio el objeto mapper en el constructor de la clase localidad
        public Localidad()
        { 
            localidad = new MPP.Localidad(); 
        }

        
        public List<BE.Localidad> ListarTodo()
        {
            return localidad.ListarTodo();
        }


        public bool Guardar(BE.Localidad _localidad)
        {
            throw new NotImplementedException();
        }


        public bool Eliminar(BE.Localidad _localidad)
        {
            return localidad.Eliminar(_localidad);
        }


        public BE.Localidad ListarObjeto(BE.Localidad _localidad)
        {
            throw new NotImplementedException();
        }


    }
}
