using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPracticoOrientador
{
    public class Propietario
    {
       /// <summary>
       /// Atributos de la clase propietario
       /// </summary>
        public String Marca { get; set; }
        public String Ano { get; set; }
        public String Modelo { get; set; }
        public String Patente { get; set; }
        public String Dni { get; set; }
        public String Nombre { get; set; }
        public decimal Precio { get; set; }
        /// <summary>
        /// Constructor de la clase propietario
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="ano"></param>
        /// <param name="modelo"></param>
        /// <param name="patente"></param>
        /// <param name="dni"></param>
        /// <param name="nombre"></param
       
        public Propietario(String marca, String ano, String modelo, String patente, String dni, String nombre, decimal precio)
        {
            Marca = marca;
            Ano = ano;
            Modelo = modelo;
            Patente = patente;
            Dni = dni;
            Nombre = nombre;
            Precio = precio;
        }
              
    }
}
