/* MICROSOFT LEARN
 * No todos los miembros de una clase base los heredan las clases derivadas.
 * Los siguientes miembros no se heredan:
 *  =>  Constructores estáticos, que inicializan los datos estáticos de una clase.
 *  =>  Constructores de instancias, a los que se llama para crear una nueva
 *      instancia de la clase. Cada clase debe definir sus propios constructores.
 *  =>  Finalizadores, llamados por el recolector de elementos no utilizados en
 *      tiempo de ejecución para destruir instancias de una clase. */


using System;


// TODO => Conciliar Herencia

namespace Integrador
{
    public class OrdenEventArgs: EventArgs
    {
        public OrdenEventArgs(Cliente pEnEjecucion, Cliente pObj, int pValorDevuelto)
        {
            EnEjecucion = pEnEjecucion;
            Obj = pObj;
            ValorDevuelto = pValorDevuelto;
        }
        public Cliente EnEjecucion { get; set; }
        public Cliente Obj { get; set; }
        public int ValorDevuelto { get; set; }
    }
}

