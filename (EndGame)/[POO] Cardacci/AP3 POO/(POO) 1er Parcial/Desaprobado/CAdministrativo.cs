using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_1
{
    class CAdministrativo : CEmpleado
    {
        public CAdministrativo(uint legajo, string tipo, string nombre, string apellido, decimal sueldo) : base(legajo, tipo, nombre, apellido, sueldo)
        {
        }
    }
}
