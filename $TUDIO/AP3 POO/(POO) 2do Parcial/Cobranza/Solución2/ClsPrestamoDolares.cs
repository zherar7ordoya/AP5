using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    public class ClsPrestamoDolares : ClsPrestamo
    {
        #region CAMPOS

        #endregion

        #region PROPIEDADES

        #endregion

        #region CONSTRUCTORES

        //Constructor vacío y con parámetros que heredan de la clase base.
        public ClsPrestamoDolares()  { }
        public ClsPrestamoDolares(string pIdPrestamo, double pCapitalSolicitado, double pTasa,int pPlazo, DateTime pFechaAdjudicacion, DateTime pFechaDevolucion, bool pPagado)
            : base(pIdPrestamo, pCapitalSolicitado,pTasa, pPlazo, pFechaAdjudicacion, pFechaDevolucion, pPagado)
        { }

        #endregion

        #region METODOS

        //Método polimorfico para calcular el Gasto Administrativo
        public override double GastoAdministrativo()
        {
            return CapitalSolicitado * 0.03;
        }

        /// <summary>
        /// Metodo polimórfico que calcula interés simple o compuesto según el caso
        /// </summary>   
        public override double Interes()
        {
            int dias = (FechaDevolucion - FechaAdjudicacion).Days;
            double TasaDiaria = TasaAnual / 365;
            //Como se trata de prestamo en dólares, calculo el interés simple         
            double TasaMensual = TasaAnual / 12;
            return CapitalSolicitado * (TasaDiaria / 100) * dias;                   
        }
        #endregion

        #region DESTRUCTOR 

        ~ClsPrestamoDolares() { }

        #endregion

    }
}
