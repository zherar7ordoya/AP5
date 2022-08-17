using System.Windows.Forms;

namespace RebootReportes
{
    public partial class InformeDataSet : Form
    {
        public InformeDataSet() => InitializeComponent();

        private void InformeFormulario_Load(object sender, System.EventArgs e)
        {
            PersonaTableAdapter.Fill(i12DataSet.Persona);
            reportViewer1.RefreshReport();
        }
    }
}
