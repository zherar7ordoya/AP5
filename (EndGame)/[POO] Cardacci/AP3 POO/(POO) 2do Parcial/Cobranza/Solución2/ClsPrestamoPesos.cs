using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsPrestamoPesos : ClsPrestamo
    {
        #region CAMPOS

        #endregion

        #region PROPIEDADES

        #endregion

        #region CONSTRUCTORES

        //Constructor vacío y con parámetros
        public ClsPrestamoPesos()  { }
        public ClsPrestamoPesos(string pIdPrestamo, double pCapitalSolicitado, double pTasa,int pPlazo, DateTime pFechaAdjudicacion, DateTime pFechaDevolucion, bool pPagado)
            : base(pIdPrestamo,pCapitalSolicitado,pTasa, pPlazo, pFechaAdjudicacion,pFechaDevolucion,pPagado)
        {  }
        #endregion

        #region METODOS

        //Metodo polimorfico para calcular el gasto administrativo
        public override double GastoAdministrativo()
        {
            return CapitalSolicitado * 0.02;
        }

        /// <summary>
        /// Metodo polimórfico que calcula interés simple o compuesto según el caso
        /// </summary>     
        public override double Interes()
        {
            int dias = (FechaDevolucion - FechaAdjudicacion).Days;
            double TasaDiaria = TasaAnual / 365;
  
            ////Como se trata de prestamo en pesos, calculo el interés compuesto
            
            double Interes = CapitalSolicitado * (((double)Math.Pow((1 + TasaDiaria / 100), dias) - 1));
            return Interes;
        }

        #endregion

        #region DESTRUCTOR 

        ~ClsPrestamoPesos() {  }

        #endregion

    }
}
