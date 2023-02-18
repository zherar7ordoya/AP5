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
        public Persona(string pDNI,string pNombre,string pApellido) : this()
        {
            DNI = pDNI;Nombre = pNombre;Apellido = pApellido;
        }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public void AgregarAuto(Auto pAuto) 
        { _listaAuto.Add(new Auto(pAuto.Patente,pAuto.Marca,pAuto.Modelo,pAuto.Axo,pAuto.Precio,pAuto.Get_Dueno())); }    

        public void BorrarAuto(Auto pAuto) 
        {
            try
            {
               // Ubica el auto en la lista de autos de la persona a partir de las patente enviada en pAuto
                Auto _auxAuto = _listaAuto.Find(x => x.Patente == pAuto.Patente); 
               if(_auxAuto!=null)
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
                foreach(Auto _a in _listaAuto)
                {
                    _aux_listaAuto.Add(new Auto(_a.Patente,_a.Marca,_a.Modelo,_a.Axo,_a.Precio,
                                               _a.Get_Dueno()!=null?new Persona(_a.Get_Dueno().DNI,_a.Get_Dueno().Nombre,_a.Get_Dueno().Apellido):null));
                }
            }
            catch (Exception ex) { throw ex; }       
            return _aux_listaAuto;
        }
        ~Persona()
        {
            _listaAuto = null;
        }
    }
}

