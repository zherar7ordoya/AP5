using System;

namespace SistemaDeCobros
{
    public class CCobroNormal : CCobro
    {
        // Atributos
        // Propiedades
        // Constructores

        public CCobroNormal
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
            if(pDias > 0) { return pImporte * (decimal)0.01 * (decimal)pDias; }
            return 0;
        }
    }
}
