using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using MPP;


namespace BLL
{
    public class BLLTarjetaInternacional : BLLTarjeta, IGestor<BETarjetaInternacional>
    {
        public BLLTarjetaInternacional()
        {
            oMPPTI = new MPPTarjetaInternacional();
        }
       
        MPPTarjetaInternacional oMPPTI;

        #region "Metodos"
        public override double AplicarDescuento(double importe)
        {
            //Aplica descuento con polimorfismo
            return (importe * 0.30);
           
        }

        public bool Baja(BETarjetaInternacional Objeto)
        {
            return oMPPTI.Baja(Objeto);
        }

        public bool Guardar(BETarjetaInternacional Objeto)
        {
            return oMPPTI.Guardar(Objeto);
        }

        public BETarjetaInternacional ListarObjeto(BETarjetaInternacional Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarjetaInternacional> ListarTodo()
        {
            return oMPPTI.ListarTodo();
        }
        #endregion
    }
}
