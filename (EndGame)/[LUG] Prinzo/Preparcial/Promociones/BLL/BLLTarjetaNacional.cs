using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Abstraccion;

namespace BLL
{
    public class BLLTarjetaNacional : BLLTarjeta, IGestor<BETarjetaNacional>
    {
        public BLLTarjetaNacional()
        {
            oMPPTN = new MPPTarjetaNacional();
        }
        MPPTarjetaNacional oMPPTN;

        #region "Metodos"
        public override double AplicarDescuento(double importe)
        {
            //Aplica descuento con polimorfismo
            return (importe * 0.25);
        }

        public bool Baja(BETarjetaNacional Objeto)
        {
            return oMPPTN.Baja(Objeto);
        }

        public bool Guardar(BETarjetaNacional Objeto)
        {
            return oMPPTN.Guardar(Objeto);
        }

        public BETarjetaNacional ListarObjeto(BETarjetaNacional Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarjetaNacional> ListarTodo()
        {
            return oMPPTN.ListarTodo();
        }
        #endregion
    }
}
