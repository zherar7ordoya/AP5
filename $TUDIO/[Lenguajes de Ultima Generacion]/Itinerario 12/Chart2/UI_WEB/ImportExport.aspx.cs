using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;


namespace UI_WEB
{
    public partial class ImportExport : System.Web.UI.Page
    {

    
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                List<string> listaGraficos = new List<string> {"Bar",
            "BoxPlot",
            "Bubble",
            "Candlestick",
            "Column",
            "Doughnut",
            "ErrorBar",
            "FastLine",
            "FastPoint",
            "Funnel",
            "Kagi",
            "Line",
            "Pie",
            "Point",
            "PointAndFigure",
            "Polar",
            "Pyramid",
            "Radar",
            "Range",
            "RangeBar",
            "RangeColumn",
            "Renko",
            "Spline",
            "SplineArea",
            "SplineRange",
            "StackedArea",
            "StackedArea100",
            "StackedBar",
            "StackedBar100",
            "StackedColumn",
            "StackedColumn100",
            "StepLine",
            "Stock",
            "ThreeLineBreak" };

                List<string> listaColores = new List<string> {"Berry",
            "Bright",
            "BrightPastel",
            "Chocolate",
            "EarthTones",
            "Excel",
            "Fire",
            "Grayscale",
            "Light",
            "None",
            "Pastel",
            "SeaGreen" };

                List<string> listaFormatos = new List<string> {"Bmp",
            "Gif",
            "Jpeg",
            "Png",
            "Tiff" };

                foreach (string item in listaGraficos)
                {
                    ddlGraficos.Items.Add(item);
                }

                foreach (string item in listaColores)
                {
                    ddlColores.Items.Add(item);
                }

                foreach (string item in listaFormatos)
                {
                    ddlFormato.Items.Add(item);
                }
            }

            CargarGraficos();
            

            changeChart();
        }

        void CargarGraficos()
        {   //datos de los graficos
            String[] xValores = { "Ganados", "Perdidos", "Empatados" };
            Double[] yValores = { 67, 29.48, 49.35 };
            //asocio los valores al control
            Chart1.Series["Series1"].Points.DataBindXY(xValores, yValores);
            //titulo
            Chart1.Titles.Add("Estadisticas Partidos");

            //Tipo de grafico
            //Chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            //Muesto las legendas de cada tipo con su color
            Chart1.Legends[0].Enabled = true;
        }

        protected void ddlGraficos_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeChart();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
              
                string ruta = @"~\MisCapturas\";
          
                    
               Chart1.SaveImage(ruta+txtNombre.Text + "." + ddlFormato.SelectedItem.ToString(), (ChartImageFormat)Enum.Parse(typeof(ChartImageFormat), ddlFormato.SelectedItem.ToString()));







            }
            catch (Exception ex)
            { Response.Write(ex.ToString()); }
        }

        protected void ddlColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeChart();
        }

        void changeChart ()
        {
            Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), ddlGraficos.SelectedItem.ToString());

            Chart1.Palette = (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette), ddlColores.SelectedItem.ToString());

        }

       
    }
}