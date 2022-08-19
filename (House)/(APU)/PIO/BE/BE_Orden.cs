using System;

namespace BE
{
    public class BE_Orden : Entidad
    {
        public int OrdenID { get; set; }
        public int Legajo { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
