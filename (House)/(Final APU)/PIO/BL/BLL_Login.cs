using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Login : ABSTRACTA.IGestor<BE.BE_Login>
    {
        readonly MPP.MPP_Login LOGIN;
        public BLL_Login() => LOGIN = new MPP.MPP_Login();

        // *---------------------------------------------=> IMPLEMENTA INTERFAZ

        public bool Eliminar(BE.BE_Login objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE.BE_Login objeto)
        {
            throw new NotImplementedException();
        }

        public BE.BE_Login ListarObjeto(BE.BE_Login objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE.BE_Login> ListarTodo()
        {
            throw new NotImplementedException();
        }

        // *----------------------------------------------------=> VERIFICACIÓN

        public bool VerificarLogin(string usuario, string encriptado)
        {
            string contraseña = SEGURIDAD.Criptografia.Desencriptar(encriptado);
            return LOGIN.VerificarLogin(usuario, contraseña);
        }
    }
}
