using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace Service
{
    public class Loguear
    {
        BLLUsuario bllusuario;

        public Loguear()
        {
            bllusuario = new BLLUsuario();
        }

        public bool LoguearUsuario(string user, string pass)
        {
            foreach (Usuario usuario in bllusuario.ListarTodo())
            {
                string desenc = Desencript.Decrypt(usuario.Password);
                if(user == usuario.NombreUsuario && pass == desenc)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
