using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{
    public class MPPDesperfectoRepuesto
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPDesperfectoRepuesto()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(DesperfectoRepuesto dr)
        {
            string Consulta = "DesperfectoRepuesto_Crear";
            hash = new Hashtable();

            if (dr.Id != 0)
            {
                hash.Add("@Id", dr.Id);
                Consulta = "DesperfectoRepuesto_Modificar";
            }
            hash.Add("@IdDesperfecto", dr.IdDesperfecto);
            hash.Add("@IdRepuesto", dr.IdRepuesto);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<DesperfectoRepuesto> ListarTodo()
        {
            List<DesperfectoRepuesto> ListaDr = new List<DesperfectoRepuesto>();

            DataTable dt = Oc.Leer("DesperfectoRepuesto_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    DesperfectoRepuesto dr = new DesperfectoRepuesto();

                    dr.Id = int.Parse(fila["Id"].ToString());
                    dr.IdDesperfecto = int.Parse(fila["IdDesperfecto"].ToString());
                    dr.IdRepuesto = int.Parse(fila["IdRepuesto"].ToString());

                    ListaDr.Add(dr);
                }
            }
            else
            {
                ListaDr = null;
            }
            return ListaDr;
        }

        public bool Borrar(DesperfectoRepuesto dr)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = dr.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("DesperfectoRepuesto_Borrar", ArrList);
        }
    }
}
