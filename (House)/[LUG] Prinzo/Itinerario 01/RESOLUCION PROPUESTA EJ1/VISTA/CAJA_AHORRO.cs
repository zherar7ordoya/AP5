using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA
{
    public class CAJA_AHORRO: CUENTA
    {
        public decimal LIMITE_EXTRACCION { get; set; }

        public override void EXTRAER(decimal IMPORTE)
        {
            if (IMPORTE <= SALDO && IMPORTE <= LIMITE_EXTRACCION)
            {
                SALDO -= IMPORTE;
            }
            else
            {
                throw new Exception("El importe solicitado para la extracción no puede ser mayor que el saldo disponible ni superar el monto máximo de extracción");
            }
        }
    }
}
