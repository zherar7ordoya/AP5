namespace VISTA
{
  public abstract class CUENTA
    {
        #region PROPIEDADES
        public int CODIGO { get; set; }
        public CLIENTE TITULAR { get; set; }
        public decimal SALDO { get; set; }
        #endregion
        #region METODOS
        public void DEPOSITAR(decimal IMPORTE)
        {
            SALDO += IMPORTE;
        }
        public abstract void EXTRAER(decimal IMPORTE);
        #endregion
    }
}
