using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsVistaGrillas3a6
    {
        #region CAMPOS

        private List<ClsVistaGrillas3a6> listaVistaGrillas3a6;

        #endregion

        #region PROPIEDADES

        public string Id { get; set; }
        public string Capital { get; set; }
        public int Plazo { get; set; }
        public string TNA { get; set; }
        public string Interes { get; set; }
        public string Total { get; set; }

        #endregion

        #region CONSTRUCTORES

        public ClsVistaGrillas3a6()
        {
            listaVistaGrillas3a6 = new List<ClsVistaGrillas3a6>();
        }
        public ClsVistaGrillas3a6(string pId, string pCapital, int pPlazo, string pTasa, string pInteres, string pTotal)
        {
            Id = pId;
            Capital = pCapital;
            Plazo = pPlazo;
            TNA = pTasa;
            Interes = pInteres;
            Total = pTotal;
        }

        #endregion

        #region METODOS

        //llega por referencia una lista de prestamos.
        public List<ClsVistaGrillas3a6> RetornaListaVistaGrillas3a6(List<ClsPrestamo> pLP)
        {
            listaVistaGrillas3a6.Clear();
            foreach(ClsPrestamo P in pLP)
            {
                TNA = P.TasaAnual + " %";
                if(P is ClsPrestamoPesos)
                {
                    Capital = "$ " + P.CapitalSolicitado;
                    Interes = "$ "+TruncarDecimales.Truncar(P.Interes());
                    Total = "$ "+TruncarDecimales.Truncar(P.TotalaRetornar());
                }
                else
                {
                    Capital = "U$S " + P.CapitalSolicitado;
                    Interes = "U$S " + TruncarDecimales.Truncar(P.Interes());
                    Total = "U$S " + TruncarDecimales.Truncar(P.TotalaRetornar());
                }
                listaVistaGrillas3a6.Add(new ClsVistaGrillas3a6(P.IdPrestamo, Capital, P.Plazo, TNA, 
                    Interes, Total));
            }
            return listaVistaGrillas3a6;
        }

        #endregion

        #region DESTRUCTOR

        ~ClsVistaGrillas3a6() {}

        #endregion

    }
}
