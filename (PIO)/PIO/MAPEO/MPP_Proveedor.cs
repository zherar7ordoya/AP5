using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Proveedor : ABSTRACTA.IGestor<BE.BE_Proveedor>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Proveedor() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Proveedor proveedor)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Proveedores";
                Hashtable htabla = new Hashtable
                {
                    { "@ProveedorID", proveedor.ProveedorID },
                    { "@Nombre", proveedor.Nombre },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE_Proveedor proveedor)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Proveedores";
                Hashtable htabla = new Hashtable
                {
                    { "@ProveedorID", proveedor.ProveedorID },
                    { "@Nombre", proveedor.Nombre }
                };
                if (proveedor.Instruccion == "Alta") htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE_Proveedor ListarObjeto(BE_Proveedor objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Proveedor> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Proveedores";
                Hashtable htabla = new Hashtable
                {
                    { "@ProveedorID", string.Empty },
                    { "@Nombre", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Proveedor> proveedores = new List<BE.BE_Proveedor>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Proveedor proveedor = new BE.BE_Proveedor
                        {
                            ProveedorID = item["ProveedorID"].ToString(),
                            Nombre = item["Nombre"].ToString()
                        };
                        proveedores.Add(proveedor);
                    }
                    return proveedores;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }

        // •°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•

    }
}
