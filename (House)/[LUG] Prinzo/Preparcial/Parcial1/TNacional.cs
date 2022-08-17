using System;
using TarjAbstracta;

namespace Parcial1
{
    public class TNacional : Tarjeta
    {
        public string Provincia { get; set; }

        public TNacional()
        {
        }

        public TNacional(int _numero, DateTime _fechaVencimiento, double _saldo, string _estado, string _rubro, string _provincia)
        {
            this.Numero = _numero;
            this.FechaVencimiento = _fechaVencimiento;
            this.Saldo = _saldo;
            this.Estado = _estado;
            this.Rubro = _rubro;
            this.Provincia = _provincia;
        }

        public TNacional(int _numero, DateTime _fechaVencimiento, double _saldo, string _estado, string _rubro, string _provincia, double _precio)
        {
            this.Numero = _numero;
            this.FechaVencimiento = _fechaVencimiento;
            this.Saldo = _saldo;
            this.Estado = _estado;
            this.Rubro = _rubro;
            this.Provincia = _provincia;
            this.Descuentos = DescuentoCalculado(_precio);
        }

        public override double DescuentoCalculado(double precio)
        {
           return  precio * 0.25;
        }

        public override string ToString()
        {
            return String.Format("{0}  {1}  {2}  {3}  {4}  {5}", Numero, Estado, Saldo, Rubro, FechaVencimiento.ToShortDateString(), Provincia);
        }

        public override string InformarEstado()
        {
            return base.Estado;
        }
    }
}