using System;
using System.Collections;
using System.Collections.Generic;

namespace MPP
{
    public class MPP_Login : ABSTRACTA.IGestor<BE.BE_Login>
    {
        readonly DAL.Conexion CONEXION;
        Hashtable HTABLA;
        public MPP_Login() => CONEXION = new DAL.Conexion();

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

        public bool VerificarLogin(string usuario, string contraseña)
        {
            HTABLA = new Hashtable
            {
                { "@Usuario", usuario },
                { "@Contraseña", contraseña }
            };
            return CONEXION.LeerEscalar("Login", HTABLA);
        }
    }
}
