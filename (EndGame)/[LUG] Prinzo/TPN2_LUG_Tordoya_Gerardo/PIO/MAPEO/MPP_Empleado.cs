using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Empleado : ABSTRACTA.IGestor<BE.BE_Empleado>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Empleado() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Empleado empleado)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Empleados";
                Hashtable htabla = new Hashtable
                {
                    { "@Legajo", empleado.Legajo },
                    { "@Nombre", empleado.Nombre },
                    { "@Apellido", empleado.Apellido },
                    { "@Usuario", empleado.Usuario },
                    { "@Contraseña", empleado.Contraseña },
                    { "@DepartamentoID", empleado.DepartamentoID },
                    { "@RolID", empleado.RolID },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE_Empleado empleado)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Empleados";
                Hashtable htabla = new Hashtable
                {
                    { "@Legajo", empleado.Legajo },
                    { "@Nombre", empleado.Nombre },
                    { "@Apellido", empleado.Apellido },
                    { "@Usuario", empleado.Usuario },
                    { "@Contraseña", empleado.Contraseña },
                    { "@DepartamentoID", empleado.DepartamentoID },
                    { "@RolID", empleado.RolID }
                };
                /* => NO PUEDE HACERSE ASÍ PUESTO QUE LOS DE LEGAJOS SIGUEN
                      AL REGISTRO ÚNICO RUBRICADO POR EL MINISTERIO DE TRABAJO.
                if (empleado.Legajo == 0)
                {
                    htabla.Add("@Instruccion", "Insert");
                }
                else
                {
                    htabla.Add("@Legajo", empleado.Legajo);
                    htabla.Add("@Instruccion", "Update");
                }
                */
                if (empleado.Instruccion == "Alta") htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE_Empleado ListarObjeto(BE_Empleado objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Empleado> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Empleados";
                Hashtable htabla = new Hashtable
                {
                    { "@Legajo", string.Empty },
                    { "@Nombre", string.Empty },
                    { "@Apellido", string.Empty },
                    { "@Usuario", string.Empty },
                    { "@Contraseña", string.Empty },
                    { "@DepartamentoID", string.Empty },
                    { "@RolID", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Empleado> empleados = new List<BE.BE_Empleado>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Empleado empleado = new BE.BE_Empleado
                        {
                            Legajo = Convert.ToInt32(item["Legajo"]),
                            Nombre = item["Nombre"].ToString(),
                            Apellido = item["Apellido"].ToString(),
                            Usuario = item["Usuario"].ToString(),
                            Contraseña = item["Contraseña"].ToString(),
                            DepartamentoID = item["DepartamentoID"].ToString(),
                            RolID = item["RolID"].ToString()
                        };
                        empleados.Add(empleado);
                    }
                    return empleados;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }

        // ⊱ ───────────────────────── {.⋅ ✯ ⋅.} ───────────────────────── ⊰ \\

    }
}
