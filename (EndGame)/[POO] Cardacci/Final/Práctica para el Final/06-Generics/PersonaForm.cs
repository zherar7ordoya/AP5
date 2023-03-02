using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericos
{
    public partial class PersonaForm : Form
    {
        public PersonaForm()
        {
            InitializeComponent();
        }

        Persona<bool> _persona = new Persona<bool>();
        Persona<int> _personaEntero = new Persona<int>();
        Persona<string> _personaCadena = new Persona<string>();

        private void Formulario_Load(object sender, EventArgs e)
        {
            _personaEntero.Dni = 25029996;
            _personaCadena.Dni = "25029996";

            _personaEntero.MostrarEstado();
            _personaCadena.MostrarEstado();

            DateTime _fecha = DateTime.Now;

            _persona.MetodoGenerico(1);
            _persona.MetodoGenerico(true);
            _persona.MetodoGenerico(_fecha);
            _persona.MetodoGenerico(10.54m);
            _persona.MetodoGenerico(10.54);
        }
    }

    public class Persona<T>
    {
        private T _dni;
        public T Dni { get { return _dni; } set { _dni = value; } }

        public Persona() { }
        public Persona(T dni) { _dni = dni; }

        public void MostrarEstado()
        {
            MessageBox.Show($"DNI ({_dni}) es tipo {_dni.GetType()}");
        }

        public void MetodoGenerico<S>(S dni) where S : struct
        {
            MessageBox.Show($"Me llego un tipo {dni.GetType()}");
        }
    }
}
