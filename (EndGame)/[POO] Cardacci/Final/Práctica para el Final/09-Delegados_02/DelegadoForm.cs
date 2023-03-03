using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegadoNivelNamespace
{
    // Declaro un delegado a nivel de espacio de nombres (namespace)
    public delegate void DelegadoVoid();

    public partial class DelegadoForm : Form
    {
        public DelegadoForm()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Delegado();
            persona.Delegado -= persona.MetodoClaseMuestraMensaje;

            persona.Delegado += MetodoFormularioMuestraMensaje;
            persona.Delegado();
            persona.Delegado -= MetodoFormularioMuestraMensaje;

            persona.MetodoClaseRecibeMetodo(MetodoFormularioParaParametro);
            persona.Delegado();
            persona.Delegado -= MetodoFormularioParaParametro;

            if (persona.Delegado != null) MessageBox.Show("El delegado no es nulo");
            else MessageBox.Show("El delegado es nulo");
        }

        private void MetodoFormularioMuestraMensaje()
        {
            MessageBox.Show("Soy formulario DelegadoForm");
        }

        private void MetodoFormularioParaParametro()
        {
            MessageBox.Show("Este método pertenece al formulario y es invocado por la clase");
        }
    }

    // ************************************************************************

    public class Persona
    {
        public DelegadoVoid Delegado;
        
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {
            Delegado += MetodoClaseMuestraMensaje;
        }
        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public void MetodoClaseMuestraMensaje()
        {
            MessageBox.Show("Soy clase Persona");
        }

        // Delegate.Invoke and Delegate() are identical. Both do the same thing.
        public void MetodoClaseInvocaDelegado()
        {
            Delegado();
        }

        public void MetodoClaseRecibeMetodo(DelegadoVoid delegado)
        {
            Delegado += delegado;
        }
    }
}
