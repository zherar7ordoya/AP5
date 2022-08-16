using System.Collections.Generic;

namespace PARCIAL_1
{
    class CEmpleado
    {
        private uint            legajo;
        private string          tipo;
        private string          nombre;
        private string          apellido;
        private decimal         sueldo;
        private List<CAdelanto> adelantos;
        private decimal         acumulador;
        private int             contador;

        public   uint            Legajo     { get => legajo;     set => legajo     = value; }
        public   string          Tipo       { get => tipo;       set => tipo       = value; }
        public   string          Nombre     { get => nombre;     set => nombre     = value; }
        public   string          Apellido   { get => apellido;   set => apellido   = value; }
        public   decimal         Sueldo     { get => sueldo;     set => sueldo     = value; }
        internal List<CAdelanto> Adelantos  { get => adelantos;  set => adelantos  = value; }
        public   decimal         Acumulador { get => acumulador; set => acumulador = value; }
        public   int             Contador   { get => contador;   set => contador   = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo">4 dígitos</param>
        /// <param name="tipo">Operario, Administrativo o Directivo</param>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del operario</param>
        /// <param name="sueldo">Sueldo del empleado</param>
        public CEmpleado
            (
            uint    legajo,
            string  tipo,
            string  nombre,
            string  apellido,
            decimal sueldo
            )
        {
            this.legajo     = legajo;
            this.tipo       = tipo;
            this.nombre     = nombre;
            this.apellido   = apellido;
            this.sueldo     = sueldo;
            this.Adelantos  = new List<CAdelanto>();
            this.acumulador = 0;
            this.contador   = 0;
        }


        public void AsignarAdelanto(CAdelanto adelanto)
        {
            adelantos.Add(new CAdelanto
                (
                adelanto.CodigoAlfanumerico,
                adelanto.FechaOtorgamiento,
                adelanto.ImporteOtorgado,
                adelanto.RetornarEmpleado()
                ));
        }
    }
}
