using System;
using System.Windows.Forms;

namespace Generico
{
    public partial class PersonaForm : Form
    {
        public PersonaForm() => InitializeComponent();

        Persona<int> _personaInt = new Persona<int>();
        Persona<bool> _personaBool = new Persona<bool>();
        Persona<string> _personaString = new Persona<string>();

        private void Formulario_Load(object sender, EventArgs e)
        {
            _personaInt.DNI = 25029996;
            _personaString.DNI = "25029996";

            _personaInt.MuestraTipo();
            _personaString.MuestraTipo();

            DateTime fecha = DateTime.Now;

            _personaBool.MetodoGenerico(1);
            _personaBool.MetodoGenerico(true);
            _personaBool.MetodoGenerico(fecha);
            _personaBool.MetodoGenerico(10.54m);
            _personaBool.MetodoGenerico(10.54);
        }
    }

    public class Persona<T>
    {
        private T _dni;
        public T DNI { get { return _dni; } set { _dni = value; } }

        public Persona() { }
        public Persona(T dni) { _dni = dni; }

        public void MuestraTipo() => MessageBox.Show($"DNI ({_dni}) es tipo {_dni.GetType()}");
        public void MetodoGenerico<S>(S dni) where S : struct => MessageBox.Show($"Recibido tipo {dni.GetType()}");
    }
}
