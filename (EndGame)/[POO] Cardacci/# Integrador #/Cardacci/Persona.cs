/* MICROSOFT LEARN
 * No todos los miembros de una clase base los heredan las clases derivadas.
 * Los siguientes miembros no se heredan:
 *  =>  Constructores estáticos, que inicializan los datos estáticos de una clase.
 *  =>  Constructores de instancias, a los que se llama para crear una nueva
 *      instancia de la clase. Cada clase debe definir sus propios constructores.
 *  =>  Finalizadores, llamados por el recolector de elementos no utilizados en
 *      tiempo de ejecución para destruir instancias de una clase. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    public abstract class Persona
    {
        #region Propiedades
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region Metodos
        public abstract void AgregarAuto(Auto pAuto);
        public abstract void BorrarAuto(Auto pAuto);
        public abstract void ModificarAuto(Auto pAuto);
        public abstract List<Auto> RetornaListaAutos();
        #endregion
    }
}
