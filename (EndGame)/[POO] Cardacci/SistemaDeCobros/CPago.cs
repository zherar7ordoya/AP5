using System;

namespace SistemaDeCobros
{
    public class CPago : IComparable
    {
        // Atributos
        private string   cliente;
        private string   tipo;
        private int      codigo;
        private string   nombreCobro;
        private DateTime fechaVencimiento;
        private decimal  importe;
        private readonly decimal  recargo;
        private decimal  total;

        // Propiedades
        public string   Cliente          { get => cliente;          set => cliente          = value; }
        public string   Tipo             { get => tipo;             set => tipo             = value; }
        public int      Codigo           { get => codigo;           set => codigo           = value; }
        public string   NombreCobro      { get => nombreCobro;      set => nombreCobro      = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public decimal  Importe          { get => importe;          set => importe          = value; }
        public decimal  Recargo          { get => recargo; }
        public decimal  Total
        { 
            get => total;
            set
            {
                total = value;
                OnTotalChanged?.Invoke(this, total);
            }
        }
        public event EventHandler<decimal> OnTotalChanged;

        // Constructores
        public CPago
            (
            string   pCliente,
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            decimal  pRecargo,
            decimal  pTotal
            )
        {
            cliente          = pCliente;
            Tipo             = pTipo;
            Codigo           = pCodigo;
            NombreCobro      = pNombreCobro;
            FechaVencimiento = pFechaVencimiento;
            Importe          = pImporte;
            recargo          = pRecargo;
            total            = pTotal;
        }
        
        // Métodos
        public int CompareTo(object obj)
        {
            CPago x = (CPago)obj;
            if(Total > x.Total) { return 1;  }
            if(Total < x.Total) { return -1; }
            return 0;
        }
    }
}
