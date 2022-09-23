using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Item : Form
    {
        // ************************************************************** CARGA

        BE.BE_Item BE_ITEM;
        readonly BLL.BLL_Item BLL_ITEM;

        public FRM_Item()
        {
            InitializeComponent();
            BE_ITEM = new BE.BE_Item();
            BLL_ITEM = new BLL.BLL_Item();
        }

        private void FRM_Item_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void EmpleadoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ItemDGV.CurrentRow != null)
                {
                    BE_ITEM = (BE.BE_Item)ItemDGV.CurrentRow.DataBoundItem;
                    ItemIDTextBox.Text = BE_ITEM.ItemID.ToString();
                    CategoriaIDTextBox.Text = BE_ITEM.CategoriaID;
                    NombreTextBox.Text = BE_ITEM.Nombre;
                    DescripcionTextBox.Text = BE_ITEM.Descripcion;
                    PrecioUnitarioTextBox.Text = BE_ITEM.PrecioUnitario.ToString();
                    ProveedorIDTextBox.Text = BE_ITEM.ProveedorID;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_ITEM.ItemID = 0;

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_ITEM.Guardar(BE_ITEM) == false)
                    {
                        MessageBox.Show("Ya existe el producto");
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
                    BLL_ITEM.Eliminar(BE_ITEM);
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
                    BLL_ITEM.Guardar(BE_ITEM);
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
                ItemDGV.DataSource = null;
                ItemDGV.DataSource = BLL_ITEM.ListarTodo();
                ItemDGV.Columns["ID"].Visible = false;
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
                BE_ITEM.ItemID = Convert.ToInt32(ItemIDTextBox.Text);
                BE_ITEM.CategoriaID = CategoriaIDTextBox.Text;
                BE_ITEM.Nombre = NombreTextBox.Text;
                BE_ITEM.Descripcion = DescripcionTextBox.Text;
                BE_ITEM.PrecioUnitario = Convert.ToDecimal(PrecioUnitarioTextBox.Text);
                BE_ITEM.ProveedorID = ProveedorIDTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                    ▂▃▄▅▆▇█▓▒░ THE END ░▒▓█▇▆▅▄▃▂

    }
}
