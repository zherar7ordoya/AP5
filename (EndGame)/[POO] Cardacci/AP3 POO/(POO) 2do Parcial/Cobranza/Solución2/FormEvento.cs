using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANCELOS_POO_2P
{
    public partial class FormEvento : Form
    {
        #region CONSTRUCTOR

        public FormEvento(List<ClsPrestamo> pLP, DateTime pFechaActual)
        {
            InitializeComponent();

            txtFecha.Text = pFechaActual.ToShortDateString();
            ConfigurarGrilla(Grilla8);
            Grilla8.DataSource = null;
            Grilla8.DataSource = ListaVistaGrillaEvento.RetornaListaVistaGrillaEvento(pLP).ToList<ClsListaVistaGrillaEvento>();
            //Nombres de las columnas
            Grilla8.Columns[4].HeaderText = "Interés";
            Grilla8.Columns[5].HeaderText = "Total a Retornar";
            Grilla8.Columns[6].HeaderText = "Fecha Vencimiento";
        }

        #endregion

        #region VARIABLES GLOBALES

        //Instancio la vista de la grilla
        ClsListaVistaGrillaEvento ListaVistaGrillaEvento = new ClsListaVistaGrillaEvento();

        #endregion

        #region METODOS

        private void ConfigurarGrilla(DataGridView pD)
        {
            pD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pD.MultiSelect = false;
            pD.EnableHeadersVisualStyles = false; //Anula el estilo visual de Windows
            pD.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff; // Color de la alternancia
            pD.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon; // Encabezado de Columnas
            pD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de Fuente del encabezado
            pD.RowHeadersDefaultCellStyle.BackColor = Color.IndianRed; // Color del encabezado de Fila     
            pD.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Firebrick;
            pD.DefaultCellStyle.SelectionBackColor = Color.Firebrick; // Color de fondo de Selección de la fila
            pD.DefaultCellStyle.SelectionForeColor = Color.White; // Color de la fuente de la fila seleccionada
            pD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // Celdas Autoajustables
            pD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Alineación del Texto
            pD.BackgroundColor = Color.PeachPuff; // Color de Fondo           
        }

        private void btnCerrar_Click(object sender, EventArgs e) //Cierro el formulario
        {
            this.Close();
        }

        #endregion

    }
}
