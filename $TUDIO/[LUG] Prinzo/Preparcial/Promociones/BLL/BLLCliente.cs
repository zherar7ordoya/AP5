using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using MPP;

namespace BLL
{
    public class BLLCliente : IGestor<BECliente>
    {
        #region "Constructor"
        public BLLCliente()
        {
            oMPPCliente = new MPPCliente();
        }
        MPPCliente oMPPCliente;
        #endregion

        #region "Metodos"
        public bool Baja(BECliente Objeto)
        {
            return oMPPCliente.Baja(Objeto);
        }

        public bool Guardar(BECliente Objeto)
        {
            return oMPPCliente.Guardar(Objeto);
        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> ListarTodo()
        {
            return oMPPCliente.ListarTodo();
        }
        #endregion
    }
}
