using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrimerPracticoOrientador
{
    public class Auto
    {
        public String Patente { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Ano { get; set; }
        public decimal Precio { get; set; }

        public Auto(String patente, String marca, String modelo, String ano, Decimal precio)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Precio = precio;
        }
        ~Auto() { Trace.WriteLine("La patente de los autos finalizados es " + Patente); }
    }
}
