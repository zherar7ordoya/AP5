using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace UI
{
    public partial class HistorialJuegosForm : Form
    {
        BE.Historial BE_HISTORIAL;
        BLL.Historial BLL_HISTORIAL;

        public HistorialJuegosForm()
        {
            InitializeComponent();
            BE_HISTORIAL = new BE.Historial();
            BLL_HISTORIAL = new BLL.Historial();
        }

        private void JuegosReportForm_Load(object sender, EventArgs e)
        {
            CargarDatosXML();
        }

        void CargarDatosXML()
        {
            try
            {
                BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
                BarrasChart.DataSource = BLL_HISTORIAL.CargarDatosXML(BE_HISTORIAL);

                BarrasChart.Series[0].XValueMember = "Nombre";
                BarrasChart.Series[0].YValueMembers = "Contador";
                BarrasChart.Series[0].LegendText = "CONTEO";

                BarrasChart.Series[0].ChartType = SeriesChartType.StackedColumn;
                BarrasChart.DataBind();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
