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
    public partial class FDataSet : Form
    {
        public FDataSet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miBase2DataSet1.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.miBase2DataSet1.Persona);
            
            this.reportViewer1.RefreshReport();


        }

        //void CargarReporte()
        //{
        //    ///Mostrar datos en el reporte
        //    ReportDataSource rds1 = new ReportDataSource("Alumnos");
        //    this.reportViewer1.LocalReport.DataSources.Clear();
        //    this.reportViewer1.LocalReport.DataSources.Add(rds1);
        //    this.reportViewer1.RefreshReport();

        //}




    }
}
