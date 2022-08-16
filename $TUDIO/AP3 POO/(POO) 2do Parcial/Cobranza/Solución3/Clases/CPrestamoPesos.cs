using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonattto_POO_2P.Clases
{
    public class CPrestamoPesos : CPrestamo
    {
        #region Constructores
        public CPrestamoPesos() { }

        public CPrestamoPesos(string pIdentificador, decimal pCapital, DateTime pFechaAdjudicacion, int pPlazo, decimal pTasaInteres, decimal pTotal, bool pVencido, bool pPagado)
        { Identificador = pIdentificador; Capital = pCapital; FechaAdjudicacion = pFechaAdjudicacion; Plazo = pPlazo; TasaInteres = pTasaInteres; Total = pTotal; Vencido = pVencido; Pagado = pPagado; }
        #endregion

        #region Metodos
        public virtual void AsignarTitular()
        {
        }

        public virtual void CalcularPlazo()
        { }

        public override void CalcularTotal(CPrestamo pPrestamo)
        {
            pPrestamo.Total = pPrestamo.Total + pPrestamo.Capital;
        }

        public override void GastoAdministrativo(CPrestamo pPrestamo)
        {
            pPrestamo.Total = pPrestamo.Total + ((pPrestamo.Capital * 2) / 100);
        }

        public virtual void SeguroObligatorio()
        { }

        public override void CalcularInteres(CPrestamo pPrestamo)
        {
            pPrestamo.Interes = pPrestamo.Capital * (1 + (decimal)(Math.Pow((Convert.ToDouble(pPrestamo.TasaInteres / 100)), pPrestamo.Plazo) - 1));
        }
        #endregion
    }
}
