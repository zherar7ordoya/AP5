using System;
using System.Collections.Generic;

namespace BEL
{
    public class Cliente : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Giftcard> Tarjeta { get; set; }
    }
}
