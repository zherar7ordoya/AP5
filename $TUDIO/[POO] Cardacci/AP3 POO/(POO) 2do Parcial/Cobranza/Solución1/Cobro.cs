using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUrbainskyAlexis
{
    abstract class Cobro : ICloneable, IComparable<Cobro>, IDisposable
    {
        #region campos
        private Cliente _cliente;
        private decimal _ImporteTotal;
        private bool _Cancelado;
        public event EventHandler<ImporteElevadoEventArgs> ImporteElevado;
        #endregion

        #region Constructores
        public Cobro() {
        }

        public Cobro(int pCodigo, String pNombre, DateTime pFechaVencimiento, decimal pImporte, Cliente pCliente) {
            Código = pCodigo;
            Nombre = pNombre;
            FechaVencimiento = pFechaVencimiento;
            Importe = pImporte;
            _cliente = pCliente;
            _Cancelado = false;
        }
        #endregion

        #region Propiedades
        public int Código { get; set; }

        public String Nombre { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public decimal Importe { get; set; }

        #endregion

        #region Metodos
        public abstract decimal CalcularAdicionales();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Cliente DevuelveCliente()
        {
            return _cliente;
        }

         public int CompareTo(Cobro cobro)
        {
            return Importe.CompareTo(cobro.Importe);
        }

        public override string ToString()
        {
            return $"{Código} {Nombre} {FechaVencimiento} {Importe}";
        }

        public bool EsCancelado() {
            return _Cancelado;
        }

        public void CancelarCobro() {
            _Cancelado = true;
        }

        public decimal RetornaTotalImporteCancelado()
        {
            return _ImporteTotal;
        }

        public void AsignarImporteTotal(decimal pImporte)
        {
            _ImporteTotal = pImporte;
        }

        #endregion

        #region Destructor

        bool _DisposeOk = false;
        ~Cobro()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
                Console.WriteLine("El Cobro ha Finalizado Codigo: " + Código + " Nombre:" + Nombre + " Importe: " + Importe);
            }
        }
        public void Dispose()
        {
            _DisposeOk = true;
        }
        #endregion

    }
}
