using System;

namespace SistemaDeCobros
{
    public class CCobroEspecial : CCobro
    {
        // Atributos
        // Propiedades
        // Constructores

        public CCobroEspecial
            (
            string   pCliente,
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte
            )
            : base
                  (
                  pCliente,
                  pTipo,
                  pCodigo,
                  pNombreCobro,
                  pFechaVencimiento,
                  pImporte
                  )
        { }

        // Métodos

        public override decimal CalcularRecargo(decimal pImporte, double pDias)
        { 
            if (pDias > 0)
            {
                return (pImporte * (decimal)0.02 * (decimal)pDias) + 1000;
            }
            return 0;
        }
    }
}
