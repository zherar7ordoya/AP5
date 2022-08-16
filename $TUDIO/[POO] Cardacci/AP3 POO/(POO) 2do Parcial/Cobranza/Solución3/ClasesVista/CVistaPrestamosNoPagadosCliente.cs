using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonattto_POO_2P.Clases;

namespace Tonattto_POO_2P.ClasesVista
{
    public class CVistaPrestamosNoPagadosCliente
    {
        #region Campos
        List<CVistaPrestamosNoPagadosCliente> lPrestamos;
        #endregion

        #region Constructores
        public CVistaPrestamosNoPagadosCliente() { lPrestamos = new List<CVistaPrestamosNoPagadosCliente>(); }

        public CVistaPrestamosNoPagadosCliente(string pIdentificador, decimal pCapital, DateTime pFechaAdjudicacion, int pPlazo, decimal pTasaInteres, decimal pInteres, decimal pTotal)
        { Identificador = pIdentificador; Capital = pCapital; FechaAdjudicacion = pFechaAdjudicacion; Plazo = pPlazo; TasaInteres = pTasaInteres; interes = pInteres; Total = pTotal; }
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

        public decimal interes { get { return _interes; } set { _interes = value; } }

        public decimal Total { get { return _total; } set { _total = value; } }
        #endregion

        #region Metodo
        public List<CVistaPrestamosNoPagadosCliente> PrestamosPagadosCliente(List<CPrestamo> pListaPrestamo)
        {
            lPrestamos.Clear();
            foreach (CPrestamo p in pListaPrestamo)
            {
                lPrestamos.Add(new CVistaPrestamosNoPagadosCliente(p.Identificador, p.Capital, p.FechaAdjudicacion, p.Plazo, p.TasaInteres, p.Interes, p.Total));
            }

            return lPrestamos;
        }
        #endregion
    }
}
