using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonattto_POO_2P.Clases;

namespace Tonattto_POO_2P.ClasesVista
{
    public class CVistaPrestamo
    {
        #region Campos
        List<CVistaPrestamo> lPrestamos;
        #endregion

        #region Constructores
        public CVistaPrestamo() { lPrestamos = new List<CVistaPrestamo>(); }

        public CVistaPrestamo(string pIdentificador, decimal pCapital, int pPlazo, decimal pTasaInteres, decimal pInteres, decimal pTotal, string pDocumento, string pApellidoNombre)
        { Identificador = pIdentificador; Capital = pCapital; Plazo = pPlazo; TasaInteres = pTasaInteres; Interes = pInteres; Total = pTotal; Documento = pDocumento; Apellido_Nombre = pApellidoNombre; }
        #endregion

        #region Propiedades
        public string Identificador { get; set; }

        public decimal Capital { get; set; }

        public int Plazo { get; set; }

        public decimal TasaInteres { get; set; }

        public decimal Interes { get; set; }

        public decimal Total { get; set; }

        public string Documento { get; set; }

        public string Apellido_Nombre { get; set; }
        #endregion

        #region Metodo
        public List<CVistaPrestamo> ListaPrestamos(List<CPrestamo> pListaPrestamos)
        {
            lPrestamos.Clear();
            foreach (CPrestamo p in pListaPrestamos)
            {
                lPrestamos.Add(new CVistaPrestamo(p.Identificador, p.Capital, p.Plazo, p.TasaInteres, p.Interes, p.Total, (p.RetornaTitular() is null ? "" : p.RetornaTitular().Documento), $"{(p.RetornaTitular() is null ? "" : p.RetornaTitular().Apellido)}{ (p.RetornaTitular() is null ? "" : ",")} {(p.RetornaTitular() is null ? "" : p.RetornaTitular().Nombre)}"));
            }
            return lPrestamos;
        }
        #endregion

    }
}
