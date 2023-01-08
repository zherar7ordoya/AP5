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
    public class MPPPermisos
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPPermisos()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Permisos permisos)
        {
            string Consulta = "Permisos_Crear";
            hash = new Hashtable();

            if (permisos.Id != 0)
            {
                hash.Add("@Id", permisos.Id);
                Consulta = "Permisos_Modificar";
            }
            hash.Add("@PresupuestoAutomovil", permisos.PresupuestarAutomovil.ToString());
            hash.Add("@PresupuestoMoto", permisos.PresupuestarMoto.ToString());
            hash.Add("@CrearUsuario", permisos.CrearUsuario.ToString());
            hash.Add("@Estadisticas", permisos.Estadisticas.ToString());
            hash.Add("@Login", permisos.Login.ToString());
            hash.Add("@Logout", permisos.Logout.ToString());
            hash.Add("@Nombre", permisos.Nombre);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Permisos> ListarTodo()
        {
            List<Permisos> ListaPermisos = new List<Permisos>();

            DataTable dt = Oc.Leer("Permisos_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Permisos permisos = new Permisos("");

                    permisos.Id = int.Parse(fila["Id"].ToString());
                    permisos.PresupuestarAutomovil = bool.Parse(fila["PresupuestoAutomovil"].ToString());
                    permisos.PresupuestarMoto = bool.Parse(fila["PresupuestoMoto"].ToString());
                    permisos.CrearUsuario = bool.Parse(fila["CrearUsuario"].ToString());
                    permisos.Estadisticas = bool.Parse(fila["Estadisticas"].ToString());
                    permisos.Login = bool.Parse(fila["Login"].ToString());
                    permisos.Logout = bool.Parse(fila["Logout"].ToString());
                    permisos.Nombre = fila["Nombre"].ToString();
                    ListaPermisos.Add(permisos);
                }
            }
            else
            {
                ListaPermisos = null;
            }
            return ListaPermisos;
        }

        public bool Borrar(Permisos permisos)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = permisos.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Permisos_Borrar", ArrList);
        }
    }
}
