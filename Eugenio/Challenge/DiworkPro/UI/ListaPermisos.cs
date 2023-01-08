using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace UI
{
    public class ListaPermisos
    {
        public List<AuxLista> aux;
        BLLPermisos bllpermisos = new BLLPermisos();

        public void ListaPermisivos(string rola, string rolear)
        {
            aux = new List<AuxLista>();
            aux.Add(new AuxLista { Id = 1, Permiso = rolear, IdPadre = 0 });
            foreach(Permisos permisos in bllpermisos.ListarTodo())
            {
               if (rola == permisos.Nombre)
                
                {
                    aux.Add(new AuxLista { Id = 1, Permiso = permisos.Nombre, IdPadre = 0 });
                    if (permisos.PresupuestarAutomovil == true)
                    {
                        aux.Add(new AuxLista { Id = 2, Permiso = "Presupuestar Automovil", IdPadre = 1 });
                    }

                    if (permisos.PresupuestarMoto == true)
                    {
                        aux.Add(new AuxLista { Id = 3, Permiso = "Presupuestar Moto", IdPadre = 1 });
                    }

                    if (permisos.CrearUsuario == true)
                    {
                        aux.Add(new AuxLista { Id = 4, Permiso = "Crear Usuario", IdPadre = 1 });
                    }

                    if (permisos.Estadisticas == true)
                    {
                        aux.Add(new AuxLista {Id = 5, Permiso = "Estadisticas", IdPadre = 1 });
                    }

                    if(permisos.Login == true)
                    {
                        aux.Add(new AuxLista {Id = 6, Permiso = "Login", IdPadre = 1 });
                    }

                    if(permisos.Logout == true)
                    {
                        aux.Add(new AuxLista { Id = 7, Permiso = "Logout", IdPadre = 1 });
                    }
               }
            }
        }
    }
}
