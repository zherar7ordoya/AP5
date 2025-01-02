using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Item : ABSTRACTA.IGestor<BE.BE_Item>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Item() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Item producto)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Items";
                Hashtable htabla = new Hashtable
                {
                    { "@ItemID", producto.ItemID },
                    { "@CategoriaID", producto.CategoriaID },
                    { "@Nombre", producto.Nombre },
                    { "@Descripcion", producto.Descripcion },
                    { "@PrecioUnitario", producto.PrecioUnitario },
                    { "@ProveedorID", producto.ProveedorID },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE_Item producto)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Items";
                Hashtable htabla = new Hashtable
                {
                    { "@ItemID", producto.ItemID },
                    { "@CategoriaID", producto.CategoriaID },
                    { "@Nombre", producto.Nombre },
                    { "@Descripcion", producto.Descripcion },
                    { "@PrecioUnitario", producto.PrecioUnitario },
                    { "@ProveedorID", producto.ProveedorID }
                };
                if (producto.ItemID == 0) htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE_Item ListarObjeto(BE_Item objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Item> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Items";
                Hashtable htabla = new Hashtable
                {
                    { "@ItemID", 0 },
                    { "@CategoriaID", string.Empty },
                    { "@Nombre", string.Empty },
                    { "@Descripcion", string.Empty },
                    { "@PrecioUnitario", 0 },
                    { "@ProveedorID", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Item> productos = new List<BE.BE_Item>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Item producto = new BE.BE_Item
                        {
                            ItemID = Convert.ToInt32(item["ItemID"]),
                            CategoriaID = item["CategoriaID"].ToString(),
                            Nombre = item["Nombre"].ToString(),
                            Descripcion = item["Descripcion"].ToString(),
                            PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]),
                            ProveedorID = item["ProveedorID"].ToString()
                        };
                        productos.Add(producto);
                    }
                    return productos;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }

        // ⊱ ───────────────────────── {.⋅ ✯ ⋅.} ───────────────────────── ⊰ \\

    }
}
