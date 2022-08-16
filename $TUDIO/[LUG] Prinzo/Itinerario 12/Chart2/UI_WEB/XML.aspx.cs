using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace UI_WEB
{
    public partial class XML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosXML();
        }

        void CargarDatosXML()
        {
            // Inicializo una instancia de un Dataset
            DataSet DS = new DataSet();
            // Leeo el achivo XML y lo almaceno en el Dataset.
            DS.ReadXml(Server.MapPath("~/Personas.xml"));
            Chart1.DataSource = DS;
            // Especifique los miembros de datos de argumento y valor para la serie.
            Chart1.Series[0].XValueMember = "nombre";
            Chart1.Series[0].YValueMembers = "saldo";
            //digo q tipo de grafico quiero 
            Chart1.Series[0].ChartType = SeriesChartType.StackedColumn;
            //y si lo quiero en 3D
            Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            Chart1.DataBind();
        }
    }
}