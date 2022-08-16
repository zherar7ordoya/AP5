using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BETarjeta: Entidad
    {
        private Estado _estado;
        private Rubro _rubro;

        #region "Propiedades"
        public int Numero { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public double Saldo { get; set; }

        public enum Estado { Activa=0, Baja=1, Sin_Saldo=2, Vencida=3, Sin_Asignar=4 }

        public Estado EnumEstado { get { return _estado; } set { _estado = value; } }

        public enum Rubro { Libre=0, Indumentaria=1, Comestibles=2 }

        public Rubro EnumRubro { get { return _rubro; } set { _rubro = value; } }

        public double DescuentoAcumulado { get; set; }

        #endregion
    }
}
