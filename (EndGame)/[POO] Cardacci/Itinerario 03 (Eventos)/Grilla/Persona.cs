using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1
{
    public class Persona
    {

        public List<Auto> listaAutos = new List<Auto>();


        public Persona(int _dni, string _nombre, string _apellido)
        {
             
            dni = _dni;
            nombre = _nombre;
            apellido = _apellido;
        }


        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }



    }
}