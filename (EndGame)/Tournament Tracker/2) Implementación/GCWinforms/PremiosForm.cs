using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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

        private void CrearPremioButton_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos()) MessageBox.Show("Todo bien!");
            else MessageBox.Show("Todo mal...");
        }

        private bool ValidarDatos()
        {
            //if (
            //    int.TryParse(PosicionTextbox.Text, out int puesto) &&
            //    !string.IsNullOrWhiteSpace(NombreTextbox.Text)
            //   )
            //{
            //    if (puesto < 0) return false;

            //    if (
            //        decimal.TryParse(MontoTextbox.Text, out decimal monto) ||
            //        int.TryParse(PorcentajePremioTextbox.Text, out int porcentaje)
            //       )
            //    {
            //        if (monto < 0 || porcentaje < 0) return false;
            //    }
            //    else return false;
            //}
            //else return false;
            return true;
        }



        // ┌── EMPIEZA EVENTOS ───────────────────────────────────────────────┐
        private void MontoRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            PorcentajeCombobox.Text = "0";
            PorcentajeCombobox.Enabled = false;
            MontoTextbox.Enabled = true;
        }

        private void PorcentajeRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            MontoTextbox.Text = "0.00";
            MontoTextbox.Enabled = false;
            PorcentajeCombobox.Enabled = true;
            PorcentajeCombobox.Items.AddRange(Enumerable.Range(1, 100).Select(i => (object)i).ToArray());
        }
        // └── TERMINA EVENTOS ───────────────────────────────────────────────┘
    }
}
