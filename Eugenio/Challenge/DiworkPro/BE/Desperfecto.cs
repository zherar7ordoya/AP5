using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Desperfecto : Entidad
    {
        public int IdPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal ManoDeObra { get; set; }
        public int Tiempo { get; set; }

        public Desperfecto() { }

        public Desperfecto(int idPresupuesto, string descripcion, decimal manoDeObra, int tiempo)
        {            
            IdPresupuesto = idPresupuesto;
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
        }

        public Desperfecto(int id, int idPresupuesto, string descripcion, decimal manoDeObra, int tiempo)
        {
            Id = id;
            IdPresupuesto = idPresupuesto;
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
        }
    }
}
