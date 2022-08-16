using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEMateria: Entidad
    {
        #region "Propiedades"
        //propiedades de Materia

     
        public string Materia { get; set; }


        #endregion

        #region "Metodos"

        public override string ToString()
        {
            return Codigo + " " + Materia;
        }

        #endregion
    }
}
