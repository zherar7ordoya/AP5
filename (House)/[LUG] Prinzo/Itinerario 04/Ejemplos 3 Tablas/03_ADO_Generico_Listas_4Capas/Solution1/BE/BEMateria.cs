using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEMateria
    {
        #region "Propiedades"
        //propiedades de Materia

        public int Codigo { get; set; }
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
