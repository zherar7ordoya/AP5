using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Rol : ABSTRACTA.IGestor<BE.BE_Rol>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Rol() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Rol rol)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Roles";
                Hashtable htabla = new Hashtable
                {
                    { "@RolID", rol.RolID },
                    { "@Nombre", rol.Nombre },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE_Rol rol)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Roles";
                Hashtable htabla = new Hashtable
                {
                    { "@RolID", rol.RolID },
                    { "@Nombre", rol.Nombre }
                };
                if (rol.Instruccion == "Alta") htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE_Rol ListarObjeto(BE_Rol objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Rol> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Roles";
                Hashtable htabla = new Hashtable
                {
                    { "@RolID", string.Empty },
                    { "@Nombre", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Rol> roles = new List<BE.BE_Rol>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Rol rol = new BE.BE_Rol
                        {
                            RolID = item["RolID"].ToString(),
                            Nombre = item["Nombre"].ToString()
                        };
                        roles.Add(rol);
                    }
                    return roles;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }

        // •°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•

    }
}
