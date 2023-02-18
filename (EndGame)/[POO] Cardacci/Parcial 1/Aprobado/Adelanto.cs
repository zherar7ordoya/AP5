using System;

namespace PrimerParcialPOO
{
    class Adelanto
    {
        public string Codigo { get; set; } //Propiedad de codigo
        public DateTime Otorgamiento  { get; set; } //Propiedad de cuando se otorga el adelanto
        public DateTime Cancelacion { get; set; } //Propiedad de cuando se cancela el adelanto
        public decimal ImpOtorgado { get; set; } //Propiedad del importe otorgado
        public decimal ImpPagado { get; set; } //Propiedad del importe pagado
        public decimal Beneficio { get; set; } //Propiedad del descuento al pagar
        public decimal SueldoAdeudado { get; set; } // Propiedad del sueldo adeudo
        public int Empleado { get; set; } //Propiedad del numero de legajo del empleado
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Adelanto() { }
        /// <summary>
        /// Constructor pasando todos los parametros menos el del legajo de empleado
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="otorgamineto"></param>
        /// <param name="cancelacion"></param>
        /// <param name="impOtorgado"></param>
        /// <param name="impPagado"></param>
        /// <param name="beneficio"></param>
        /// <param name="sueldoAdeudado"></param>
        public Adelanto(string codigo, DateTime otorgamineto, DateTime cancelacion, decimal impOtorgado, decimal impPagado, decimal beneficio, 
                        decimal sueldoAdeudado): this()
        {
            Codigo = codigo;
            Otorgamiento = otorgamineto;
            Cancelacion = cancelacion;
            ImpOtorgado = impOtorgado;
            ImpPagado = impPagado;
            Beneficio = beneficio;
            SueldoAdeudado = sueldoAdeudado;
        }
        /// <summary>
        /// Constructor con parametro de empleado tambien
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="otorgamineto"></param>
        /// <param name="cancelacion"></param>
        /// <param name="impOtorgado"></param>
        /// <param name="impPagado"></param>
        /// <param name="beneficio"></param>
        /// <param name="sueldoAdeudado"></param>
        /// <param name="empleado"></param>
        public Adelanto(string codigo, DateTime otorgamineto, DateTime cancelacion, decimal impOtorgado, decimal impPagado, decimal beneficio,
                       decimal sueldoAdeudado, int empleado) : this()
        {
           
            Codigo = codigo;
            Otorgamiento = otorgamineto;
            Cancelacion = cancelacion;
            ImpOtorgado = impOtorgado;
            ImpPagado = impPagado;
            Beneficio = beneficio;
            SueldoAdeudado = sueldoAdeudado;
            Empleado = empleado;
         }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Adelanto()
        {

        }

    }
}
