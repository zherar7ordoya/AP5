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
using Microsoft.Win32;

namespace MAPPER
{
    public class MPPUsuario
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPUsuario()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Usuario user)
        {
            string Consulta = "Usuario_Crear";
            hash = new Hashtable();

            if (user.IdUser != 0)
            {
                hash.Add("@Id", user.IdUser);
                Consulta = "Usuario_Modificar";
            }
            hash.Add("@NombreUsuario", user.NombreUsuario);
            hash.Add("@PasswordUsuario", user.Password);
            hash.Add("@IdRol", user.Rol);
            
            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Usuario> ListarTodo()
        {
            List<Usuario> ListaUsuarios = new List<Usuario>();

            DataTable dt = Oc.Leer("Usuario_ListarT", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Usuario user = new Usuario("");


                    user.IdUser = int.Parse(fila["Id"].ToString());
                    user.NombreUsuario = fila["NombreUsuario"].ToString();
                    user.Password = fila["PasswordUsuario"].ToString();
                    user.Rol = int.Parse(fila["IdRol"].ToString());

                    ListaUsuarios.Add(user);
                }
            }
            else
            {
                ListaUsuarios = null;
            }
            return ListaUsuarios;
        }

        public bool Borrar(Usuario user)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = user.IdUser;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Usuario_Borrar", ArrList);
        }
    }
}
