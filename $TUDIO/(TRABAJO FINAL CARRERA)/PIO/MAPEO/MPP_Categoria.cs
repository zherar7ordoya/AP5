using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Categoria : ABSTRACTA.IGestor<BE.BE_Categoria>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Categoria() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE.BE_Categoria categoria)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Categorias";
                Hashtable htabla = new Hashtable
                {
                    { "@CategoriaID", categoria.CategoriaID },
                    { "@Nombre", categoria.Nombre },
                    { "@Descripcion", categoria.Descripcion },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE.BE_Categoria categoria)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Categorias";
                Hashtable htabla = new Hashtable
                {
                    { "@CategoriaID", categoria.CategoriaID },
                    { "@Nombre", categoria.Nombre },
                    { "@Descripcion", categoria.Descripcion }
                };
                if (categoria.Instruccion == "Alta") htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE.BE_Categoria ListarObjeto(BE.BE_Categoria objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE.BE_Categoria> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Categorias";
                Hashtable htabla = new Hashtable
                {
                    { "@CategoriaID", string.Empty },
                    { "@Nombre", string.Empty },
                    { "@Descripcion", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Categoria> categorias = new List<BE.BE_Categoria>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Categoria categoria = new BE.BE_Categoria
                        {
                            CategoriaID = item["CategoriaID"].ToString(),
                            Nombre = item["Nombre"].ToString(),
                            Descripcion = item["Descripcion"].ToString()
                        };
                        categorias.Add(categoria);
                    }
                    return categorias;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }

        // ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
