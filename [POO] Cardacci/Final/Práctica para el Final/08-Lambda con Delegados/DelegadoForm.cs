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

namespace Delegado
{
    public partial class DelegadoForm : Form
    {
        public DelegadoForm() => InitializeComponent();

        delegate int DelegadoNumeros(int i);

        private void DelegadoForm_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>
            {
                "Alex",
                "Juan",
                "Pedro",
                "Gerardo",
                "Rodolfo"
            };
            var nombres = lista.Where(x => x.Length > 4);

            foreach (var nombre in nombres)
            {
                MessageBox.Show($"{nombre}: {((DelegadoNumeros)(x => x * x))(7)}");
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // Éste era un lambda normal, Intellisense sugirió dejarlo así
            bool bandera(int x) => x == 1;
            int digito = int.Parse(Interaction.InputBox("Dígito (si es 1, es true)"));
            if (bandera(digito) == true) MessageBox.Show("Verdadero");
            else MessageBox.Show("Falso");
        }
    }
}
