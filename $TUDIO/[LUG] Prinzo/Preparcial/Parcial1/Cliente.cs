using System;
using TarjAbstracta;

namespace Parcial1
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Tarjeta TarjetaAsociada { get; set; }

        public Cliente()
        {
        }

        public Cliente(string _nombre, string _apellido, int _dni, DateTime _fechaNac)
        {
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.DNI = _dni;
            this.FechaNacimiento = _fechaNac;
        }

        //Voy a querer esto para el listbox
        public override string ToString()
        {
            return String.Format("{0}  {1}  {2}  {3}", Nombre, Apellido, DNI, FechaNacimiento.ToShortDateString());
        }
    }
}