using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    /// <summary>
    /// Excepcion para evitar las cadenas excesivamente largas.
    /// </summary>
    public class CadenaLargaException: Exception
    {

        #region PROPIEDADES
        //Declaro las propiedades que necesito pasarle al constructor
        public string Cadena { get; set; }
        public string NombreCampo { get; set; }
        public int Max { get; set; }

        #endregion

        #region CONSTRUCTORES

        //Le paso las variables al constructor. La cadena ingresada, el nombre del campo y la cantidad maxima de caracteres permitidos
        //Para poder personalizar el mensaje.
        public CadenaLargaException(string pCadena, string pCampo,int pMax)
        {
            Cadena = pCadena;
            NombreCampo = pCampo;
            Max = pMax;
        }

        #endregion

        #region METODOS

        //Mensaje personalizado
        public override string Message => "El campo " + NombreCampo + " tiene que ser menor a "+ Max + " caracteres"  +
            "\n\n Usted ingresó: " + Cadena.Length + " caracteres";

        #endregion

        #region DESTRUCTOR 

        ~CadenaLargaException() { }

        #endregion

    }
}
