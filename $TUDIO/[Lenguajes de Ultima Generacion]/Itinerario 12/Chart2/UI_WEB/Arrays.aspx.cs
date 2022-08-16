using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace UI_WEB
{
    public partial class Arrays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargargraficoArray();
        }

        void cargargraficoArray()
        {
            //creo los array y le asigno valores
            double[] yValores = { 15, 28.5, 9, 17, 41.5 };
            string[] xNombres = { " Juan", " Perdro", " Martin", " Julio", " Anibal" };



         // ChartAreas: es el área donde se traza un gráfico. Se puede contener más de un gráfico por renderizado e incluso puede superponer tablas.
        //Series: Son los datos que puede trazar en el área de su gráfico.
        //ChartType: la propiedad de tipo de gráfico se encuentra bajo la propiedad Series y define cómo se mostrará la serie de datos en el gráfico.
        //Axes: define propiedades para los ejes X e Y, como apariencia y títulos.
        //Palette : define los colores establecidos para su gráfico.
        //Titles : define el texto que se puede usar para describir un gráfico, un eje o cualquier otra parte del gráfico.

            //inicializo los valores del titulo
            Chart1.Titles.Clear();
   

            //agrego el titulo
            Title Titulo = new Title("Chart enlazado con Arrays");
            Chart1.Titles.Add(Titulo);

    
            Chart1.Series[0].Points.DataBindXY(xNombres, yValores);
            //digo q tipo de grafico quiero (pie= torta)
            Chart1.Series[0].ChartType = SeriesChartType.Pie;
            //y si lo quiero en 3D
            Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        }
    }
}