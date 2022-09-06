using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUrbainskyAlexis
{
    sealed class Normal : Cobro, IDisposable, ICloneable
    {
        #region Constructores
        public Normal() : base (){ 
        }

        public Normal(int pCodigo, String pNombre, DateTime pFechaVencimiento, decimal pImporte, Cliente pCliente) : base(pCodigo, pNombre,pFechaVencimiento, pImporte, pCliente)
        {
        }
        #endregion

        #region Metodos
        public override decimal CalcularAdicionales()
        {
            TimeSpan difFechas = FechaVencimiento - DateTime.Today;
            int  diferenciaDias = difFechas.Days * -1;

            if (diferenciaDias > 0)
            {
                decimal calculo = (Importe * diferenciaDias) / 100;
                AsignarImporteTotal(calculo + Importe);

                return calculo;
            } else {
                AsignarImporteTotal(Importe);
                return 0;
            }
        }
        #endregion

        #region Destructor
        bool _DisposeOk = false;
        ~Normal()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
                Console.WriteLine("El Cobro Normal ha Finalizado Codigo: " + Código + " Nombre:" + Nombre + " Importe: " + Importe);
            }
        }

        #endregion 
    }

}
