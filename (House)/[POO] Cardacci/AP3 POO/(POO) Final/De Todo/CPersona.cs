using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Todo
{
    public class CPersona
    {
        private List<Auto> ListaAutosPersona;

        public List<Auto> RetornaListaClonada()
        {
            List<Auto> ListaClonada = new List<Auto>();
            foreach(Auto A in ListaAutosPersona)
            {
                ListaClonada.Add((Auto)A.Clone());
            }

            return ListaClonada;
        }
        public IEnumerable RetornaAnonimo()
        {
            var x = from A in ListaAutosPersona
                    select new
                    {
                        MarcaAuto = A.Marca,
                        ModeloAuto = A.Modelo
                    };
            return x.ToList();
        }
    }
}
