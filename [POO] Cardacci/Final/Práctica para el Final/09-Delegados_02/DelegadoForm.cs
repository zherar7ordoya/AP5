using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegado
{
    // ------------------------------------------------Delegado nivel Namespace
    public delegate void DelegadoMuestraMensaje();
    // ------------------------------------------------------------------------

    public partial class DelegadoForm : Form
    {
        public DelegadoForm() => InitializeComponent();

        private void DelegadoForm_Load(object sender, EventArgs e)
        {
            // LA OTRA CLASE
            // Caso 1: El delegado es asignado en el constructor a un método de
            //         esa clase
            Persona persona = new Persona();
            persona.Delegado();
            persona.Delegado -= persona.MetodoClase1;

            // ESTA CLASE
            // Caso 2: El delegado es asignado a un método dentro de esta clase
            persona.Delegado += MetodoFormulario1;
            persona.Delegado();
            persona.Delegado -= MetodoFormulario1;

            // LA OTRA CLASE Y ESTA CLASE
            // Caso 3: El delegado es asignado a un método de esta clase y es
            //         pasado a un método de la otra clase que recibe como
            //         parámetro un delegado
            persona.MetodoClase2(MetodoFormulario2);
            persona.Delegado();
            persona.Delegado -= MetodoFormulario2;

            if (persona.Delegado != null) MessageBox.Show("El delegado no es nulo");
            else MessageBox.Show("El delegado es nulo");
        }
        private void MetodoFormulario1() => MessageBox.Show("Soy el formulario");
        private void MetodoFormulario2() => MessageBox.Show("Pertenezco al formulario");
    }

    // ************************************************************************

    public class Persona
    {
        public DelegadoMuestraMensaje Delegado;

        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona() { Delegado += MetodoClase1; }
        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public virtual void MetodoClase1() => MessageBox.Show("Soy Persona");
        public void MetodoClase2(DelegadoMuestraMensaje delegado) => Delegado += delegado;

        // NOTA:
        // Delegate.Invoke and Delegate() are identical. Both do the same thing.
        public void InvocaDelegado() => Delegado();
    }
}
