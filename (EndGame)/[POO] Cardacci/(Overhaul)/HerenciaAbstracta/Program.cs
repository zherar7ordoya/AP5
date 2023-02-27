using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace HerenciaAbstracta
{
    internal class Program
    {
        static void Main()
        {
            // Abstractos: Clave y ConsultarTodosLosDatos()

            Empleado _empleado = new Empleado
            {
                Nombre = "Juan",
                Apellido = "Gonzalez",
                Clave = 1 // ABSTRACTO
            };
            WriteLine(_empleado.ConsultarTodosLosDatos()); // ABSTRACTO
            WriteLine(_empleado.ObtenerNombreCompleto());

            Cliente _cliente = new Cliente
            {
                Nombre = "Pedro",
                Apellido = "Ramirez",
                Clave = 34 // ABSTRACTO
            };
            WriteLine(_cliente.ConsultarTodosLosDatos()); // ABSTRACTO
            WriteLine(_cliente.ObtenerNombreCompleto());

            ReadLine();
        }
    }


    #region --- ABSTRACTA -----------------------------------------------------
    abstract class Persona
    {
        private string _nombre;
        private string _apellido;


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        // Propiedad Abstracta
        public abstract int Clave { get; set; }


        public string ObtenerNombreCompleto() => $"{Nombre} {Apellido}";
        // Método Abstracto
        public abstract string ConsultarTodosLosDatos();
    }
    #endregion



    #region --- HEREDADA ------------------------------------------------------
    class Empleado : Persona
    {
        private int _clave;

        // Propiedad Sobreescrita
        public override int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        // Método Sobreescrito
        public override string ConsultarTodosLosDatos()
        {
            return $"------Datos del Empleado:\n{Clave} {Nombre} {Apellido}";
        }
    }


    class Cliente : Persona
    {
        private int _clave;

        public override int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public override string ConsultarTodosLosDatos()
        {
            return $"******Datos del Cliente:\n{Clave} {Nombre} {Apellido}";
        }
    }
    #endregion

}






