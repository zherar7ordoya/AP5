using System;
using System.Collections;
using System.Windows.Forms;

namespace Enumerator
{
    public partial class PersonaForm : Form
    {
        public PersonaForm() { InitializeComponent(); }

        private void Formulario_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona("Gerardo Tordoya");

            foreach (string texto in persona)
            {
                MessageBox.Show(texto);
            }
        }
    }


    public class Persona : IEnumerable, IEnumerator
    {
        public string Codigo { get; set; }
        public Persona(string codigo) { Codigo = codigo; }

        // IENUMERABLE ********************************************************

        // Retorno el mismo objeto para usarlo como Enumerator
        public IEnumerator GetEnumerator() { return this; }


        // IENUMERATOR ********************************************************


        private string _current;
        public object Current => _current;  // Cursor
        private bool _continuar;            // Bandera
        private int _contador;              // Iteraciones

        public bool MoveNext()
        {
            if (_contador == 0)
            {
                _current = Codigo.Substring(0, 7);
                _continuar = true;
                _contador++;
            }
            else if (_contador == 1)
            {
                _current = Codigo.Substring(8, 7);
                _continuar = true;
                _contador++;
            }
            else { Reset(); }

            return _continuar;
        }

        public void Reset()
        {
            _current = "";
            _contador = 0;
            _continuar = false;
        }
    }
}
