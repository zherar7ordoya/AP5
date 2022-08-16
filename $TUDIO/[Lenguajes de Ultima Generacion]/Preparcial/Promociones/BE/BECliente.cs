using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente: Entidad
    {
        public BECliente() { }

        #region "Propiedades"
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public BETarjetaNacional TarjetaNacional { get; set; }

        public BETarjetaInternacional TarjetaInternacional { get; set; }
        #endregion

        #region "Metodo tostring"
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
        #endregion
    }
}
