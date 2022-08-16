using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//uso la libreria
using Microsoft.Reporting.WinForms;

namespace Reporte
{
    public partial class Listas : Form
    {
        public Listas()
        {
            InitializeComponent();
        }

        private void Listas_Load(object sender, EventArgs e)
        {
   
            this.reportViewer1.RefreshReport();
             CargarReporte();

        }

    

        private List<ClsPersona> CargarPersonas()
        {
            List<ClsPersona> ListaPersona = new List<ClsPersona>();
            ClsPersona op1 = new ClsPersona(1, "Juan", "Perez", 20345678, "juan@algo.com", Convert.ToDateTime("10/10/1980"));
            ClsPersona op2 = new ClsPersona(2, "Pedro", "Lopez", 27345678, "pedrito@algo.com", Convert.ToDateTime("16/ 09 / 1989"));
            ClsPersona op3 = new ClsPersona(3, "Analia", "Sanchez", 33987459, "anita@algo.com", Convert.ToDateTime("30/ 08 / 1999"));
            ClsPersona op4 = new ClsPersona(4, "Julieta", "Capuleto", 35113936, "jula@algo.com", Convert.ToDateTime("11 / 11 / 2000"));
            ClsPersona op5 = new ClsPersona(5, "Romeo", "Montesco", 29085312, "romeo@algo.com", Convert.ToDateTime("10 / 10 / 2007"));
            ClsPersona op6 = new ClsPersona(6, "Lorena", "Ramish", 28999742, "lorena@algo.com", Convert.ToDateTime("13 / 04 / 1979"));
            ClsPersona op7 = new ClsPersona(7, "Sergio", "Redel", 39345678, "sergio@algo.com", Convert.ToDateTime("10 / 01 / 2005"));

            ListaPersona.Add(op1);
            ListaPersona.Add(op2);
            ListaPersona.Add(op3);
            ListaPersona.Add(op4);
            ListaPersona.Add(op5);
            ListaPersona.Add(op6);
            ListaPersona.Add(op7);


            return ListaPersona;
        }

        private void CargarReporte()
        {   //le paso el metodo donde se cargan las listas
             this.reportViewer1.LocalReport.DataSources[0].Value = CargarPersonas();
            this.reportViewer1.RefreshReport();

        }

        private void clsPersonaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clsPersonaBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
  }
