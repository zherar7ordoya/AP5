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
    public class MPPRol
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPRol()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Rol rol)
        {
            string Consulta = "Rol_Crear";
            hash = new Hashtable();

            if (rol.IdRol != 0)
            {
                hash.Add("@Id", rol.IdRol);
                Consulta = "Rol_Modificar";
            }
            hash.Add("@Rol", rol.Roll);
            hash.Add("@IdPermisos", rol.IdPermisos);            

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Rol> ListarTodo()
        {
            List<Rol> ListaRoles = new List<Rol>();

            DataTable dt = Oc.Leer("Rol_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Rol rol = new Rol("");

                    rol.IdRol = int.Parse(fila["Id"].ToString());
                    rol.Roll = fila["Rol"].ToString();
                    rol.IdPermisos = int.Parse(fila["IdPermisos"].ToString());

                    ListaRoles.Add(rol);
                }
            }
            else
            {
                ListaRoles = null;
            }
            return ListaRoles;
        }

        public bool Borrar(Rol rol)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = rol.IdRol;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Rol_Borrar", ArrList);
        }
    }
}
