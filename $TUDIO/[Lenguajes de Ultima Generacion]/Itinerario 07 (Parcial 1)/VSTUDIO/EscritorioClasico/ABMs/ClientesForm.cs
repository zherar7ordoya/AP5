using System;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class ClientesForm : Form
    {
        //APP-1
        BLL.Cliente bllCliente = new BLL.Cliente();
        BEL.Cliente belCliente = new BEL.Cliente();

        // *-------------------------------------------------------=> SINGLETON
        private static ClientesForm instancia = null;
        private ClientesForm() => InitializeComponent();

        public static ClientesForm Instancia()
        {
            if (instancia == null) instancia = new ClientesForm();
            return instancia;
        }

        private void AltaClienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm formulario = ClienteForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("Operación correcta");
                InauguraFormulario();
            }
        }

        private void ClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********


        //APP-3
        private void ClientesForm_Load(object sender, EventArgs e) => InauguraFormulario();

        private void InauguraFormulario()
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = bllCliente.Listar();
        }

        private void ClientesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belCliente = (BEL.Cliente)this.ClientesDataGridView.CurrentRow.DataBoundItem;

                // ELIMINACIÓN
                if (e.ColumnIndex == 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Confirma eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (bllCliente.Eliminar(belCliente) == false) MessageBox.Show("Registro asociado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        else { InauguraFormulario(); }
                    }
                }
                
                //  EDICIÓN
                if (e.ColumnIndex == 1)
                {
                    // Instancio el Form ABM y le paso los datos a editar.
                    ClienteForm formulario = new ClienteForm();

                    formulario.CodigoTextBox.Text = belCliente.Codigo.ToString();
                    formulario.NombreTextBox.Text = belCliente.Nombre.ToString();
                    formulario.ApellidoTextBox.Text = belCliente.Apellido.ToString();
                    formulario.DNITextBox.Text = belCliente.DNI.ToString();
                    formulario.FechaVencimientoDateTimePicker.Value = belCliente.FechaNacimiento;

                    // Si la respuesta es OK, actualizo la grilla.
                    DialogResult respuesta = formulario.ShowDialog();
                    if (respuesta == DialogResult.OK) InauguraFormulario();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }
    }
}
