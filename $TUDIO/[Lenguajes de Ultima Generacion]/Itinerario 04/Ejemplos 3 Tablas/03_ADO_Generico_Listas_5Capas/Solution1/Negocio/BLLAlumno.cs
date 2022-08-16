using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencia a las capas BE y MAPPER
using BE;
using MPP;

namespace Negocio
{
    public class BLLAlumno
    {

        public BLLAlumno()
        {
            oMPPAlu = new MPPAlumno();
        }


        MPPAlumno oMPPAlu;
        public List<BEAlumno> CargarListaAlumnos()
        {
            return oMPPAlu.CargarListaAlumnos();
        }

        public bool Guardar(BEAlumno oBEAlu)
        {
            return oMPPAlu.Guardar(oBEAlu);
        }
             

        public bool BajaAlumno(BEAlumno oBEAlu)
        {
            return oMPPAlu.BajaAlumno(oBEAlu);
        }

        public bool AgregarAlumno_Materia(BEAlumno oBEAlu, BEMateria oBEMat)
        {

            return oMPPAlu.AgregarAlumno_Materia(oBEAlu, oBEMat);
        }

        public bool QuitarAlumno_Materia(BEAlumno oBEAlu, BEMateria oBEMat)
        {

            return oMPPAlu.QuitarAlumno_Materia(oBEAlu, oBEMat);
        }

       
    }
}
