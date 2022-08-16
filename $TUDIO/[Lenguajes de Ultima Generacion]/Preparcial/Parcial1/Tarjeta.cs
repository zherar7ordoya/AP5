using System;

namespace TarjAbstracta
{
    public abstract class Tarjeta
    {
        //Las tarjetas contienen un número, fecha de vencimiento, saldo, descuentos, estado (Activa, Baja,
        //sin saldo, vencida), rubro (libre, indumentaria, comestibles), las mismas pueden ser Nacional o
        //internacional.

        #region propiedades

        public int Numero { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Saldo { get; set; }

        public double Descuentos { get; set; }

        public string Estado { get; set; }
        public string Rubro { get; set; }

        #endregion propiedades

        public abstract double DescuentoCalculado(double precio);

        public virtual string InformarEstado()
        {
            return Estado;
        }
    }
}