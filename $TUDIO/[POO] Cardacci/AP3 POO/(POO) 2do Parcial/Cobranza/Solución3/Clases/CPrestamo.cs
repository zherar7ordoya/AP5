using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonattto_POO_2P.Clases
{
    public abstract class CPrestamo
    {
        #region Campos
        public CCliente _titular;
        #endregion

        #region Constructores
        public CPrestamo() { }

        public CPrestamo(string pIdentificador, decimal pCapital, DateTime pFechaAdjudicacion, DateTime pFechaDevolucion, int pPlazo, decimal pTasaInteres, decimal pTotal, bool pVencido, bool pPagado)
        { Identificador = pIdentificador; Capital = pCapital; FechaAdjudicacion = pFechaAdjudicacion; FechaDevolucion = pFechaDevolucion; Plazo = pPlazo; TasaInteres = pTasaInteres; Total = pTotal; Vencido = pVencido; Pagado = pPagado; }
        #endregion

        #region Propiedades
        public string Identificador { get; set; }

        public decimal Capital { get; set; }

        public DateTime FechaAdjudicacion { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public int Plazo { get; set; }

        public decimal TasaInteres { get; set; }

        public decimal Interes { get; set; }

        public decimal Total { get; set; }

        public bool Vencido { get; set; }

        public bool Pagado { get; set; }
        #endregion

        #region Metodos
        public virtual void AsignarTitular(CCliente pCliente)
        {
            _titular = pCliente;
        }

        public virtual CCliente RetornaTitular()
        { return _titular; }

        public virtual void CalcularPlazo(CPrestamo pPrestamo)
        {
            pPrestamo.FechaDevolucion = pPrestamo.FechaAdjudicacion.AddMonths(pPrestamo.Plazo);
        }

        public abstract void GastoAdministrativo(CPrestamo pPrestamo);

        public virtual void SeguroObligatorio(CPrestamo pPrestamo)
        {
            pPrestamo.Total = pPrestamo.Total + ((pPrestamo.Capital * 1) / 100);
        }

        public abstract void CalcularTotal(CPrestamo pPrestamo);

        public abstract void CalcularInteres(CPrestamo pPrestamo);
        #endregion
    }
}
