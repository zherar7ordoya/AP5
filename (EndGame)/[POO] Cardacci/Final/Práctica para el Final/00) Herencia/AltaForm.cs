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

namespace Captura
{
    public partial class AltaForm : Form
    {
        private ComedorGestor _gestor = ComedorForm.


        public AltaForm()
        {
            InitializeComponent();
        }

        private void AltaForm_Load(object sender, EventArgs e)
        {
            

        }

        private string GetNombreAnimal()
        {
            return Interaction.InputBox("Introduce el nombre del animal", "Nombre", "Nombre", -1, -1);
        }

        private void CebraRadio_CheckedChanged(object sender, EventArgs e)
        {
            string nombre = GetNombreAnimal();
            //_gestor.AgregaAnimal(new Cebra(nombre));
            Close();
        }

        private void CiervoRadio_CheckedChanged(object sender, EventArgs e)
        {
            string nombre = GetNombreAnimal();
            _gestor.AgregaAnimal(new Ciervo(nombre));
            Close();
        }

        private void LeonRadio_CheckedChanged(object sender, EventArgs e)
        {
            string nombre = GetNombreAnimal();
            _gestor.AgregaAnimal(new Leon(nombre));
            Close();
        }

        private void TigreRadio_CheckedChanged(object sender, EventArgs e)
        {
            string nombre = GetNombreAnimal();
            _gestor.AgregaAnimal(new Tigre(nombre));
            Close();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un animal");
        }
    }
}
