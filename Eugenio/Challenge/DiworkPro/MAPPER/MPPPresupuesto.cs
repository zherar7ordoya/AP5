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
    public class MPPPresupuesto
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPPresupuesto()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Presupuesto presupuesto)
        {
            string Consulta = "Presupuesto_Crear";
            hash = new Hashtable();

            if (presupuesto.Id != 0)
            {
                hash.Add("@Id", presupuesto.Id);
                Consulta = "Presupuesto_Modificar";
            }
            hash.Add("@Nombre", presupuesto.Nombre);
            hash.Add("@Apellido", presupuesto.Apellido);
            hash.Add("@Email", presupuesto.Email);
            hash.Add("@Total", presupuesto.Total);
            hash.Add("@IdVehiculo", presupuesto.IdVehiculo);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Presupuesto> ListarTodo()
        {
            List<Presupuesto> ListaPresupuestos = new List<Presupuesto>();

            DataTable dt = Oc.Leer("Presupuesto_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Presupuesto presupuesto = new Presupuesto();

                    presupuesto.Id = int.Parse(fila["Id"].ToString());
                    presupuesto.Nombre = fila["Nombre"].ToString();
                    presupuesto.Apellido = fila["Apellido"].ToString();
                    presupuesto.Email = fila["Email"].ToString();
                    presupuesto.Total = decimal.Parse(fila["Total"].ToString());
                    presupuesto.IdVehiculo = int.Parse(fila["IdVehiculo"].ToString());

                    ListaPresupuestos.Add(presupuesto);
                }
            }
            else
            {
                ListaPresupuestos = null;
            }
            return ListaPresupuestos;
        }

        public bool Borrar(Presupuesto presupuesto)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = presupuesto.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Presupuesto_Borrar", ArrList);
        }
    }
}
