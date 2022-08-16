using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Orden : Form
    {
        // ************************************************************** CARGA

        BE.BE_Orden BE_ORDEN;
        readonly BLL.BLL_Orden BLL_ORDEN;

        public FRM_Orden()
        {
            InitializeComponent();
            BE_ORDEN = new BE.BE_Orden();
            BLL_ORDEN = new BLL.BLL_Orden();
        }

        private void FRM_Orden_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void OrdenDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (OrdenDGV.CurrentRow != null)
                {
                    BE_ORDEN = (BE.BE_Orden)OrdenDGV.CurrentRow.DataBoundItem;
                    OrdenIDTextBox.Text = BE_ORDEN.OrdenID.ToString();
                    LegajoTextBox.Text = BE_ORDEN.Legajo.ToString();
                    FechaTextBox.Text = BE_ORDEN.Fecha.ToString();
                    EstadoTextBox.Text = BE_ORDEN.Estado;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_ORDEN.OrdenID = 0;

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_ORDEN.Guardar(BE_ORDEN) == false)
                    {
                        MessageBox.Show("Ya existe la orden");
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
                    BLL_ORDEN.Eliminar(BE_ORDEN);
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
                    BLL_ORDEN.Guardar(BE_ORDEN);
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
                OrdenDGV.DataSource = null;
                OrdenDGV.DataSource = BLL_ORDEN.ListarTodo();
                OrdenDGV.Columns["ID"].Visible = false;
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
                BE_ORDEN.OrdenID = Convert.ToInt32(OrdenIDTextBox.Text);
                BE_ORDEN.Legajo = Convert.ToInt32(LegajoTextBox.Text);
                BE_ORDEN.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                BE_ORDEN.Estado = EstadoTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                  ▂▃▄▅▆▇█▓▒░ STOP FORREST ░▒▓█▇▆▅▄▃▂

    }
}
