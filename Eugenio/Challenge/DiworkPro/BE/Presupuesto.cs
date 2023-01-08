using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Presupuesto : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
        public string Email { get; set; }
        public decimal Total { get; set; }
        public int IdVehiculo { get; set; }

        public Presupuesto() { }

        public Presupuesto(string nombre, string apellido, string email, decimal total, int idVehiculo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Total = total;
            IdVehiculo = idVehiculo;
        }

        public Presupuesto(int id, string nombre, string apellido, string email, decimal total, int idVehiculo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Total = total;
            IdVehiculo = idVehiculo;
        }
    }
}
