using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Jugador : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LocalidadResidencia { get; set; }
        public List<Puntaje> Puntajes { get; set; }
    }
}
