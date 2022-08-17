using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RebootReportes
{
    public partial class InformeList : Form
    {
        public InformeList() => InitializeComponent();

        private void InformeList_Load(object sender, EventArgs e)
        {
            ReporteRV.RefreshReport();
            CargarReporte();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private List<Persona> CargarPersonas()
        {
            Persona persona;
            List<Persona> ListaPersona = new List<Persona>();

            persona = new Persona(1, "Juan", "Perez", 20345678,
                "juan@algo.com", Convert.ToDateTime("10/10/1980"));
            ListaPersona.Add(persona);

            persona = new Persona(2, "Pedro", "Lopez", 27345678,
                "pedrito@algo.com", Convert.ToDateTime("16/09/1989"));
            ListaPersona.Add(persona);

            persona = new Persona(3, "Analia", "Sanchez", 33987459,
                "anita@algo.com", Convert.ToDateTime("30/08/1999"));
            ListaPersona.Add(persona);

            persona = new Persona(4, "Julieta", "Capuleto", 35113936, 
                "jula@algo.com", Convert.ToDateTime("11/11/2000"));
            ListaPersona.Add(persona);

            persona = new Persona(5, "Romeo", "Montesco", 29085312, 
                "romeo@algo.com", Convert.ToDateTime("10/10/2007"));
            ListaPersona.Add(persona);

            persona = new Persona(6, "Lorena", "Ramish", 28999742, 
                "lorena@algo.com", Convert.ToDateTime("13/04/1979"));
            ListaPersona.Add(persona);

            persona = new Persona(7, "Gerardo", "Tordoya", 39345678, 
                "gtordoya@mail.net", Convert.ToDateTime("10/01/2005"));
            ListaPersona.Add(persona);

            return ListaPersona;
        }

        private void CargarReporte()
        {
            ReporteRV.LocalReport.DataSources[0].Value = CargarPersonas();
            ReporteRV.RefreshReport();
        }
    }
}
