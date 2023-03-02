using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{
    public partial class DelegadoForm : Form
    {
        public DelegadoForm()
        {
            InitializeComponent();
        }

        // Declaro un delegado que recibe string por referencia y devuelve string
        delegate string DelegadoString(string a);
        delegate int DelegadoNumero(int b, int c);


        private void Formulario_Load(object sender, EventArgs e)
        {
            // Declaro la variable de tipo delegado
            DelegadoString _varString;

            // Le suscribo una funcion compatible (con la misma firma)
            _varString = MostrarMensaje;

            // Ahora puedo invocar el delegado en vez de llamar a la función
           MessageBox.Show(_varString("Gerardo Tordoya"));

            // *****************************************************************

            // Hago lo mismo ahora con el otro delegado (el de números)
            DelegadoNumero _varNumero;
            _varNumero = Sumar;
            MessageBox.Show(_varNumero(5, 2).ToString());
        }

        private string MostrarMensaje(string texto) => texto;
        private int Sumar(int x, int y) => x + y;
    }
}
