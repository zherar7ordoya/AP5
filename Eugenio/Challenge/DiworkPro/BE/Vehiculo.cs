using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public abstract class Vehiculo : Entidad
    {       
       public string Marca { get; set; }
       public string Modelo { get; set; }
       public string Patente { get; set; }

       
     
    }
}
