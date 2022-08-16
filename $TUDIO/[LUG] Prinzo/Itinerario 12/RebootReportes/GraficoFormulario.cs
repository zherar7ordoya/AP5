using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RebootReportes
{
    public partial class GraficoFormulario : Form
    {
        public GraficoFormulario() => InitializeComponent();

        readonly List<Persona> Personas = new List<Persona>();

        void CargarLista()
        {
            Personas.Add(new Persona() { Codigo = 1, Nombre = "Gregory", Apellido = "House", Sueldo = 70000 });
            Personas.Add(new Persona() { Codigo = 2, Nombre = "James", Apellido = "Wilson", Sueldo = 70000 });
            Personas.Add(new Persona() { Codigo = 3, Nombre = "Eric", Apellido = "Foreman", Sueldo = 50000 });
            Personas.Add(new Persona() { Codigo = 4, Nombre = "Robert", Apellido = "Chase", Sueldo = 170000 });
            Personas.Add(new Persona() { Codigo = 5, Nombre = "Lisa", Apellido = "Cuddy", Sueldo = 180000 });
            Personas.Add(new Persona() { Codigo = 6, Nombre = "Allison", Apellido = "Cameron", Sueldo = 40000 });
            Personas.Add(new Persona() { Codigo = 7, Nombre = "Chris", Apellido = "Taub", Sueldo = 15000 });
            Personas.Add(new Persona() { Codigo = 8, Nombre = "Remy", Apellido = "«Trece» Hadley", Sueldo = 39000 });
            Personas.Add(new Persona() { Codigo = 9, Nombre = "Lawrence", Apellido = "Kutner", Sueldo = 50000 });
        }

        void CargarGraficoListas()
        {
            CargarLista();

            Dictionary<string, double> ListaDatos = new Dictionary<string, double>();

            foreach (Persona item in Personas)
            {
                Persona persona = item;
                ListaDatos.Add(persona.Apellido, persona.Sueldo);
            }

            //inicializo los valores del titulo,  area y serie
            Grafico.Titles.Clear();
            Grafico.ChartAreas.Clear();
            Grafico.Series.Clear();

            //agrego el titulo
            Title titulo = new Title("Chart enlazado con Listas")
            {
                Font = new Font("Agency FB", 40)
            };
            Grafico.Titles.Add(titulo);

            //creo el area y habilito el gráfico en 3D
            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            Grafico.ChartAreas.Add(area);

            //agrego la serie
            Series serie = new Series("Sueldo")
            {
                //digo q tipo de grafico quiero 
                ChartType = SeriesChartType.Doughnut
            };
            serie.Points.DataBindXY(ListaDatos.Keys, ListaDatos.Values);

            Grafico.Series.Add(serie);
        }

        private void GraficoFormulario_Load(object sender, EventArgs e) => CargarGraficoListas();
    }
}
