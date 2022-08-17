using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    //Excepcion personalizada que recibe un parametro del tipo T, donde T tiene que ser struct. 
    //Lo uso para ejemplificar GENERICS
    class NegativoException<T> : Exception where T : struct
    {    

        #region PROPIEDADES

        //Declaro una variable Numero del tipo T
        public T Numero { get; set; }

        #endregion

        #region CONSTRUCTORES

        //Cnstructor con un parametro del tipo T 
        public NegativoException(T pNumero)
        {
            Numero = pNumero;
        }

        #endregion

        #region METODOS

        //sobrecarga del mensaje de la excepcion. Mostrando el numero que me llega por referencia
        public override string Message => "No se pueden ingresar valores negativos. Usted ingresó: " + Numero;

        #endregion

        #region DESTRUCTOR 

        ~NegativoException() {  }

        #endregion

    }
}
