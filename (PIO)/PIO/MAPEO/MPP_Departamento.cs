using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPP_Departamento : ABSTRACTA.IGestor<BE.BE_Departamento>
    {
        readonly DAL.Conexion DAL_CONEXION;
        public MPP_Departamento() => DAL_CONEXION = new DAL.Conexion();

        // |||||||||||||||||||||||||||||||||||||||||||||||| IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Departamento departamento)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Departamentos";
                Hashtable htabla = new Hashtable
                {
                    { "@DepartamentoID", departamento.DepartamentoID },
                    { "@Nombre", departamento.Nombre },
                    { "@Instruccion", "Delete" }
                };
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool Guardar(BE_Departamento departamento)
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Departamentos";
                Hashtable htabla = new Hashtable
                {
                    { "@DepartamentoID", departamento.DepartamentoID },
                    { "@Nombre", departamento.Nombre }
                };
                if (departamento.Instruccion == "Alta") htabla.Add("@Instruccion", "Insert");
                else { htabla.Add("@Instruccion", "Update"); }
                // *----------------------------------------------------------*

                return DAL_CONEXION.Escribir(consulta, htabla);
            }
            catch (Exception ex) { throw ex; }
        }


        public BE_Departamento ListarObjeto(BE_Departamento objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Departamento> ListarTodo()
        {
            try
            {
                // *-----------------------------------------------=> Protocolo
                string consulta = "ABM_Departamentos";
                Hashtable htabla = new Hashtable
                {
                    { "@DepartamentoID", string.Empty },
                    { "@Nombre", string.Empty },
                    { "@Instruccion", "Select" }
                };
                // *----------------------------------------------------------*

                List<BE.BE_Departamento> departamentos = new List<BE.BE_Departamento>();

                DataTable dtabla = DAL_CONEXION.Leer(consulta, htabla);

                if (dtabla.Rows.Count > 0)
                {
                    foreach (DataRow item in dtabla.Rows)
                    {
                        BE.BE_Departamento departamento = new BE.BE_Departamento
                        {
                            DepartamentoID = item["DepartamentoID"].ToString(),
                            Nombre = item["Nombre"].ToString()
                        };
                        departamentos.Add(departamento);
                    }
                    return departamentos;
                }
                else { return null; }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
