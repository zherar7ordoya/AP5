using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public class Usuario : Composite
    {
        public int IdUser { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }



        public Usuario(string Nombre) : base(Nombre)
        {

        }

        public Usuario(string nombreUsuario, string password, int rol) : base(nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
        }

        public Usuario(int idUser, string nombreUsuario, string password, int rol) : base(nombreUsuario)
        {
            IdUser = idUser;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
        }
    }
}
