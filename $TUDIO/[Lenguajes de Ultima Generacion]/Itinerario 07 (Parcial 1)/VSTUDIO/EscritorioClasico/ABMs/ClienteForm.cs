using System;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class ClienteForm : Form
    {
        BLL.Cliente lgcCliente = new BLL.Cliente();
        BEL.Cliente belCliente = new BEL.Cliente();


        // *-------------------------------------------------------=> SINGLETON
        // NOTA:
        // Para el ABM, tuve que hacerlo público. Es decir, es un singleton mal
        // implementado. Será materia de estudio posterior.
        public ClienteForm() => InitializeComponent();
        private static ClienteForm instancia = null;
        public static ClienteForm Instancia()
        {
            if (instancia == null) instancia = new ClienteForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********


        private void LimpiarTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox) (control as TextBox).Clear();
                    else { func(control.Controls); }
                }
            };
            func(Controls);
        }

        private void ClienteForm_FormClosing(object sender, FormClosingEventArgs e) => LimpiarTextBoxes();

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el TextBox tiene código es porque el registro existe.
                if (CodigoTextBox.Text != "") belCliente.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                else { belCliente.Codigo = 0; }

                belCliente.Nombre = NombreTextBox.Text;
                belCliente.Apellido = ApellidoTextBox.Text;
                belCliente.DNI = Convert.ToInt32(DNITextBox.Text);
                belCliente.FechaNacimiento = FechaVencimientoDateTimePicker.Value;
                
                lgcCliente.Guardar(belCliente);

                LimpiarTextBoxes();
                this.DialogResult = DialogResult.OK;
                this.Close();
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
