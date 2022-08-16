using System;
using System.Windows.Forms;

namespace PARCIAL_1
{
    class CAdelanto : IAdelanto
    {
        private string    codigoAlfanumerico;
        private DateTime  fechaOtorgamiento;
        private DateTime  fechaCancelacion;
        private decimal   importeOtorgado;
        private decimal   importePagado;
        private decimal   beneficio;
        private decimal   saldoAdeudado;
        private CEmpleado empleado;
        private bool      bloqueado;

        public string    CodigoAlfanumerico { get => codigoAlfanumerico; set => codigoAlfanumerico = value; }
        public DateTime  FechaOtorgamiento  { get => fechaOtorgamiento;  set => fechaOtorgamiento  = value; }
        public DateTime  FechaCancelacion   { get => fechaCancelacion;   set => fechaCancelacion   = value; }
        public decimal   ImporteOtorgado    { get => importeOtorgado;    set => importeOtorgado    = value; }
        public decimal   ImportePagado      { get => importePagado;      set => importePagado      = value; }
        public decimal   Beneficio          { get => beneficio;          set => beneficio          = value; }
        public decimal   SaldoAdeudado      { get => saldoAdeudado;      set => saldoAdeudado      = value; }
        public CEmpleado Empleado           { get => empleado;           set => empleado           = value; }
        public bool      Bloqueado          { get => bloqueado;          set => bloqueado          = value; }

        /// <summary>
        /// Constructor de alta de adelanto.
        /// </summary>
        /// <param name="codigo">Alfanumérico para el adelanto de formato 4 decimales seguido de 4 caracteres.</param>
        /// <param name="fecha">Fecha en que se otorga el adelanto de formato DD/MM/AAAA.</param>
        /// <param name="importe">Importe en pesos del adelanto.</param>
        public CAdelanto
            (
            string   codigo,
            DateTime fecha,
            decimal  importe
            )
        {
            this.codigoAlfanumerico = codigo;
            this.fechaOtorgamiento  = fecha;
            this.importeOtorgado    = importe;
        }

        /// <summary>
        /// Contructor de asignación de adelanto a empleado.
        /// </summary>
        /// <param name="codigo">Código alfanumerico 4 carácteres 4 decimales.</param>
        /// <param name="fecha_otorgamiento">Fecha en que se otorga el adelanto.</param>
        /// <param name="importe_otorgado">Importe del adelanto.</param>
        /// <param name="empleado">Empleado al que se le asigna el adelanto.</param>
        public CAdelanto
            (
            string    codigo,
            DateTime  fecha_otorgamiento,
            decimal   importe_otorgado,
            CEmpleado empleado
            )
        {
            this.CodigoAlfanumerico = codigo;
            this.fechaOtorgamiento  = fecha_otorgamiento;
            this.importeOtorgado    = importe_otorgado;
            this.empleado           = empleado;
        }

        public void AsignarEmpleado(CEmpleado empleado)
        {
            this.empleado = new CEmpleado
                (
                empleado.Legajo,
                empleado.Tipo,
                empleado.Nombre,
                empleado.Apellido,
                empleado.Sueldo
                );
        }

        public CEmpleado RetornarEmpleado()
        {
            return empleado;
        }

    }
}
