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
        List<Auto> _listaAuto = new List<Auto> { };

        #region Propiedades
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Auto> ListaAuto { get { return _listaAuto; } }

        #endregion

        #region Metodos
        public void AgregarAuto(Auto pAuto)
        { _listaAuto.Add(new Auto(pAuto.Patente, pAuto.Marca, pAuto.Modelo, pAuto.Axo, pAuto.Precio, pAuto.Get_Dueno())); }

        public void BorrarAuto(Auto pAuto)
        {
            try
            {
                // Ubica el auto en la lista de autos de la persona a partir de las patente enviada en pAuto
                Auto _auxAuto = _listaAuto.Find(x => x.Patente == pAuto.Patente);
                if (_auxAuto != null)
                {
                    // Pasa a null el dueño del auto el la lista de autos de  la persona
                    _auxAuto.Set_Dueno(null);
                    // Quita el auto de la lista de autos de la Persona
                    _listaAuto.Remove(_auxAuto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarAuto(Auto pAuto)
        {
            try
            {
                Auto _auxAuto = _listaAuto.Find(x => x.Patente == pAuto.Patente);
                _auxAuto.Patente = pAuto.Patente;
                _auxAuto.Marca = pAuto.Marca;
                _auxAuto.Modelo = pAuto.Modelo;
                _auxAuto.Axo = pAuto.Axo;
                _auxAuto.Precio = pAuto.Precio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Auto> RetornaListaAutos()
        {
            List<Auto> _aux_listaAuto = new List<Auto>();
            try
            {
                if (_listaAuto == null) { return null; }
                foreach (Auto _a in _listaAuto)
                {
                    _aux_listaAuto.Add(new Auto(_a.Patente, _a.Marca, _a.Modelo, _a.Axo, _a.Precio,
                                               _a.Get_Dueno() != null ? new Cliente(_a.Get_Dueno().DNI, _a.Get_Dueno().Nombre, _a.Get_Dueno().Apellido) : null));
                }
            }
            catch (Exception ex) { throw ex; }
            return _aux_listaAuto;
        }
        #endregion

    }
}
