using System;

namespace SistemaDeCobros
{
    public abstract class CCobro
    {
        // Atributos
        private string   cliente;
        private string   tipo;
        private int      codigo;
        private string   nombreCobro;
        private DateTime fechaVencimiento;
        private decimal  importe;

        // Propiedades
        public string   Cliente             { get => cliente;           set => cliente = value; }
        public string   Tipo                { get => tipo;                                      }
        public int      Codigo              { get => codigo;                                    }
        public string   NombreCobro         { get => nombreCobro;                               }
        public DateTime FechaVencimiento    { get => fechaVencimiento;                          }
        public decimal  Importe             { get => importe;                                   }

        // Constructores
        public CCobro
            (
            string   pCliente,
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte
            )
        {
            cliente          = pCliente;
            tipo             = pTipo;
            codigo           = pCodigo;
            nombreCobro      = pNombreCobro;
            fechaVencimiento = pFechaVencimiento;
            importe          = pImporte;
        }

        // Métodos
        public int CalcularRetrasoEnDias
            (DateTime pDesde,
            DateTime  pHasta)
        { return (int) Math.Ceiling((pHasta - pDesde).TotalDays); }

        public abstract decimal CalcularRecargo(decimal pImporte, double pDias);
    }
}
