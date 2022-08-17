using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using MPP;
using System.Collections;
using Abstraccion;

namespace BLL
{
    public class BLLLocalidad: IGestor<BELocalidad>
    {

        public BLLLocalidad()
        //instancio el objeto mapper en el constructor de la clase localidad
        { oMPPLoc = new MPPLocalidad(); }

        MPPLocalidad oMPPLoc;
        public List<BELocalidad> ListarTodo()
        {
    
            return oMPPLoc.ListarTodo();


        }


        public bool Guardar(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BELocalidad oBELocalidad)
        {
            return oMPPLoc.Baja(oBELocalidad);
        }

 
        public BELocalidad ListarObjeto(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

       
    }
}
