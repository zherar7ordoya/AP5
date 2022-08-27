using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Creador
    {
        public static IVehiculo MetodoFabrica(int dinero)
        {
            if (dinero > 10000) return new Avioneta();
            if (dinero > 1000) return new Automovil();
            else { return new Bicicleta(); }
        }
    }
}
