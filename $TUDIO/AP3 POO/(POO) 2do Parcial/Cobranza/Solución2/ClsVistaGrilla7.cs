using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsVistaGrilla7
    {
        #region CAMPOS
        private List<ClsVistaGrilla7> ListaVistaGrilla7;
        #endregion

        #region PROPIEDADES

        //pongo la mayoria de las propiedades string para darle formato en la vista
        public string Id  { get; set; }
        public string Capital { get; set; }
        public int Plazo { get; set; }
        public string TNA { get; set; }
        public string Interes { get; set; }
        public string TotalaRetornar { get; set; }
        public int DiasAtraso { get; set; }

        #endregion

        #region CONSTRUCTORES

        public ClsVistaGrilla7()
        {
            ListaVistaGrilla7 = new List<ClsVistaGrilla7>();
        }
        public ClsVistaGrilla7(string pId, string pCapital,int pPlazo, string pTasa, string pInteres, string pTotalaRetornar,int pDiasAtraso)
        {
            Id = pId;
            Capital = pCapital;
            Plazo = pPlazo;
            TNA = pTasa;
            Interes = pInteres;
            TotalaRetornar = pTotalaRetornar;
            DiasAtraso = pDiasAtraso;
        }

        #endregion

        #region METODOS

        //llega por referencia una lista de prestamos y la fecha actual para poder caluclar los dias de atraso
        public List<ClsVistaGrilla7> RetornaListaVistaGrilla7(List<ClsPrestamo> pLP,DateTime pFechaActual)
        {
            ListaVistaGrilla7.Clear();
            foreach(ClsPrestamo P in pLP)
            {
                TNA = P.TasaAnual + " %";
                //Le doy formato a las propiedades segun el tipo de prestamo
                if (P is ClsPrestamoPesos)
                {
                    Capital = "$ " + P.CapitalSolicitado;
                    Interes = "$" + TruncarDecimales.Truncar(P.Interes());
                    TotalaRetornar = "$ " + TruncarDecimales.Truncar(P.TotalaRetornar());
                }
                else
                {
                    Capital = "U$S " + P.CapitalSolicitado;
                    Interes = "U$S " + TruncarDecimales.Truncar(P.Interes());
                    TotalaRetornar = "U$S " + TruncarDecimales.Truncar(P.TotalaRetornar());
                }
                //Calculo los dias de atraso
                DiasAtraso = (pFechaActual - P.FechaDevolucion).Days;
                if (P.Pagado == true) DiasAtraso = 0;

                ListaVistaGrilla7.Add(new ClsVistaGrilla7(P.IdPrestamo, Capital, P.Plazo, TNA, Interes, TotalaRetornar, DiasAtraso));
            }
            return ListaVistaGrilla7;
        }

        #endregion

        #region DESTRUCTOR 

        ~ClsVistaGrilla7() {   }

        #endregion

    }
}
