using System;
using System.Windows.Forms;
using ABS;

namespace UIL
{
    public partial class CalculadoraForm : Form, ICalculadoraView
    {
        public event EventHandler Sumar;
        public event EventHandler Reiniciar;

        public CalculadoraForm()
        {
            InitializeComponent();

            /**
             * I also took the button click event handlers out of the designer
             * file (where they automatically get created), and made those part
             * of the interface as well.
             */
            SumarButton.Click += delegate { Sumar?.Invoke(this, EventArgs.Empty); };
            ReiniciarButton.Click += delegate
            {
                Reiniciar?.Invoke(this, EventArgs.Empty);
                Valor1Textbox.Focus();
            };
        }

        string ICalculadoraView.Valor1
        {
            get => Valor1Textbox.Text;
            set => Valor1Textbox.Text = value;
        }

        string ICalculadoraView.Valor2
        {
            get => Valor2Textbox.Text;
            set => Valor2Textbox.Text = value;
        }

        string ICalculadoraView.Valor3
        {
            get => Valor3Textbox.Text;
            set => Valor3Textbox.Text = value;
        }

        public string Total
        {
            set => TotalTextbox.Text = value;
        }

        public string Acumulado
        {
            set => AcumuladoTextbox.Text = value;
        }
    }
}
