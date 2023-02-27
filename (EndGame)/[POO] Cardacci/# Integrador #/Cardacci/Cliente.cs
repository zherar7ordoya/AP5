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
    

    public class Cliente : Persona, IDisposable, IComparable
    {
        #region Atributos
        bool _paso = false;
        List<Auto> _listaAuto;
        public event EventHandler<DestructorEventArgs> DestructorEventHandler;
        public event EventHandler<OrdenEventArgs> OrdenEventHandler;
        #endregion


        public List<Auto> ListaAutos { get { return _listaAuto; } }


        #region Constructores
        public Cliente() { _listaAuto = new List<Auto>(); }
        public Cliente(string pDNI, string pNombre, string pApellido) : this()
        {
            DNI = pDNI; Nombre = pNombre; Apellido = pApellido;
        }
        #endregion


        #region Metodos
        public override void AgregarAuto(Auto pAuto)
        {
            _listaAuto.Add(new Auto(
                pAuto.Patente,
                pAuto.Marca,
                pAuto.Modelo,
                pAuto.Axo,
                pAuto.Precio,
                pAuto.Get_Dueno()));
        }


        public override void BorrarAuto(Auto pAuto)
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
            catch (Exception ex) { throw ex; }
        }


        public override void ModificarAuto(Auto pAuto)
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
            catch (Exception ex) { throw ex; }
        }


        public override List<Auto> RetornaListaAutos()
        {
            List<Auto> _aux_listaAuto = new List<Auto>();

            try
            {
                if (_listaAuto == null) { return null; }
                foreach (Auto _a in _listaAuto)
                {
                    _aux_listaAuto.Add(new Auto(
                        _a.Patente,
                        _a.Marca,
                        _a.Modelo,
                        _a.Axo,
                        _a.Precio,
                        _a.Get_Dueno() != null ? new Cliente(
                            _a.Get_Dueno().DNI,
                            _a.Get_Dueno().Nombre,
                            _a.Get_Dueno().Apellido) : null));
                }
            }
            catch (Exception ex) { throw ex; }
            return _aux_listaAuto;
        }
        #endregion


        #region Metodos de Cierre
        public void Dispose()
        {
            if (!_paso)
            {
                _listaAuto = null;
                _paso = true;
            }
        }

        // Implementación de la interfaz IComparable
        public int CompareTo(object obj)
        {
            int resultado = Nombre.CompareTo(((Cliente)obj).Nombre);
            OrdenEventHandler?.Invoke(this, new OrdenEventArgs(this, (Cliente)obj, resultado));
            return resultado;
        }

        ~Cliente()
        {
            if (_paso) { return; }
            _listaAuto = null;
            DestructorEventHandler?.Invoke(this, new DestructorEventArgs(this));
        }
        #endregion
    }
}

