using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BANCO oBANCO = BANCO.OBTENER_INSTANCIA();
            CLIENTE oCLIENTE = new CLIENTE { DNI = 12333444, EMAIL = "gdorigo", FECHA_NACIMIENTO = DateTime.Parse("26/07/1980"), NOMBRE = "GASTON DORIGO" };
            oBANCO.CLIENTES.Add(oCLIENTE);
            CAJA_AHORRO oCAJA_AHORRO = new CAJA_AHORRO { CODIGO = 123, LIMITE_EXTRACCION = 2000, SALDO = 0, TITULAR = oCLIENTE };
            oBANCO.CUENTAS.Add(oCAJA_AHORRO);
            Application.Run(new frmINICIAL());
        }
    }
}
