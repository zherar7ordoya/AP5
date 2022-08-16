using System;

namespace BE
{
    public class BE_Auditoria : Entidad
    {
        public int OrdenID { get; set; }
        public DateTime Fecha { get; set; }
        public string Empleado { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }
    }
}
