using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Proveedor : Form
    {
        // ************************************************************** CARGA

        BE.BE_Proveedor BE_PROVEEDOR;
        readonly BLL.BLL_Proveedor BLL_PROVEEDOR;

        public FRM_Proveedor()
        {
            InitializeComponent();
            BE_PROVEEDOR = new BE.BE_Proveedor();
            BLL_PROVEEDOR = new BLL.BLL_Proveedor();
        }

        private void FRM_Proveedor_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void CategoriaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ProveedorDGV.CurrentRow != null)
                {
                    BE_PROVEEDOR = (BE.BE_Proveedor)ProveedorDGV.CurrentRow.DataBoundItem;
                    ProveedorIDTextBox.Text = BE_PROVEEDOR.ProveedorID;
                    NombreTextBox.Text = BE_PROVEEDOR.Nombre;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_PROVEEDOR.Instruccion = "Alta";

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_PROVEEDOR.Guardar(BE_PROVEEDOR) == false)
                    {
                        MessageBox.Show("Ya existe el proveedor");
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
                    BLL_PROVEEDOR.Eliminar(BE_PROVEEDOR);
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
                    BLL_PROVEEDOR.Guardar(BE_PROVEEDOR);
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
                ProveedorDGV.DataSource = null;
                ProveedorDGV.DataSource = BLL_PROVEEDOR.ListarTodo();
                ProveedorDGV.Columns["ID"].Visible = false;
                ProveedorDGV.Columns["Instruccion"].Visible = false;
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
                BE_PROVEEDOR.ProveedorID = ProveedorIDTextBox.Text;
                BE_PROVEEDOR.Nombre = NombreTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                    ▂▃▄▅▆▇█▓▒░ THE END ░▒▓█▇▆▅▄▃▂

    }
}
