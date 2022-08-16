using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Negocio
{
    public class BLLPrueba
    {
        public string TestCX()
        {
            //creo un objeto de la clase acceso
            Acceso oAcceso = new Acceso();
            return oAcceso.TestConnection();

        }
    }
}
