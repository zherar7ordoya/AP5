using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;

namespace MPP
{
    public class MPPPrueba
    {
        public string TestCX()
        {
            //creo un objeto de la clase acceso
            Acceso oAcceso = new Acceso();
            return oAcceso.TestConnection();

        }
    }
}
