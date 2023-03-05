using Microsoft.VisualBasic;

using System;
using System.Windows.Forms;

namespace Captura
{
    public partial class ComedorForm : Form
    {
        public ComedorGestor _gestor = new ComedorGestor();

        public ComedorForm() => InitializeComponent();

        private void ComedorForm_Load(object sender, EventArgs e)
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
            // ¿Por qué vacío? RowEnter tiene un doble barrido. Este "truco"
            // evita que se muestre un mensaje de error cuando se selecciona.
            catch (Exception) { }
        }

        private void AlimentarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = AnimalesDgv.SelectedRows[0].DataBoundItem as Animal;
                IAlimento alimento = AlimentosDgv.SelectedRows[0].DataBoundItem as IAlimento;

                animal.Comer(alimento);

                _gestor.AlimentaAnimal(animal, alimento);

                var animales = _gestor.GetAnimales();
                var alimentos = _gestor.GetAlimentos();

                ActualizaDgv(AnimalesDgv, animales);
                ActualizaDgv(AlimentosDgv, alimentos);
                AnimalesDgv_RowEnter(this, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            this.GrupoRadio.Visible = true;
        }

        private void PosAgregado()
        {
            var animales = _gestor.GetAnimales();
            var alimentos = _gestor.GetAlimentos();

            ActualizaDgv(AnimalesDgv, animales);
            ActualizaDgv(AlimentosDgv, alimentos);
            AnimalesDgv_RowEnter(this, null);

            GrupoRadio.Visible = false;
            MessageBox.Show("Animal agregado");
        }

        private string GetNombreAnimal()
        {
            return Interaction.InputBox("Introduce el nombre del animal", "Nombre", "Nombre", -1, -1);
        }

        private void CebraRadio_CheckedChanged(object sender, EventArgs e)
        {
            // ¿Por qué? Si no se hace esto, el evento se ejecuta dos veces.
            if (CebraRadio.Checked == false) return;

            string nombre = GetNombreAnimal();
            if (nombre == "") return;
            _gestor.AgregaAnimal(new Cebra(nombre));
            PosAgregado();
        }

        private void CiervoRadio_CheckedChanged(object sender, EventArgs e)
        {
            // ¿Por qué? Si no se hace esto, el evento se ejecuta dos veces.
            if (CiervoRadio.Checked == false) return;

            string nombre = GetNombreAnimal();
            if (nombre == "") return;
            _gestor.AgregaAnimal(new Ciervo(nombre));
            PosAgregado();
        }

        private void LeonRadio_CheckedChanged(object sender, EventArgs e)
        {
            // ¿Por qué? Si no se hace esto, el evento se ejecuta dos veces.
            if (LeonRadio.Checked == false) return;

            string nombre = GetNombreAnimal();
            if (nombre == "") return;
            _gestor.AgregaAnimal(new Leon(nombre));
            PosAgregado();
        }

        private void TigreRadio_CheckedChanged(object sender, EventArgs e)
        {
            // ¿Por qué? Si no se hace esto, el evento se ejecuta dos veces.
            if (TigreRadio.Checked == false) return;

            string nombre = GetNombreAnimal();
            if (nombre == "") return;
            _gestor.AgregaAnimal(new Tigre(nombre));
            PosAgregado();
        }
    }
}
