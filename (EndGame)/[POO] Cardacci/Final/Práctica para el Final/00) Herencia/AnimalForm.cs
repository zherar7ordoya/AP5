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
    public partial class AnimalForm : Form
    {
        AnimalGestor _gestor = new AnimalGestor();

        public AnimalForm()
        {
            InitializeComponent();
        }

        private void ComedorAnimalForm_Load(object sender, EventArgs e)
        {
            AnimalesDgv.DataSource = _gestor.GetAnimales();
            AlimentosDgv.DataSource = _gestor.GetAlimentos();
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
                var historial = _gestor.GetHistorial(animal);
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
    }
}
