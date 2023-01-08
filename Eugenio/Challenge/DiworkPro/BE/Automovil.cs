using Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Automovil : Vehiculo
    {
        public enum Tipo
        {
            Compacto,
            Sedan,
            Monovolumen,
            Utilitario,
            Lujo
        }

        //public int TipoM { get; set; }
        public Tipo TipoM { get ; set; }
        public int CantidadPuertas { get; set; }
        public int IdVehiculo { get; set; }


        public Automovil() { }

        public Automovil(string marca, string modelo, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
        }

        public Automovil(int idvehiculo, Tipo tipo, int cantidadPuertas)
        {
            IdVehiculo = idvehiculo;
            TipoM = tipo;
            CantidadPuertas = cantidadPuertas;
        }

        
        public Automovil(int id, string marca, string modelo, string patente)
        {
            Id = id;            
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
        }
        
        public Automovil(int idvehiculo, Tipo tipo, int cantidadPuertas, string marca, string modelo, string patente)
        {
            IdVehiculo = idvehiculo;
            TipoM = tipo;
            CantidadPuertas = cantidadPuertas;
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
        }
        public Automovil(int id, int idvehiculo, Tipo tipo, int cantidadPuertas)
        {
            Id = id;
            IdVehiculo = idvehiculo;
            TipoM = tipo;
            CantidadPuertas = cantidadPuertas;
            
        }
        public Automovil(int id, int idvehiculo, Tipo tipo, int cantidadPuertas, string marca, string modelo, string patente)
        {
            Id = id;
            IdVehiculo = idvehiculo;
            TipoM = tipo;
            CantidadPuertas = cantidadPuertas;
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
        }
    }
}
