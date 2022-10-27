using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
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
            // Uf...!
            if (
                int.TryParse(NumeroPuestoTextbox.Text, out int puesto) &&
                !string.IsNullOrWhiteSpace(NombrePuestoTextbox.Text)
               )
            {
                if (puesto < 0) return false;

                if (
                    decimal.TryParse(MontoPremioTextbox.Text, out decimal monto) ||
                    int.TryParse(PorcentajePremioTextbox.Text, out int porcentaje)
                   )
                {
                    if (monto < 0 || porcentaje < 0) return false;
                }
                else return false;
            }
            else return false;
            return true;
        }
    }
}
