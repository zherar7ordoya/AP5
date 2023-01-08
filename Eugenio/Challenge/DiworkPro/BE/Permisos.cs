using Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Permisos : Leaf
    {
        public int Id { get; set; }
        public bool PresupuestarAutomovil { get; set; }
        public bool PresupuestarMoto { get; set; }
        public bool CrearUsuario { get; set; }
        public bool Estadisticas { get; set; }
        public bool Login { get; set; }
        public bool Logout { get; set; }
        public string Nombre { get; set; } 
        

       public Permisos(string Nombre): base(Nombre) { }

        public Permisos(bool presupuestarAutomovil, bool presupuestarMoto, bool crearUsuario, bool estadisticas, bool login, bool logout, string nombre) : base(nombre)
        {
            
            PresupuestarAutomovil = presupuestarAutomovil;
            PresupuestarMoto = presupuestarMoto;
            CrearUsuario = crearUsuario;
            Estadisticas = estadisticas;
            Login = login;
            Logout = logout;
            Nombre = nombre;
        }

        public Permisos(int id, bool presupuestarAutomovil, bool presupuestarMoto, bool crearUsuario, bool estadisticas, bool login, bool logout, string nombre) : base(nombre)
        {
            Id = id;
            PresupuestarAutomovil = presupuestarAutomovil;
            PresupuestarMoto = presupuestarMoto;
            CrearUsuario = crearUsuario;
            Estadisticas = estadisticas;
            Login = login;
            Logout = logout;
            Nombre = nombre;
        }   
    }
}
