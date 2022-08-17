using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_C
{
  public class ListaItems
    {
        object mValor;
        string mTexto;
         public ListaItems(object pValor, string pTexto)
        {  mValor = pValor;
           mTexto = pTexto;
        }

        public object Value 
        {  get { return mValor; } }

        public string Text
        { get { return mTexto; } }

        #region "Sobrecarga de operadores"

        //SOBRECARGA DE OPERADORES "=" , "<>" y "+"
        //PERMITE EFECTUAR OPERACIONES ENTRE OBJETOS LISTAITEM (PARA LOS CUALES NO ESTA PREVISTA LA
        //OPERACION DE IGUALDAD, DESIGUALDAD Y SUMA)
        //DE ESTA FORMA SE LE DICE AL CLR COMO ACTUAR EN CASO DE PRESENCIA DE ESTOS OPERADORES

        //PARA QUE UN OBJETO LISTAITEM SEA IGUAL QUE OTRO, DEBEN SER IGUALES SU VALOR Y SU TEXTO
        public static bool operator ==(ListaItems pListItem1, ListaItems pListItem2)
        {
            return pListItem1.Value == pListItem2.Value & pListItem1.Text == pListItem2.Text;
        }
        //PARA QUE UN OBJETO LISTAITEM SEA DISTINTO QUE OTRO, DEBE SER DESIGUAL SU VALOR O SU TEXTO
      public static bool operator != (ListaItems pListItem1, ListaItems pListItem2)
        {
            return pListItem1.Value != pListItem2.Value | pListItem1.Text != pListItem2.Text;
        }

        //PARA SUMAR DOS OBJETOS LISTAITEM SE SUMAN Y CONCATENAN SU VALOR Y SU TEXTO
       public static ListaItems operator + (ListaItems a, ListaItems b)
        {
           
            return new ListaItems( (a + b).Value, a.Text + b.Text);
        }
        #endregion


    }
}
