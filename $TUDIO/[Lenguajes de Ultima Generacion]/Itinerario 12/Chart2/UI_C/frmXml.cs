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

namespace UI_C
{
    public partial class frmXml : Form
    {
        public frmXml()
        {
            InitializeComponent();
        }

  
 
     

        private void frmCSV_Load(object sender, EventArgs e)
        {
            CargarDatosXML();
        }


        void CargarDatosXML()
        {   
            // Inicializo una instancia de un Dataset
            DataSet DS = new DataSet();
            // Leeo el achivo XML y lo almaceno en el Dataset.
            DS.ReadXml("Personas.xml");
            chart1.DataSource = DS;
            // Especifique los miembros de datos de argumento y valor para la serie.
            chart1.Series[0].XValueMember = "nombre";
            chart1.Series[0].YValueMembers= "saldo";
            //digo q tipo de grafico quiero 
            chart1.Series[0].ChartType = SeriesChartType.StackedColumn;
            //y si lo quiero en 3D
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.DataBind();
        }

   
    }
}
