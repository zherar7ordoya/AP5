using System;
using TarjAbstracta;

namespace Parcial1
{
    public class TInternacional : Tarjeta
    {
        public string Pais { get; set; }

        public TInternacional()
        {
        }

        public TInternacional(int _numero, DateTime _fechaVencimiento, double _saldo, string _estado, string _rubro, string _pais)
        {
            this.Numero = _numero;
            this.FechaVencimiento = _fechaVencimiento;
            this.Saldo = _saldo;
            this.Estado = _estado;
            this.Rubro = _rubro;
            this.Pais = _pais;
        }

        public TInternacional(int _numero, DateTime _fechaVencimiento, double _saldo, string _estado, string _rubro, string _pais, double _precio)
        {
            this.Numero = _numero;
            this.FechaVencimiento = _fechaVencimiento;
            this.Saldo = _saldo;
            this.Estado = _estado;
            this.Rubro = _rubro;
            this.Pais = _pais;
            this.Descuentos = DescuentoCalculado(_precio);
        }

        public override double DescuentoCalculado(double precio)
        {
            return precio * 0.30;
        }

        public override string ToString()
        {
            return String.Format("{0}  {1}  {2}  {3}  {4}  {5}", Numero, Estado, Saldo, Rubro, FechaVencimiento.ToShortDateString(),Pais);
        }

        public override string InformarEstado()
        {
            return base.Estado;
        }
    }
}