using System;
using System.Windows.Forms;
using UIL.Presentador;
using UIL.Vista;

namespace UIL
{
    public partial class Form1 : Form, IRectangulo
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LongitudCadena
        {
            get => LongitudTextbox.Text;
            set => LongitudTextbox.Text = value;
        }

        public string AmplitudCadena
        {
            get => AmplitudTextbox.Text;
            set => AmplitudTextbox.Text = value;
        }
        
        public string AreaCadena
        {
            get => AreaTextbox.Text;
            set => AreaTextbox.Text = value;
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            RectanguloPresentador presentador = new RectanguloPresentador(this);
            presentador.CalcularArea();
        }
    }
}
