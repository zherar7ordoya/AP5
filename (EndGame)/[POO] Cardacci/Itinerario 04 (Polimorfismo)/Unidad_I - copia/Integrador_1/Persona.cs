using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_1
{
    class Persona 
    {
        List<Auto> _listaAuto;
        public Persona() { _listaAuto = new List<Auto>(); }
        // TODO Agrgar propiedades de persona
        public void AgregarAuto(Auto pAuto) { _listaAuto.Add(new Auto(pAuto.Patente,pAuto.Marca,pAuto.Modelo,pAuto.Axo,pAuto.Precio,pAuto.Dueno())); }

       

        // TODO borrar Auto de la lista
        // TODO Retornar lista de  Autos 


        ~Persona()
        {
            _listaAuto = null;
        }
    }
}

