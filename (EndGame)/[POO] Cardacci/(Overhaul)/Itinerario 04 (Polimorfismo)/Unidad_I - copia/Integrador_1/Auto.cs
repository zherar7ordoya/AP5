using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_1
{
    class Auto
    {
        Persona _dueno;
        public Auto() { _dueno = null; }
        public Auto(Persona pDueno) { _dueno = pDueno; }
        public Auto(string pPatente, string pMarca, string pModelo, string pAxo, decimal pPrecio) : this()
        { Patente = pPatente;Marca = pMarca;Modelo = pModelo;Axo = pAxo;Precio = pPrecio; }
        public Auto(string pPatente, string pMarca, string pModelo, string pAxo, decimal pPrecio,Persona pDueno) : this(pDueno)
        { Patente = pPatente; Marca = pMarca; Modelo = pModelo; Axo = pAxo; Precio = pPrecio; }


        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Axo { get; set; }
        public decimal Precio { get; set; }

        // TODO: Retornar un clon del dueño
        public Persona Dueno() { return _dueno; }

    }
}
