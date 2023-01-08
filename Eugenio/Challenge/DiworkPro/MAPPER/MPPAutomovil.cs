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
    public class MPPAutomovil
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPAutomovil()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Automovil auto)
        {
            string Consulta = "Automovil_Crear";
            hash = new Hashtable();

            if (auto.Id != 0)
            {
                hash.Add("@Id", auto.Id);
                Consulta = "Automovil_Modificar";
            }
            hash.Add("@Tipo", auto.TipoM);
            hash.Add("@CantidadPuertas", auto.CantidadPuertas);
            hash.Add("@IdVehiculo", auto.IdVehiculo);
            
            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Automovil> ListarTodo()
        {
            List<Automovil> ListaAutomovil = new List<Automovil>();

            DataTable dt = Oc.Leer("Automovil_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Automovil auto = new Automovil();

                    auto.Id = int.Parse(fila["Id"].ToString());
                    //auto.TipoM = (Automovil.Tipo)fila["Tipo"].ToString();
                    auto.TipoM = (Automovil.Tipo)int.Parse(fila["Tipo"].ToString());
                    auto.CantidadPuertas = int.Parse(fila["CantidadPuertas"].ToString());
                    auto.IdVehiculo = int.Parse(fila["IdVehiculo"].ToString());
                    
                    ListaAutomovil.Add(auto);
                }
            }
            else
            {
                ListaAutomovil = null;
            }
            return ListaAutomovil;
        }

        public bool Borrar(Automovil auto)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = auto.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Automovil_Borrar", ArrList);
        }
    }
}
