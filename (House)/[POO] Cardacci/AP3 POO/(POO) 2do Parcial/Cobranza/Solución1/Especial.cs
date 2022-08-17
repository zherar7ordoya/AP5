using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUrbainskyAlexis
{
    sealed class Especial : Cobro , IDisposable, ICloneable
    {
        #region Constructores
        public Especial() : base()
        {
        }

        public Especial(int pCodigo, String pNombre, DateTime pFechaVencimiento, decimal pImporte, Cliente pCliente) : base(pCodigo, pNombre, pFechaVencimiento, pImporte, pCliente)
        {
        }
        #endregion

        #region Metodos
        public override decimal CalcularAdicionales()
        {
            TimeSpan difFechas = FechaVencimiento - DateTime.Today;
            int diferenciaDias = difFechas.Days * -1;

            if (diferenciaDias > 0)
            {
                decimal calculo = (((Importe * diferenciaDias) * 2) / 100) + 1000;

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
        ~Especial()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
                Console.WriteLine("El Cobro Especial ha Finalizado Codigo: " + Código + " Nombre:" + Nombre + " Importe: " + Importe);
            }
        }

        #endregion 
    }
}
