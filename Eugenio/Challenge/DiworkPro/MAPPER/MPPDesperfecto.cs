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
    public class MPPDesperfecto
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPDesperfecto()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Desperfecto desperfecto)
        {
            string Consulta = "Desperfecto_Crear";
            hash = new Hashtable();

            if (desperfecto.Id != 0)
            {
                hash.Add("@Id", desperfecto.Id);
                Consulta = "Desperfecto_Modificar";
            }
            hash.Add("@IdPresupuesto", desperfecto.IdPresupuesto);
            hash.Add("@Descripcion", desperfecto.Descripcion);
            hash.Add("@ManoDeObra", desperfecto.ManoDeObra);
            hash.Add("@Tiempo", desperfecto.Tiempo);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Desperfecto> ListarTodo()
        {
            List<Desperfecto> ListaDesperfectos = new List<Desperfecto>();

            DataTable dt = Oc.Leer("Desperfecto_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Desperfecto desperfecto = new Desperfecto();

                    desperfecto.Id = int.Parse(fila["Id"].ToString());
                    desperfecto.IdPresupuesto = int.Parse(fila["IdPresupuesto"].ToString());
                    desperfecto.Descripcion = fila["Descripcion"].ToString();
                    desperfecto.ManoDeObra = decimal.Parse(fila["ManoDeObra"].ToString());
                    desperfecto.Tiempo = int.Parse(fila["Tiempo"].ToString());

                    ListaDesperfectos.Add(desperfecto);
                }
            }
            else
            {
                ListaDesperfectos = null;
            }
            return ListaDesperfectos;
        }

        public bool Borrar(Desperfecto desperfecto)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = desperfecto.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Desperfecto_Borrar", ArrList);
        }
    }
}
