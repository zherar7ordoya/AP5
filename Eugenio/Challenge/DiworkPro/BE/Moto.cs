using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Moto : Vehiculo
    {
        public string Cilindrada { get; set; }
        public int IdVehiculo { get; set; }
        
        public Moto() { }

        public Moto(int idVehiculo, string cilindrada)
        {
            IdVehiculo = idVehiculo;
            Cilindrada = cilindrada;            
        }

        public Moto(int id, int idVehiculo, string cilindrada)
        {
            Id = id;
            IdVehiculo = idVehiculo;
            Cilindrada = cilindrada;
        }
        public Moto(string marca, string modelo, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
        }
        public Moto(int idvehiculo, string marca, string modelo, string patente)
        {
            IdVehiculo = idvehiculo;
            Marca = marca;
            Modelo = modelo;
            Patente = patente;           
        }

        public Moto(int idvehiculo, string marca, string modelo, string patente, string cilindrada)
        {            
            IdVehiculo = idvehiculo;
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            Cilindrada = cilindrada;
        }

        public Moto(int id, int idvehiculo, string marca, string modelo, string patente, string cilindrada)
        {            
            Id = id;
            IdVehiculo = idvehiculo;
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            Cilindrada = cilindrada;
        }
    }
}
