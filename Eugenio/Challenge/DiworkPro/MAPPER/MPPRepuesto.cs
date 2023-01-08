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
    public class MPPRepuesto
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPRepuesto()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Repuesto repuesto)
        {
            string Consulta = "Repuesto_Crear";
            hash = new Hashtable();

            if (repuesto.Id != 0)
            {
                hash.Add("@Id", repuesto.Id);
                Consulta = "Repuesto_Modificar";
            }
            hash.Add("@NombreRepuesto", repuesto.NombreRepuesto);
            hash.Add("@Precio", repuesto.PrecioRepuesto);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Repuesto> ListarTodo()
        {
            List<Repuesto> ListaRepuestos = new List<Repuesto>();

            DataTable dt = Oc.Leer("Repuesto_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Repuesto repuesto = new Repuesto();

                    repuesto.Id = int.Parse(fila["Id"].ToString());
                    repuesto.NombreRepuesto = fila["NombreRepuesto"].ToString();
                    repuesto.PrecioRepuesto = decimal.Parse(fila["Precio"].ToString());

                    ListaRepuestos.Add(repuesto);
                }
            }
            else
            {
                ListaRepuestos = null;
            }
            return ListaRepuestos;
        }



        public bool Borrar(Repuesto repuesto)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = repuesto.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Repuesto_Borrar", ArrList);
        }
    }
}
