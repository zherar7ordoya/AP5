using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DesperfectoRepuesto : Entidad
    {
        public int IdDesperfecto { get; set; }
        public int IdRepuesto { get; set; }

        public DesperfectoRepuesto() { }

        public DesperfectoRepuesto(int idDesperfecto, int idRepuesto)
        {
            IdDesperfecto = idDesperfecto;
            IdRepuesto = idRepuesto;
        }

        public DesperfectoRepuesto(int id, int idDesperfecto, int idRepuesto)
        {
            Id = id;
            IdDesperfecto = idDesperfecto;
            IdRepuesto = idRepuesto;
        }
    }
}
