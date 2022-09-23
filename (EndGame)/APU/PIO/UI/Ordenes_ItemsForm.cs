using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Ordenes_ItemsForm : Form
    {
        #region |||||||||||||||||||||||||||||||||||||||||||||||||||| AUTOMÁTICO

        public Ordenes_ItemsForm() => InitializeComponent();

        private void MostrarEnReporte(DateTime desde, DateTime hasta)
        {
            MPP.Reporte datos = new MPP.Reporte();
            datos.MapearReporte(desde, hasta);

            ReporteBindingSource.DataSource = datos;
            ReporteListadoBindingSource.DataSource = datos.REPORTE_LISTADO;
            ReportePeriodoBindingSource.DataSource = datos.REPORTE_PERIODO;

            this.ReportViewer.RefreshReport();
        }

        private void Ordenes_Items_Load(object sender, EventArgs e)
        {
            var desde = new DateTime(2020, 1, 1);
            var hasta = new DateTime(2022, 7, 1);
            MostrarEnReporte(desde, hasta);
        }

        #endregion

        //-------------------------------------------------------------------//

        #region ||||||||||||||||||||||||||||||||||||||||||||||||||| INTERACTIVO

        private void HoyButton_Click(object sender, EventArgs e)
        {
            var desde = DateTime.Today;
            var hasta = DateTime.Now;
            MostrarEnReporte(desde, hasta);
        }

        private void UltimosSieteButton_Click(object sender, EventArgs e)
        {
            var desde = DateTime.Today.AddDays(-7);
            var hasta = DateTime.Now;
            MostrarEnReporte(desde, hasta);
        }

        private void EsteMesButton_Click(object sender, EventArgs e)
        {
            var desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var hasta = DateTime.Now;
            MostrarEnReporte(desde, hasta);
        }

        private void UltimosTreintaButton_Click(object sender, EventArgs e)
        {
            var desde = DateTime.Today.AddDays(-30);
            var hasta = DateTime.Now;
            MostrarEnReporte(desde, hasta);
        }

        private void EsteAñoButton_Click(object sender, EventArgs e)
        {
            var desde = new DateTime(DateTime.Now.Year, 1, 1);
            var hasta = DateTime.Now;
            MostrarEnReporte(desde, hasta);
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            var desde = DesdeDTP.Value;
            var hasta = HastaDTP.Value;
            MostrarEnReporte(desde, new DateTime(hasta.Year, hasta.Month, hasta.Day, 23, 59, 59));
        }

        #endregion
    }
}
