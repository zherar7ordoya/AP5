using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    //Excepcion para evitar cadenas vacias
    public  class CadenaVaciaException : Exception
    {

        #region PROPIEDADES

        //declaro la propiedad 
        public string NombreVariable { get; set; }

        #endregion

        #region CONSTRUCTORES
        //Le paso al constructor el nombre de la variable
        public CadenaVaciaException(string pNombreVariable)
        {
            NombreVariable = pNombreVariable;
        }

        #endregion

        #region METODOS

        public override string Message => "El campo " + NombreVariable + " no puede quedar vacío";

        #endregion

        #region DESTRUCTOR

        ~CadenaVaciaException() { }

        #endregion
    }
}
