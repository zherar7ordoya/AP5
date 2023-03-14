using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Departamento : Form
    {
        // ************************************************************** CARGA

        BE.BE_Departamento BE_DEPARTAMENTO;
        readonly BLL.BLL_Departamento BLL_DEPARTAMENTO;

        public FRM_Departamento()
        {
            InitializeComponent();
            BE_DEPARTAMENTO = new BE.BE_Departamento();
            BLL_DEPARTAMENTO = new BLL.BLL_Departamento();
        }

        private void DepartamentoForm_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void DepartamentoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DepartamentoDGV.CurrentRow != null)
                {
                    BE_DEPARTAMENTO = (BE.BE_Departamento)DepartamentoDGV.CurrentRow.DataBoundItem;
                    DepartamentoIDTextBox.Text = BE_DEPARTAMENTO.DepartamentoID;
                    NombreTextBox.Text = BE_DEPARTAMENTO.Nombre;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_DEPARTAMENTO.Instruccion = "Alta";

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_DEPARTAMENTO.Guardar(BE_DEPARTAMENTO) == false)
                    {
                        MessageBox.Show("Ya existe el departamento");
                    }
                    LimpiarTextBoxes();
                    CargarDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void BajaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();

                DialogResult resultado = MessageBox.Show("¿Eliminar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    BLL_DEPARTAMENTO.Eliminar(BE_DEPARTAMENTO);
                    LimpiarTextBoxes();
                    CargarDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void ModificacionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();

                DialogResult resultado = MessageBox.Show("¿Modificar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    BLL_DEPARTAMENTO.Guardar(BE_DEPARTAMENTO);
                    LimpiarTextBoxes();
                    CargarDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ************************************************************ MÉTODOS

        private void CargarDGV()
        {
            try
            {
                DepartamentoDGV.DataSource = null;
                DepartamentoDGV.DataSource = BLL_DEPARTAMENTO.ListarTodo();
                DepartamentoDGV.Columns["ID"].Visible = false;
                DepartamentoDGV.Columns["Instruccion"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LimpiarTextBoxes()
        {
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox box) box.Text = string.Empty;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Asignar()
        {
            try
            {
                BE_DEPARTAMENTO.DepartamentoID = DepartamentoIDTextBox.Text;
                BE_DEPARTAMENTO.Nombre = NombreTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                                                        STOP FORREST!
    }
}
