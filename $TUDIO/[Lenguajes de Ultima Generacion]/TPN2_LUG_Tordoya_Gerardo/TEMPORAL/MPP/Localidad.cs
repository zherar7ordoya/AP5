using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

namespace MPP
{
    public class Localidad : Abstraccion.IGestor<BE.Localidad>
    {
        readonly DAL.Conexion conexion;
        //defino el Hastable
        Hashtable htabla;


        public Localidad()
        {
            conexion = new DAL.Conexion();
        }


        public List<BE.Localidad> ListarTodo()
        {
            List<BE.Localidad> localidades = new List<BE.Localidad>();
            DataTable dtabla = conexion.Leer("s_Localidad_ListarT", null);


            if (dtabla.Rows.Count > 0)
            {
                foreach (DataRow item in dtabla.Rows)
                {
                    BE.Localidad localidad = new BE.Localidad
                    {
                        Id = Convert.ToInt32(item[0]),
                        Descripcion = item[1].ToString()
                    };
                    localidades.Add(localidad);
                }
                return localidades;
            }
            else
            {
                return null;
            }
        }


        public bool Eliminar(BE.Localidad localidad)
        {
            if (Existe_Localidad_Asociada(localidad) == false)
            {
                //como esta definido fuera de un bloque el AL uso el mismo que defini en Existe_Localidad_Asociada
                return conexion.Escribir("s_Localidad_Borrar", htabla);
            }
            else
            {
                return false;
            }
        }


        //busco si existe alguna localidad asociada a un cliente
        public bool Existe_Localidad_Asociada(BE.Localidad localidad)
        {  //instancio el array lista para pasar los parametros

            htabla = new Hashtable
            {
                { "@IdLoc", localidad.Id }
            };

            return conexion.LeerEscalar("s_Localidad_Asociada", htabla);
        }


        public bool Guardar(BE.Localidad Objeto)
        {
            throw new NotImplementedException();
        }


        public BE.Localidad ListarObjeto(BE.Localidad Objeto)
        {
            throw new NotImplementedException();
        }


    }
}


