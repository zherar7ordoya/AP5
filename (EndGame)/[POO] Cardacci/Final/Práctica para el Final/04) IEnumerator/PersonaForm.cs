using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazIEnumerator
{
    public partial class PersonaForm : Form
    {
        public PersonaForm() { InitializeComponent(); }

        private void Formulario_Load(object sender, EventArgs e)
        {
            Clase _persona = new Clase("Gerardo Tordoya");

            foreach (string texto in _persona)
            {
                MessageBox.Show(texto);
            }
        }
    }


    //Vamos a iterar cada parte de un codigo AAA-123

    public class Clase : IEnumerable, IEnumerator
    {
        public string Codigo { get; set; }                  // < Propiedad
        public Clase(string codigo) { Codigo = codigo; }    // < Constructor

        // IENUMERABLE ********************************************************

        // Retorno el mismo objeto para usar como Enumerator
        public IEnumerator GetEnumerator() { return this; }


        // IENUMERABLE ********************************************************

        // Variable para el IEnumerator
        private string _current;

        // Devuelve V o F segun haya o no cosas para iterar
        private bool _sigue;

        // Lo usamos como contador, en este caso va a ser 0 o 1 ya que el
        // cóodigo tiene 2 partes
        private int _contador;

        // Retorna el _current
        public object Current => _current;

        public bool MoveNext()
        {
            if (_contador == 0)
            {
                _current = Codigo.Substring(0, 7);
                _sigue = true;
                _contador++;
            }
            else if (_contador == 1)
            {
                _current = Codigo.Substring(8, 7);
                _sigue = true;
                _contador++;
            }
            else
            {
                Reset();
            }

            return _sigue;
        }

        public void Reset()
        {
            _current = "";
            _contador = 0;
            _sigue = false;
        }
    }
}
