using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Persona
    {
        List<Auto> _listaAuto;
        public Persona() { _listaAuto = new List<Auto>(); }
        public Persona(
            string pDNI,
            string pNombre,
            string pApellido) : this()
        {
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
        } 

        // TODO Agrgar propiedades de persona
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public void AgregarAuto(Auto pAuto) { _listaAuto.Add(new Auto(pAuto.Patente, pAuto.Marca, pAuto.Modelo, pAuto.Axo, pAuto.Precio, pAuto.Dueno())); }



        // TODO borrar Auto de la lista
        // TODO Retornar lista de  Autos 

        public void BorrarAuto(Auto pAuto)
        {
            /* ¿Por qué es necesario esto? Porque el objeto que recibo como
             * parámetro no es el mismo que tengo en la lista. El Try/Catch es
             * por si mando un NULL (no se puede remover un NULL) */
            try
            {
                Auto _auxAuto = _listaAuto.Find(x => x.Patente == pAuto.Patente);
                if (_auxAuto != null)
                {
                    _listaAuto.Remove(_auxAuto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Auto> RetornaListaAutos()
        {
            List<Auto> _aux_listaAuto = new List<Auto>();
            foreach (Auto _a in _listaAuto)
            {
                _aux_listaAuto.Add(new Auto(
                    _a.Patente,
                    _a.Marca,
                    _a.Modelo,
                    _a.Axo,
                    _a.Precio,
                    _a.Dueno()));
            }
            return _aux_listaAuto;
        }


        ~Persona()
        {
            _listaAuto = null;
        }
    }
}

