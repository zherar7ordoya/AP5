using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// TODO => Conciliar Herencia

namespace Integrador
{
    public class Cliente : Persona, IDisposable
    {
        #region Atributos
        bool _paso = false;
        List<Auto> _listaAuto;
        public event EventHandler<DestructorEventArgs> DestructorEventHandler;
        #endregion




        #region Constructores
        public Cliente() { _listaAuto = new List<Auto>(); }
        public Cliente(string pDNI, string pNombre, string pApellido) : this()
        {
            DNI = pDNI; Nombre = pNombre; Apellido = pApellido;
        }
        #endregion





        #region Metodos de la interfaz IDisposable
        public void Dispose()
        {
            if (!_paso)
            {
                _listaAuto = null;
                _paso = true;
            }
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

