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
using System.IO;
using System.Web;

namespace UI_C
{
    public partial class frmImportExport : Form
    {
        public frmImportExport()
        {
            InitializeComponent();
        }

        private void frmImportExport_Load(object sender, EventArgs e)
        {
            CargarGraficos();
        }

        void CargarGraficos()
        {   //datos de los graficos
            String[] xValores = { "Ganados", "Perdidos", "Empatados" };
            Double[] yValores = { 67, 29.48, 49.35 };
            //asocio los valores al control
            chart1.Series["Series1"].Points.DataBindXY(xValores, yValores);
            //titulo
            chart1.Titles.Add("Estadisticas Partidos");

            //Tipo de grafico
            //chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            //Muesto las legendas de cada tipo con su color
            chart1.Legends[0].Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), comboBox1.SelectedItem.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {                
                
                chart1.SaveImage(TextBox1.Text + "." + ComboBox2.SelectedItem.ToString(), (ChartImageFormat)Enum.Parse(typeof(ChartImageFormat), ComboBox2.SelectedItem.ToString()));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo an instance del congtrol  Openfiledialog
                OpenFileDialog AbrirArchivo = new OpenFileDialog();
                string nombreArchivo = null;
                //Seteo las opciones del filtro
                AbrirArchivo.Filter = "Imagenes (*.Jpeg,*.Gif,*.Png,*.Bmp,*.Tiff)|*.Jpeg;*.Gif;*.Bmp;*.Tiff;*.Png";

                if (AbrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //uso el opendialog para traer el archivo y paso el nombre(ruta hasta el arhivo)
                    nombreArchivo = AbrirArchivo.FileName;
                    Image Miimage1 = Image.FromFile(nombreArchivo);
                    GroupBox2.BackgroundImage = ResizeImage(Miimage1);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }

        }


        //cambio el tamño de la imagen x la dimensiones del groupbox2
        public static Image ResizeImage(Image LaImagen)
        {
            return new Bitmap(LaImagen, new Size(304 , 262));
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Palette = (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette), comboBox3.SelectedItem.ToString());
        }
    }
}
