using System;

namespace BEL
{
    public class Giftcard : Entidad
    {
        public int Numero { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Saldo { get; set; }
        public int Descuento { get; set; }
        public string Estado { get; set; }
        public string Rubro { get; set; }
        public string Pais { get; set; }
    }
}
