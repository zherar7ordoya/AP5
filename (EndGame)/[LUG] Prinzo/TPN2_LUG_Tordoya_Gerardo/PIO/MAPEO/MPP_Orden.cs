using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Orden : ABSTRACTA.IGestor<BE.BE_Orden>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Orden() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Orden orden)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Ordenes";
                Hashtable htabla = new Hashtable
                {
                    { "@OrdenID", orden.OrdenID },
                    { "@Legajo", orden.Legajo },
                    { "@Fecha", orden.Fecha },
                    { "@Estado", orden.Estado },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE_Orden orden)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Ordenes";
                Hashtable htabla = new Hashtable
                {
                    { "@OrdenID", orden.OrdenID },
                    { "@Legajo", orden.Legajo },
                    { "@Fecha", orden.Fecha },
                    { "@Estado", orden.Estado }
                };
                if (orden.OrdenID == 0) htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE_Orden ListarObjeto(BE_Orden objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Orden> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Ordenes";
                Hashtable htabla = new Hashtable
                {
                    { "@OrdenID", 0 },
                    { "@Legajo", 0 },
                    { "@Fecha", string.Empty },
                    { "@Estado", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Orden> ordenes = new List<BE.BE_Orden>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Orden orden = new BE.BE_Orden
                        {
                            OrdenID = Convert.ToInt32(item["OrdenID"]),
                            Legajo = Convert.ToInt32(item["Legajo"]),
                            Fecha = Convert.ToDateTime(item["Fecha"]),
                            Estado = item["Estado"].ToString()
                        };
                        ordenes.Add(orden);
                    }
                    return ordenes;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }

        // ⊱ ───────────────────────── {.⋅ ✯ ⋅.} ───────────────────────── ⊰ \\

    }
}
