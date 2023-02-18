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
        private decimal  recargo;
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
                this.total = value;
                this.OnTotalChanged?.Invoke(this, this.total);
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
            this.cliente          = pCliente;
            this.Tipo             = pTipo;
            this.Codigo           = pCodigo;
            this.NombreCobro      = pNombreCobro;
            this.FechaVencimiento = pFechaVencimiento;
            this.Importe          = pImporte;
            this.recargo          = pRecargo;
            this.total            = pTotal;
        }
        
        // Métodos
        public int CompareTo(object obj)
        {
            CPago x = (CPago)obj;
            if(Total > x.Total) { return 1; }
            if(Total < x.Total) { return -1; }
            return 0;
        }
    }
}
