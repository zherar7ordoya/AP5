using System.Windows.Forms;

namespace Integrador
{
    class Auto
    {
        private string  _patente;
        private string  _marca;
        private string  _modelo;
        private string  _anio;
        private decimal _precio;
        public string Patente
        {
            get { return _patente; }
        }
        public string Marca
        {
            get { return _marca; }
        }
        public string Modelo
        {
            get { return _modelo; }
        }
        public string Anio
        {
            get { return _anio; }
        }
        public decimal Precio
        {
            get { return _precio; }
        }
        public Auto(string patente, string marca, string modelo, string anio, decimal precio)
        {
            _patente = patente;
            _marca   = marca;
            _modelo  = modelo;
            _anio    = anio;
            _precio  = precio;
        }
        ~ Auto() { MessageBox.Show(this.Patente); }
        public string Duenio(Persona x) { return x.Apellido + ", " + x.Nombre; }
    }
}
