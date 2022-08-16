using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;

namespace UI_WEB
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGraficoListas();
        }

        List<Persona> Lpersonas = new List<Persona>();
        void CargarLista()
        {

            Lpersonas.Add(new Persona() { Codigo = 1, Nombre = "Juan", Apellido = "Perez", Sueldo = 70000 });
            Lpersonas.Add(new Persona() { Codigo = 2, Nombre = "Pedro", Apellido = "Fernandez", Sueldo = 70000 });
            Lpersonas.Add(new Persona() { Codigo = 3, Nombre = "Jose", Apellido = "Gonzalez", Sueldo = 50000 });
            Lpersonas.Add(new Persona() { Codigo = 4, Nombre = "Martin", Apellido = "Garcia", Sueldo = 170000 });
            Lpersonas.Add(new Persona() { Codigo = 5, Nombre = "Roman", Apellido = "Riquelme", Sueldo = 180000 });
            Lpersonas.Add(new Persona() { Codigo = 6, Nombre = "Analia", Apellido = "Lopez", Sueldo = 40000 });
            Lpersonas.Add(new Persona() { Codigo = 7, Nombre = "Lorena", Apellido = "Legrand", Sueldo = 15000 });
            Lpersonas.Add(new Persona() { Codigo = 8, Nombre = "Maria", Apellido = "DelCerro", Sueldo = 39000 });
            Lpersonas.Add(new Persona() { Codigo = 9, Nombre = "Fernanda", Apellido = "Parente", Sueldo = 50000 });
            Lpersonas.Add(new Persona() { Codigo = 10, Nombre = "Ignacio", Apellido = "Claus", Sueldo = 70000 });
        }

        void CargarGraficoListas()
        {
            CargarLista();

            Dictionary<string, double> ListaDatos = new Dictionary<string, double>();

            foreach (Persona objeto in Lpersonas)
            {
                Persona oPer = new Persona();
                oPer = objeto;
                ListaDatos.Add(oPer.Apellido, oPer.Sueldo);

            }


            //inicializo los valores del titulo,  area y serie
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            //agrego el titulo
            Title Titulo = new Title("Chart enlazado con Listas");
            chart1.Titles.Add(Titulo);

            //creo el area y habilito el gráfico en 3D
            ChartArea Area = new ChartArea();
            Area.Area3DStyle.Enable3D = true;
            chart1.ChartAreas.Add(Area);

            //agrego la serie
            Series serie = new Series("Sueldo");
            //digo q tipo de grafico quiero 
            serie.ChartType = SeriesChartType.Line;
            serie.Points.DataBindXY(ListaDatos.Keys, ListaDatos.Values);

            chart1.Series.Add(serie);

        }



    }
}