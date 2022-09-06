using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonattto_POO_2P.Clases;

namespace Tonattto_POO_2P.ClasesVista
{
    public class CVistaPrestamosPagados
    {
        #region Campos
        List<CVistaPrestamosPagados> lPrestamos;
        #endregion

        #region Constructores
        public CVistaPrestamosPagados() { lPrestamos = new List<CVistaPrestamosPagados>(); }

        public CVistaPrestamosPagados(string pIdentificador, decimal pCapital, int pPlazo, decimal pTasaInteres, decimal pInteres, decimal pTotal)
        { Identificador = pIdentificador; Capital = pCapital; Plazo = pPlazo; TasaInteres = pTasaInteres; Interes = pInteres; Total = pTotal; }
        #endregion

        #region Variables
        private string _identificador;
        private decimal _capital;
        private DateTime _fechaAdjudicacion;
        private int _plazo;
        private decimal _tasaInteres;
        private decimal _interes;
        private decimal _total;
        #endregion

        #region Propiedades
        public string Identificador { get { return _identificador; } set { _identificador = value; } }

        public decimal Capital { get { return _capital; } set { _capital = value; } }

        public DateTime FechaAdjudicacion { get { return _fechaAdjudicacion; } set { _fechaAdjudicacion = value; } }

        public int Plazo { get { return _plazo; } set { _plazo = value; } }

        public decimal TasaInteres { get { return _tasaInteres; } set { _tasaInteres = value; } }

        public decimal Interes { get { return _interes; } set { _interes = value; } }

        public decimal Total { get { return _total; } set { _total = value; } }
        #endregion

        #region Metodo
        public List<CVistaPrestamosPagados> RetornaPrestamosPagados(List<CPrestamo> pListaPrestamo)
        {
            lPrestamos.Clear();
            foreach (CPrestamo p in pListaPrestamo)
            {
                lPrestamos.Add(new CVistaPrestamosPagados(p.Identificador, p.Capital, p.Plazo, p.TasaInteres, p.Interes, p.Total));
            }
            return lPrestamos;
        }
        #endregion
    }
}
