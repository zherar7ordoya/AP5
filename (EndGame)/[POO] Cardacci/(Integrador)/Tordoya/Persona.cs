using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Integrador
{
    class Persona 
    {
        private string _dni;
        private string _nombre;
        private string _apellido;
        public string Nombre 
        {
            get { return _nombre; } 
        }
        public string Apellido
        {
            get { return _apellido; }
        }
        public string DNI
        {
            get { return _dni; }
        }
        public List<Auto> Autos;
        public Persona(string dni, string nombre, string apellido)
        {
            _dni      = dni;
            _nombre   = nombre;
            _apellido = apellido;
            Autos     = new List<Auto>();
        }
        ~ Persona() { MessageBox.Show(this.DNI); }
        public List<Auto> Lista_de_Autos() { return Autos; }
        public int Cantidad_de_Autos() { return Autos.Count(); }
    }
}
