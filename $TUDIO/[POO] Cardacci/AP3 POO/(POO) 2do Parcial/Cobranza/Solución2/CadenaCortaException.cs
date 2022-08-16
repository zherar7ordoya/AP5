using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    /// <summary>
    /// varifico que la cadena ingresada tenga el minimo de caracteres permitidos.
    /// </summary>
    class CadenaCortaException : Exception
    {

        #region PROPIEDADES

        //Declaro las propiedades que necesito mostrar
        public string CadenaIngresada { get; set; }
        public string NombreCampo { get; set; }

        #endregion

        #region CONSTRUCTORES
        //Le paso por referencia la cadena en cuestión y el nombre del campo. Para mostrarlo en el mensaje personalizado
        public CadenaCortaException(string pCadena, string pCampo)
        {
            CadenaIngresada = pCadena;
            NombreCampo = pCampo;
        }

        #endregion

        #region METODOS

        //Mensaje personalizado
        public override string Message => "El campo " + NombreCampo + " tiene que ser mayor a 3 caracteres. " +
            "\n\n Usted ingresó: " + CadenaIngresada;

        #endregion

        #region DESTRUCTOR

        ~CadenaCortaException()  { }

        #endregion

    }
}
