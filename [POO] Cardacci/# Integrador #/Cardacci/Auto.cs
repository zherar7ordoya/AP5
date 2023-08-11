using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// TODO => Implementar Generics!


namespace Integrador
{
    public class Auto
    {
        Integrador.Cliente _dueno;
        public Auto()
        {
            //_dueno = null;
        }
        public Auto(Cliente pDueno) { _dueno = pDueno; }
        public Auto(
            string pPatente,
            string pMarca,
            string pModelo,
            string pAxo,
            decimal pPrecio) : this()
        {
            Patente = pPatente;
            Marca = pMarca;
            Modelo = pModelo;
            Axo = pAxo;
            Precio = pPrecio;
        }
        public Auto(
            string pPatente,
            string pMarca,
            string pModelo,
            string pAxo,
            decimal pPrecio,
            Cliente pDueno) : this(pDueno)
        {
            Patente = pPatente;
            Marca = pMarca;
            Modelo = pModelo;
            Axo = pAxo;
            Precio = pPrecio;
        }


        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Axo { get; set; }
        public decimal Precio { get; set; }

        // TODO: Retornar un clon del dueño
        public Integrador.Cliente Get_Dueno() { return _dueno; }
        public void Set_Dueno(Cliente pPersona) 
        {
            // Carga el campo _dueno con un clon de la persona recibida o null.
            // Observar que en este nivel se rompe las referencias ya que al clon de la persona no se le cargan sus autos
            _dueno =
                pPersona == null ?
                null :
                new Integrador.Cliente(
                    pPersona.DNI,
                    pPersona.Nombre,
                    pPersona.Apellido);

           
        
        }

    }
}
