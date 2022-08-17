using System;

namespace BE
{
    public class ReporteListado
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Empleado { get; set; }
        public string Producto { get; set; }
        public double Total { get; set; }
    }
}
