using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class VistaAuto
    {
        public string Marca { get; set; }
        public string Axo { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public List<VistaAuto> ListaVistaAuto(List<Auto> pListaAuto)
        {
            List<VistaAuto> _auxLVA = new List<VistaAuto>();

            try
            {
                foreach (Auto _a in pListaAuto)
                {
                    _auxLVA.Add(new VistaAuto() { Marca = _a.Marca,Axo=_a.Axo,Modelo=_a.Modelo,
                                                  Patente=_a.Patente,
                                                  DNI = _a.Get_Dueno()!=null?_a.Get_Dueno().DNI:"",
                                                  Nombre = _a.Get_Dueno() != null ? _a.Get_Dueno().Nombre:"",
                                                  Apellido= _a.Get_Dueno() != null ? _a.Get_Dueno().Apellido:"" });
                }
            }
            catch (Exception ex) { throw ex; }

            return _auxLVA;
        }


        public object[] ObjetoVistaAuto(List<Auto> pListaAuto)
        {
            object[] _listaAutos;
            try
            {
                _listaAutos = (from auto
                               in pListaAuto
                               select new
                               {
                                   auto.Marca,
                                   auto.Axo,
                                   auto.Modelo,
                                   auto.Patente,
                                   DNI = auto.Get_Dueno() == null ? "" : auto.Get_Dueno().DNI,
                                   Nombre = auto.Get_Dueno() == null ? "" : auto.Get_Dueno().Nombre,
                                   Apellido = auto.Get_Dueno() == null ? "" : auto.Get_Dueno().Apellido
                               }).ToArray();
            }
            catch (Exception ex) { throw ex; }

            return _listaAutos;
        }


    }
}
