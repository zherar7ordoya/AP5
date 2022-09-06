using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace Negocio
{
    public class BLLMateria
    {
        //Metodos de la clase Materia

        #region "Metodos"

        public BLLMateria()
        {
            oMPPMat = new MPPMateria();
        }

        MPPMateria oMPPMat;

        public List<BEMateria> CargarListaMateria()
        {
            return oMPPMat.CargarListaMateria();
        }


        //Metodo generico para alta y modificacion depende la operacion y consulta

        public bool Guardar(BEMateria oBEMat)
        {
            return oMPPMat.Guardar(oBEMat);
        }

        public bool Baja(BEMateria oBEMat)
        {
            return oMPPMat.Baja(oBEMat);
        }



        #endregion
    }
}

