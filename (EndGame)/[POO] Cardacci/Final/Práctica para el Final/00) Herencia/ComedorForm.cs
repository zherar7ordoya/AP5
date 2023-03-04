using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captura
{
    public partial class ComedorForm : Form
    {
        public ComedorGestor Gestor = new ComedorGestor();

        public ComedorForm()
        {
            InitializeComponent();
        }

        private void ComedorAnimalForm_Load(object sender, EventArgs e)
        {
            AnimalesDgv.DataSource = Gestor.GetAnimales();
            AlimentosDgv.DataSource = Gestor.GetAlimentos();
        }


        void ActualizaDgv(DataGridView dgv, object objeto)
        {
            dgv.DataSource = null;
            dgv.DataSource = objeto;
        }

        private void AnimalesDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtengo historial
                Animal animal = AnimalesDgv.SelectedRows[0].DataBoundItem as Animal;
                var historial = Gestor.GetHistorial(animal);
                ActualizaDgv(HistorialDgv, historial);

                // Obtengo categoría
                if (animal is ICarnivoro) CategoriaTxt.Text = $"{animal.Nombre} es carnívoro";
                else if (animal is IHerbivoro) CategoriaTxt.Text = $"{animal.Nombre} es herbívoro";
                else CategoriaTxt.Text = "Ha ocurrido un problema. Contacte al programador.";
            }
            catch (Exception)
            {
                CategoriaTxt.Text = "Ha ocurrido un problema. Contacte al programador.";
            }
        }

        private void AlimentarBtn_Click(object sender, EventArgs e)
        {
            Animal animal = AnimalesDgv.SelectedRows[0].DataBoundItem as Animal;
            IAlimento alimento = AlimentosDgv.SelectedRows[0].DataBoundItem as IAlimento;
            Gestor.AlimentaAnimal(animal, alimento);
            var animales = Gestor.GetAnimales();
            var alimentos = Gestor.GetAlimentos();
            ActualizaDgv(AnimalesDgv, animales);
            ActualizaDgv(AlimentosDgv, alimentos);
            AnimalesDgv_RowEnter(this, null);
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Form formulario = new AltaForm();
            formulario.ShowDialog();
            var animales = Gestor.GetAnimales();
            var alimentos = Gestor.GetAlimentos();
            ActualizaDgv(AnimalesDgv, animales);
            ActualizaDgv(AlimentosDgv, alimentos);
            AnimalesDgv_RowEnter(this, null);
            MessageBox.Show("Animal agregado");
        }
    }
}
