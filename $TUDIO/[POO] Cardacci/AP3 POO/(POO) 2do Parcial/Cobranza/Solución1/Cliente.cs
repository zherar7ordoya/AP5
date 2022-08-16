using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUrbainskyAlexis
{
    sealed class Cliente : ICloneable, IDisposable
    {
        #region Atributos
        public List<Cobro> _ListaCobros;
        #endregion

        #region Constructores
        public Cliente() { 
        
        }

        public Cliente(string pLegajo, string pNombre) {
            Legajo = pLegajo;
            Nombre = pNombre;
            _ListaCobros = new List<Cobro>();
        }
        #endregion

        #region Propiedades
        public string Legajo { get; set; }

        public string Nombre{ get; set; }
        #endregion

        #region Metodos
        public void AgregarCobro(Cobro pCobro) {
            _ListaCobros.Add(pCobro);
        }
        #endregion

        #region Metodos Interfaz
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        #region Destructor

        bool _DisposeOk = false;
        ~Cliente()
        {
            if (!_DisposeOk)
            {
                //Solo ejecutamos el finalize si no se ejecuto el dispose
                Console.WriteLine("El objeto Cliente ha Finalizado Legajo: " + Legajo + " Nombre: " + Nombre);
            }
        }
        public void Dispose()
        {
            _DisposeOk = true;
        }
        #endregion 
    }

}
