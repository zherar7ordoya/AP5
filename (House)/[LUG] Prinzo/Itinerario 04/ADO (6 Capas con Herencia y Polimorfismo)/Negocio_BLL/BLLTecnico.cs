using System;
using System.Collections.Generic;
using BE;
using Abstraccion;
using MPP;

namespace Negocio_BLL
{

    public class BLLTecnico : IGestor<TecnicoBE>
    {
        public BLLTecnico()
        {
            oMPPTec = new MPPTecnico();
        }

       MPPTecnico oMPPTec;

        public List<TecnicoBE> ListarTodo()
        {
            return oMPPTec.ListarTodo();
        }

        public bool Baja(TecnicoBE Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(TecnicoBE oBETec)
        {
            return oMPPTec.Guardar(oBETec);
        }

        public TecnicoBE ListarObjeto(TecnicoBE Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
