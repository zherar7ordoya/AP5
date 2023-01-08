using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public class Rol : Composite
    {
        public int IdRol { get; set; }
        public string Roll { get; set; }
        public int IdPermisos { get; set; }

        public Rol(string Nombre) : base(Nombre)
        {

        }
        public Rol(int idRol, string roll, int idPermisos): base(roll)
        {
            IdRol = idRol;
            Roll = roll;
            IdPermisos = idPermisos;
        }
    }
}
