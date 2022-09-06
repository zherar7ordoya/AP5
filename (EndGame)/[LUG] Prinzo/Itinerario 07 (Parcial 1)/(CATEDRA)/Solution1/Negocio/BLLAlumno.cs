using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencia a las capas BE y MAPPER
using BE;
using MPP;
//referencia a la capa de abstraccion
using Abstraccion;

namespace Negocio
{
    public class BLLAlumno : IGestor<BEAlumno>
    {

        public BLLAlumno()
        {
            oMPPAlu = new MPPAlumno();
        }


        MPPAlumno oMPPAlu;
        public List<BEAlumno> ListarTodo()
        {
            return oMPPAlu.ListarTodo();
        }

        public bool Guardar(BEAlumno oBEAlu)
        {
            return oMPPAlu.Guardar(oBEAlu);
        }
             

        public bool Baja(BEAlumno oBEAlu)
        {
            return oMPPAlu.Baja(oBEAlu);
        }

        public bool AgregarAlumno_Materia(BEAlumno oBEAlu, BEMateria oBEMat)
        {

            return oMPPAlu.AgregarAlumno_Materia(oBEAlu, oBEMat);
        }

        public bool QuitarAlumno_Materia(BEAlumno oBEAlu, BEMateria oBEMat)
        {

            return oMPPAlu.QuitarAlumno_Materia(oBEAlu, oBEMat);
        }

        public BEAlumno ListarObjeto(BEAlumno Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
