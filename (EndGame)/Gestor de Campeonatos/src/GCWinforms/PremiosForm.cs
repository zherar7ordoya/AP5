using GCDataAccess;
using GCModels;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GCWinforms
{
    public partial class PremiosForm : MaterialForm
    {
        public PremiosForm(MaterialSkinManager msm)
        {
            InitializeComponent();

            // --- Material Skin ---------------
            MaterialSkinManager MSManager = msm;
            MSManager.AddFormToManage(this);
            // ---------------------------------
        }


        private void CrearPremioButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                PremioModel premio = new PremioModel
                (
                    PuestoTextbox.Text,
                    NombreTextbox.Text,
                    MontoTextbox.Text,
                    PorcentajeCombobox.Text
                );

                // TODO => Referencia a la DAL
                // Ver: http://web.archive.org/web/20190124023839/http://www.dotnetspark.com:80/kb/266-inversion-control-ioc-and-dependency-injection.aspx
                // Mientras tanto, se puede hacer el "pasamanos" apelando a
                // repetir las clases en GCLogic. Ya hemos visto esta mecánica
                // en LUG.
                var modelo = ConfiguracionGlobal.Conexion.CrearPremio(premio);

                if (modelo.PremioID > 0)
                {
                    MessageBox.Show
                        (
                        "Premio creado exitosamente",
                        "Premio Creado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ReiniciarForm();
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear el premio");
                }
            }
            else MessageBox.Show
                (
                "Por favor, complete todos los campos correctamente.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }


        private bool ValidarDatos()
        {
            /** SOBRE VARIABLE "VALIDACION" Y ERRORPROVIDER
             *  ¿Por qué uso una variable y no un "return false" directamente?
             *  En una aplicación profesional, uno desea informar al usuario de
             *  todos los errores que haya cometido. El "return false" corta la
             *  ejecución y la validación de los demás campos.
             */

            // Es más fácil demostrar que algo es FALSE a que todo es TRUE
            bool validacion = true;

            // PuestoTextbox: Valido que se ha introducido un valor numérico
            if (int.TryParse(PuestoTextbox.Text, out int puesto))
            {
                // PuestoTextbox: Valido que el valor introducido es mayor que 0
                if (puesto < 1)
                {
                    validacion = false;
                    ErrorProvider.SetError(PuestoTextbox, "El puesto debe ser mayor que 0");
                }
            }
            else
            {
                validacion = false;
                ErrorProvider.SetError(PuestoTextbox, "Debe introducir un valor numérico");
            }


            // NombreTextbox: Valido que se ha introducido algún texto
            if (string.IsNullOrEmpty(NombreTextbox.Text))
            {
                validacion = false;
                ErrorProvider.SetError(NombreTextbox, "Debe introducir un nombre");
            }

            // MontoTextbox: Valido que se ha introducido un valor numérico
            if (decimal.TryParse(MontoTextbox.Text, out decimal monto))
            {
                // PorcentajeCombobox: Convierto a número el ítem seleccionado
                // (no hace falta el TryParse, yo puse esos números en el combobox)
                int porcentaje = int.Parse(PorcentajeCombobox.Text);

                // Monto y Porcentaje no pueden ser 0 simultáneamente
                if (monto < 1 && porcentaje < 1)
                {
                    validacion = false;
                    ErrorProvider.SetError(PremioGroupbox, "El monto o el porcentaje deben ser mayores que 0");
                }
            }
            else
            {
                validacion = false;
                ErrorProvider.SetError(MontoTextbox, "Debe introducir un valor numérico");
            }

            ErrorTimer.Start();
            return validacion;
        }


        private void ReiniciarForm()
        {
            PuestoTextbox.Text = "0";
            NombreTextbox.Text = String.Empty;
            MontoTextbox.Text = "0.00";
            MontoRadio.Checked = true;
        }


        // ┌── EMPIEZA EVENTOS ───────────────────────────────────────────────┐
        private void MontoRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Validaciones: me aseguro que el porcentaje sea 0
            PorcentajeCombobox.Text = "0";
            PorcentajeCombobox.Enabled = false;

            MontoTextbox.Enabled = true;
        }

        private void PorcentajeRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Validaciones: me aseguro que el monto sea 0
            MontoTextbox.Text = "0.00";
            MontoTextbox.Enabled = false;

            PorcentajeCombobox.Enabled = true;
            
            // El cero se encuentra en las propiedades del control
            PorcentajeCombobox.Items.AddRange(Enumerable.Range(1, 100).Select(i => (object)i).ToArray());
        }

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            ErrorTimer.Stop();
            ErrorProvider.Clear();
        }
        // └── TERMINA EVENTOS ───────────────────────────────────────────────┘
    }
}
