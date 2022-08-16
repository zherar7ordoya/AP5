using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace Negocio
{
   public class BLLLocalidad
    {

        #region "Metodos Localidad BLL"

        public BLLLocalidad()
        {
            oMMLoc = new MPPLocalidad();
        }

        MPPLocalidad oMMLoc;
        public List<BELocalidad> CargarListaLocalidades()
        {
            return oMMLoc.CargarListaLocalidades();
        }

     //Metodo para guardar si es alta o modificacion
        public bool Guardar (BELocalidad oBELocalidad)
        {   
            return oMMLoc.Guardar(oBELocalidad);
        }
        public bool Baja(BELocalidad oBELocalidad)
        {
            return oMMLoc.Baja(oBELocalidad);
        }

#endregion
    }

}
