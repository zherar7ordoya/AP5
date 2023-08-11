using System;
using System.Windows.Forms;

namespace Delegado
{
    public partial class DelegadoForm : Form
    {
        public DelegadoForm() => InitializeComponent();

        // Creo la estructura del delegado (la firma)
        delegate string DelegadoString(string texto);
        delegate int DelegadoNumero(int x, int y);

        private void DelegadoForm_Load(object sender, EventArgs e)
        {
            // Declaro variable tipo delegado
            DelegadoString mensaje;

            // Suscribo a la variable una funcion compatible (con la misma firma)
            mensaje = MuestraMensaje;

            // Invoco el delegado (en vez de llamar al método)
            MessageBox.Show(mensaje("Gerardo Tordoya"));

            // ----------------------------------------- Lo mismo (con el otro)
            DelegadoNumero suma;
            suma = EfectuaSuma;
            MessageBox.Show($"{suma(5, 2)}");
        }
        private string MuestraMensaje(string texto) => texto;
        private int EfectuaSuma(int x, int y) => x + y;
    }
}
