using System;
using System.Data;
using System.Windows.Forms;
using BLL;


namespace Presentacion
{
    public partial class ABMSimpleDesconectado : Form
    {
        public ABMSimpleDesconectado() => InitializeComponent();

        Metodos metodoBLL = new Metodos();
        ClsPersona OPersona = new ClsPersona();
        ClsAuto oAuto = new ClsAuto();
        DataSet dataset = new DataSet();


        private void CargarGrilla_ButtonClick(object sender, EventArgs e)
        {
            CargarGrilla(CargarTabla());
        }


        string CargarTabla()
        {
            if (rdbPersona.Checked) return "Persona";
            else if (rdbAuto.Checked) return "Auto";
            else { MessageBox.Show("Seleccione una tabla"); }
            return null;
        }


        void CargarGrilla(String tabla)
        {
            if (tabla == "Persona")
            { 
                dataset = OPersona.ListarConSaldo();
                //CARGAR LA TABLA
                mGrilla.DataSource = null;
                mGrilla.DataSource = dataset.Tables[0];
                mGrilla.Columns[4].DefaultCellStyle.Format = "C";
            }
            else if (tabla == "Auto")
            { dataset = oAuto.Listar();
                //CARGAR LA TABLA
                mGrilla.DataSource = null;
                mGrilla.DataSource = dataset.Tables[0];
            }
            else
            { dataset = null; }
        }


        private void btnDescartar_Click(object sender, EventArgs e)
        {
            metodoBLL.DescartarCambios(dataset);
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (rdbPersona.Checked)
            {
                metodoBLL.GrabarCambios("Persona", dataset);
                CargarGrilla("Persona");
            }
            else
            {
                metodoBLL.GrabarCambios("Auto", dataset);
                CargarGrilla("Auto");
            }
        }


        private void ABMSimpleDesconectado_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_ABMSimpleDesconectado = false;
        }


    }
}
