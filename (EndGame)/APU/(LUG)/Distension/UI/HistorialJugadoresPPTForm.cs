using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class HistorialJugadoresPPTForm : Form
    {
        BE.Historial BE_HISTORIAL;
        BLL.Historial BLL_HISTORIAL;
        public HistorialJugadoresPPTForm()
        {
            InitializeComponent();
            BE_HISTORIAL = new BE.Historial();
            BLL_HISTORIAL = new BLL.Historial();
        }

        private void JugadoresReportForm_Load(object sender, EventArgs e)
        {
            EstadoCombobox.SelectedIndex = 0;
            CargarDatosXML();
        }

        void CargarDatosXML()
        {
            BE_HISTORIAL.ArchivoXML = "JugadoresHistorialPPT.xml";
            BarrasChart.DataSource = BLL_HISTORIAL.CargarDatosXML(BE_HISTORIAL);

            BarrasChart.Series[0].XValueMember = "Nombre";
            BarrasChart.Series[0].YValueMembers = EstadoCombobox.Text;
            BarrasChart.Series[0].LegendText = EstadoCombobox.Text;

            BarrasChart.Series[0].ChartType = SeriesChartType.StackedColumn;
            BarrasChart.DataBind();
        }

        private void EstadoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosXML();
        }
    }
}
