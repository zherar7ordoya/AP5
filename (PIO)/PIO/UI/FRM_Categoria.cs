using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Categoria : Form
    {
        // ************************************************************** CARGA

        BE.BE_Categoria BE_CATEGORIA;
        readonly BLL.BLL_Categoria BLL_CATEGORIA;

        public FRM_Categoria()
        {
            InitializeComponent();
            BE_CATEGORIA = new BE.BE_Categoria();
            BLL_CATEGORIA = new BLL.BLL_Categoria();
        }

        private void CategoriaForm_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void CategoriaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CategoriaDGV.CurrentRow != null)
                {
                    BE_CATEGORIA = (BE.BE_Categoria)CategoriaDGV.CurrentRow.DataBoundItem;
                    CategoriaIDTextBox.Text = BE_CATEGORIA.CategoriaID;
                    NombreTextBox.Text = BE_CATEGORIA.Nombre;
                    DescripcionTextBox.Text = BE_CATEGORIA.Descripcion;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_CATEGORIA.Instruccion = "Alta";

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_CATEGORIA.Guardar(BE_CATEGORIA) == false)
                    {
                        MessageBox.Show("Ya existe la categoría");
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
                    BLL_CATEGORIA.Eliminar(BE_CATEGORIA);
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
                    BLL_CATEGORIA.Guardar(BE_CATEGORIA);
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
                CategoriaDGV.DataSource = null;
                CategoriaDGV.DataSource = BLL_CATEGORIA.ListarTodo();
                CategoriaDGV.Columns["ID"].Visible = false;
                CategoriaDGV.Columns["Instruccion"].Visible = false;
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
                BE_CATEGORIA.CategoriaID = CategoriaIDTextBox.Text;
                BE_CATEGORIA.Nombre = NombreTextBox.Text;
                BE_CATEGORIA.Descripcion = DescripcionTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                                                        STOP FORREST!
    }
}
