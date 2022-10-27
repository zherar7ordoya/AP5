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
            if (ValidarDatos()) MessageBox.Show("Todo bien!");
            else MessageBox.Show("Todo mal...");
        }

        private bool ValidarDatos()
        {
            // PosicionTextbox: Validar que se ha introducido un valor numérico
            if (int.TryParse(PosicionTextbox.Text, out int puesto))
            {
                // PosicionTextbox: Validar que el valor introducido es mayor que 0
                if (puesto <= 0) return false;
            }
            else return false;

            // NombreTextbox: Validar que se ha introducido algún texto
            if (string.IsNullOrEmpty(NombreTextbox.Text)) return false;

            // MontoTextbox: Validar que se ha introducido un valor numérico
            if (decimal.TryParse(MontoTextbox.Text, out decimal monto))
            {
                // PorcentajeCombobox: Convertir a número el ítem seleccionado
                int porcentaje = int.Parse(PorcentajeCombobox.Text);

                // Monto y Porcentaje no pueden ser 0 simultáneamente
                if (monto <= 0 && porcentaje == 0) return false;
            }
            else return false;

            return true;
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
        // └── TERMINA EVENTOS ───────────────────────────────────────────────┘
    }
}
