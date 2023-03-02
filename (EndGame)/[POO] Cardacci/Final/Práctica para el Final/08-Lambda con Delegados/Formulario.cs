using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DelegadosLambda
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        delegate int DelegadoNumeros(int i);

        private void Formulario_Load(object sender, EventArgs e)
        {
            List<string> _lista = new List<string> { "Alex", "Juan", "Pedro", "Gerardo" };
            var nombres = _lista.Where(x => x.Length > 5);

            foreach (var nombre in nombres)
            {
                MessageBox.Show($"{nombre}: {((DelegadoNumeros)(x => x * x))(7)}");
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // Éste era un lambda normal, Intellisense sugirió dejarlo así
            bool _evaluador(int x) => x == 1;

            int digito = int.Parse(Interaction.InputBox("Dígito (si es 1, es true)"));
            if (_evaluador(digito) == true) MessageBox.Show("Verdadero");
            else MessageBox.Show("Falso");
        }
    }
}
