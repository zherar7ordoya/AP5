using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    /// <summary>
    /// Clase generica para Clonar de manera superficial Listas de cualquier tipo, 
    /// Siempre y cuando el Tipo implemente la interface ICloneable
    /// </summary>
    public class ClonaLista<T> where T : ICloneable
    {
        #region METODOS

        public static List<T> ClonarLista(List<T> pLista)
        {
           //Instancio una Lista del tipo T
            List<T> ListaClonada = new List<T>();
            //Por cada x del tipo T en la Lista
            foreach (T x in pLista)
            {
                //Voy clonando cada x, ya que T es ICloneable
                ListaClonada.Add((T)x.Clone());
            }
            //retorno la lista clonada
            return ListaClonada;
        }

        #endregion

        #region DESTRUCTOR

        ~ClonaLista() {}

        #endregion

    }
}
