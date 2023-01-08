using Abstract;
using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GestorPermisos : Composite
    {
        public GestorPermisos(string Nombre) : base(Nombre)
        {
            bllrol = new BLLRol();
            bllpermisos = new BLLPermisos();
        }
        BLLRol bllrol;
        BLLPermisos bllpermisos;

        Composite roles;
        Composite usuario;
        Leaf permisos;
        public Rol Permisos(Composite user, string puesto)
        {
            usuario = user;
            roles = new Rol(puesto);
            permisos = new Permisos(puesto);

            foreach (Rol role in bllrol.ListarTodo())
            {
                if(role.Roll == puesto)
                {
                    roles = role;
                    foreach (Permisos permis in bllpermisos.ListarTodo())
                    {
                        if(permis.Nombre == puesto)
                        {
                            roles.Add(permis);
                            roles.comp.Add(permis);
                            usuario.comp.Add(roles);
                        }
                    }
                }
            }
            return (Rol)roles;
        }

    }
}
