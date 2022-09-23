using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Rol : Form
    {
        // ************************************************************** CARGA

        BE.BE_Rol BE_ROL;
        readonly BLL.BLL_Rol BLL_ROL;

        public FRM_Rol()
        {
            InitializeComponent();
            BE_ROL = new BE.BE_Rol();
            BLL_ROL = new BLL.BLL_Rol();
        }

        private void FRM_Rol_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void CategoriaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (RolDGV.CurrentRow != null)
                {
                    BE_ROL = (BE.BE_Rol)RolDGV.CurrentRow.DataBoundItem;
                    RolIDTextBox.Text = BE_ROL.RolID;
                    NombreTextBox.Text = BE_ROL.Nombre;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_ROL.Instruccion = "Alta";

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_ROL.Guardar(BE_ROL) == false)
                    {
                        MessageBox.Show("Ya existe el rol");
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
                    BLL_ROL.Eliminar(BE_ROL);
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
                    BLL_ROL.Guardar(BE_ROL);
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
                RolDGV.DataSource = null;
                RolDGV.DataSource = BLL_ROL.ListarTodo();
                RolDGV.Columns["ID"].Visible = false;
                RolDGV.Columns["Instruccion"].Visible = false;
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
                BE_ROL.RolID = RolIDTextBox.Text;
                BE_ROL.Nombre = NombreTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                    ▂▃▄▅▆▇█▓▒░ THE END ░▒▓█▇▆▅▄▃▂

    }
}
