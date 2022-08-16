using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Abstraccion;
using System.Data;
using System.Windows.Forms;

namespace MPP
{
    public class MPPTarjeta : IGestor<BETarjeta>
    {
        #region "Metodos"
        public bool Baja(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public BETarjeta ListarObjeto(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

     
        public List<BETarjeta> ListarTodo()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
