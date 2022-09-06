using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace Presentacion
{
    public partial class FrmCrearDS : Form
    {
        public FrmCrearDS() => InitializeComponent();

        Metodos oBLL = new Metodos();
        public DataSet dataset = new DataSet();

        private void FrmCrearDS_Load(object sender, EventArgs e)
        {
            BtnCargarDs.Enabled = false;
            BtnMostrarDs.Enabled = false;
            groupBoxFiltros.Enabled = false;
        }

        private void BtnCrearDs_Click(object sender, EventArgs e)
        {
            dataset = oBLL.ArmarDataSet();
            BtnCargarDs.Enabled = true;
        }

        private void BtnCargarDs_Click(object sender, EventArgs e)
        {
            //LE PASO EL DATASET A CARGAR.
            oBLL.CargarDataSet(dataset);
            BtnMostrarDs.Enabled = true;
        }

        private void BtnMostrarDs_Click(object sender, EventArgs e)
        {
            //1RA FORMA DE CARGAR.
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = dataset;
            dgvPersonas.DataMember = "Persona";

            //2DA FORMA DE CARGAR.
            dgvPaises.DataSource = null;
            dgvPaises.DataSource = dataset.Tables["Pais"];

            //HABILITAR FILTROS.
            groupBoxFiltros.Enabled = true;
        }


        // *-------------------------------------------------------=> 2DA PARTE


        private void FiltrarDataTable_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if ((txtInicio.Text == string.Empty) || (txtFin.Text == string.Empty))
                { MessageBox.Show("Debe ingresar las fechas para la busqueda"); }
                else
                {
                    DataTable datatable = dataset.Tables["Persona"];
                    string Filtro = null;
                    Filtro =
                        "FechaNac >= #1/1/" + 
                        txtInicio.Text.Trim() + 
                        "# AND FechaNac <= #12/31/" + 
                        txtFin.Text.Trim() + 
                        "#";

                    //LIMPIO GRILLA
                    dgvFiltros.Columns.Clear();

                    //this.DGV.Columns.Add(nombre_columna, encabezado_columna);
                    dgvFiltros.Columns.Add("Codigo_Persona", "Codigo_Persona");
                    dgvFiltros.Columns.Add("Nombre", "Nombre");
                    dgvFiltros.Columns.Add("Apellido", "Apellido");
                    dgvFiltros.Columns.Add("FechaNac", "FechaNac");
                    dgvFiltros.Columns.Add("Persona_Pais_Id", "Persona_Pais_Id");
                    dgvFiltros.DataSource = null;

                    //FILTRADO ( SE PUEDE AGREGAR COLUMNA DE ORDEN)
                    foreach (DataRow fila in datatable.Select(Filtro, "FechaNac"))
                    {
                        dgvFiltros.Rows.Add(
                            fila["Codigo_Persona"], 
                            fila["Apellido"], 
                            fila["Nombre"], 
                            Convert.ToDateTime(fila["FechaNac"]).ToShortDateString(), 
                            fila["Persona_Pais_Id"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }





        private void FiltrarDataView_ButtonClick(object sender, EventArgs e)
        {
            try
            {   //CREAR Y CARGAR UNA TABLA  Y VISTA TEMPORALES.
                DataTable datatable = dataset.Tables["Persona"];
                DataView dataview = new DataView(datatable);

                if ((rdbPais.Checked) && (TxfiltroData.Text != string.Empty))
                {
                    //ROWFILTER ES EL FILTRO.
                    dataview.RowFilter = "Persona_Pais_Id = " + TxfiltroData.Text.Trim();

                    //ESPECIFICAR LA COLUMNA QUE QUIERO ORDENAR.
                    dataview.Sort = "FechaNac";

                    //LIMPIAR (MEMORIA Y CONTROL) Y CARGAR NUEVA DATA.
                    dgvFiltros.Columns.Clear();
                    dgvFiltros.DataSource = null;
                    dgvFiltros.DataSource = dataview;
                }
                else if ((rdbApe.Checked) && (TxfiltroData.Text != string.Empty))
                {
                    dataview.RowFilter = "Apellido = '" + TxfiltroData.Text.Trim() + "'";
                    dataview.Sort = "FechaNac";

                    dgvFiltros.Columns.Clear();
                    dgvFiltros.DataSource = null;
                    dgvFiltros.DataSource = dataview;
                }
                else { MessageBox.Show("Debe seleccionar una opción y llenar el campo de búsqueda."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void LimpiarFiltro_ButtonClick(object sender, EventArgs e)
        {
            txtFin.Text = string.Empty;
            txtInicio.Text = string.Empty;
            TxfiltroData.Text = string.Empty;
            rdbApe.Checked = false;
            rdbPais.Checked = false;

            //COMO ESTOY EN MEMORIA, DEBO BORRAR LA GRILLA COMPLETA SINO QUEDAN
            //LAS COLUMNAS.
            dgvFiltros.Columns.Clear();
        }

        private void FrmCrearDS_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_FrmCrearDS = false;
        }
    }
}
