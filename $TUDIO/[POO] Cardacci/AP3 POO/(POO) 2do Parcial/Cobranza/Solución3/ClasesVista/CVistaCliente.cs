using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonattto_POO_2P.Clases;

namespace Tonattto_POO_2P.ClasesVista
{
    public class CVistaCliente
    {
        #region Campos
        List<CVistaCliente> lVistaPrestamos;
        #endregion

        #region Constructores
        public CVistaCliente() { lVistaPrestamos = new List<CVistaCliente>(); }

        public CVistaCliente(string pIdentificador, decimal pCapital, DateTime pFechaAdjudicacion, int pPlazo, decimal pTasaInteres, decimal pTotal)
        { Identificador = pIdentificador; Capital = pCapital; FechaAdjudicacion = pFechaAdjudicacion; Plazo = pPlazo; TasaInteres = pTasaInteres; Total = pTotal; }
        #endregion

        #region Propiedades
        public string Identificador { get; set; }

        public decimal Capital { get; set; }

        public DateTime FechaAdjudicacion { get; set; }

        public int Plazo { get; set; }

        public decimal TasaInteres { get; set; }

        public decimal Total { get; set; }

        public CCliente Titular { get; set; }
        #endregion

        #region Metodo
        public List<CVistaCliente> RetornaListaPrestamos(List<CPrestamo> pListaPrestamos, CCliente pTitular)
        {
            lVistaPrestamos.Clear();
            foreach (CPrestamo p in pListaPrestamos)
            {
                lVistaPrestamos.Add(new CVistaCliente(p.Identificador, p.Capital, p.FechaAdjudicacion, p.Plazo, p.TasaInteres, p.Total));
            }
            return lVistaPrestamos;
        }
        #endregion
    }
}
