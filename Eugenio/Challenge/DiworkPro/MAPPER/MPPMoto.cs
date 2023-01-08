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
    public class MPPMoto
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPMoto()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Moto moto)
        {
            string Consulta = "Moto_Crear";
            hash = new Hashtable();

            if (moto.Id != 0)
            {
                hash.Add("@Id", moto.Id);
                Consulta = "Moto_Modificar";
            }

            hash.Add("@Cilindrada", moto.Cilindrada);
            hash.Add("@IdVehiculo", moto.IdVehiculo);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Moto> ListarTodo()
        {
            List<Moto> ListaMoto = new List<Moto>();

            DataTable dt = Oc.Leer("Moto_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Moto moto = new Moto();

                    moto.Id = int.Parse(fila["Id"].ToString());
                    moto.Cilindrada = fila["Cilindrada"].ToString();
                    moto.IdVehiculo = int.Parse(fila["IdVehiculo"].ToString());

                    ListaMoto.Add(moto);
                }
            }
            else
            {
                ListaMoto = null;
            }
            return ListaMoto;
        }

        public bool Borrar(Moto moto)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = moto.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Moto_Borrar", ArrList);
        }
    }
}
