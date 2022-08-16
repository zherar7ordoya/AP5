using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
//referecnia a la capa abstraccion
using Abstraccion;

namespace Negocio
{
   public class BLLLocalidad: IGestor<BELocalidad>
    {

        #region "Metodos Localidad BLL"

        public BLLLocalidad()
        {
            oMMLoc = new MPPLocalidad();
        }

        MPPLocalidad oMMLoc;
        public List<BELocalidad>ListarTodo()
        {
            return oMMLoc.ListarTodo();
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

        public BELocalidad ListarObjeto(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
