using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace Presentacion
{
    public partial class ABMSimple_TextBox : Form
    {
        public ABMSimple_TextBox() => InitializeComponent();

        /*
         * ********************************************** VARIABLES NIVEL CLASE
         */

        //DECLARAMOS LA CONEXION A ESTE NIVEL PARA PODER APROVECHAR LOS EVENTOS
        //EN TODO EL FORMULARIO
        SqlConnection CONEXION = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=Ejemplos_LUG;
            Integrated Security=True");

        //CREO EL OBJETO PERSONA SOLO PARA USAR EL LISTAR 
        BLL.ClsPersona PERSONA = new BLL.ClsPersona();

        //DECLARAMOS EL DATASET
        DataSet DATA_SET = new DataSet();

        //DECLARAMOS EL DATAROW PARA APROVECHAR LOS EVENTOS DEL FORMULARIO
        DataRow DATA_ROW;

        //DECLARAMOS EL DA PARA APROVECHAR LOS EVENTOS DEL FORMULARIO
        SqlDataAdapter DATA_ADAPTER;


        /*
         * ************************************************************** CARGA
         */

        private void On_Load(object sender, EventArgs e) => CargarGrilla();

        public void CargarGrilla()
        {
            DATA_SET = PERSONA.ListarSinSaldo();
            mGrilla.DataSource = null;
            mGrilla.DataSource = DATA_SET.Tables[0];
        }


        /*
         * ******************************************************* HERRAMIENTAS
         */

        private void mGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = mGrilla.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = mGrilla.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApellido.Text = mGrilla.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDireccion.Text = mGrilla.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        void LimpiarTextBoxes()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox box) box.Text = string.Empty;
            }
        }


        /*
         * ************************************************************ BOTONES
         */

        private void Nuevo_Click(object sender, EventArgs e)
        {
            if (
                Controls.OfType<TextBox>().Any(
                    x => string.IsNullOrEmpty(x.Text)))
                MessageBox.Show("Debe completar los campos");
            else
            {
                DATA_ROW = DATA_SET.Tables[0].NewRow();

                DATA_ROW["persona_id"] = Convert.ToInt32(txtId.Text);
                DATA_ROW["persona_nombre"] = txtNombre.Text.ToString();
                DATA_ROW["persona_apellido"] = txtApellido.Text.ToString();
                DATA_ROW["persona_direccion"] = txtDireccion.Text.ToString();

                DATA_SET.Tables[0].Rows.Add(DATA_ROW);

                LimpiarTextBoxes();
            }
        }


        private void Modificar_Click(object sender, EventArgs e)
        {
            //PREGUNTO SI HAY UNA FILA SELECCIONADA DEL DATAGRIDVIEW. ASÍ,
            //OBLIGO A SELECCIONARLA PARA LLENAR EL DATAROW CON LOS DATOS DE
            //ESA FILA.
            if (mGrilla.SelectedCells.Count == 1) MessageBox.Show("Seleccione la fila que desea modificar");
            else
            {
                //RESGUARDAMOS EL DATAROW QUE ESTA ENLAZADO AL ROW SELECCIONADO 
                DATA_ROW = ((DataRowView)mGrilla.SelectedRows[0].DataBoundItem).Row;

                //MODIFICAMOS LOS CAMPOS EN EL DATAROW QUE HABIAMOS OBTENIDO
                //SELECCIONANDO LA FILA DE LA GRILLA
                DATA_ROW["persona_nombre"] = txtNombre.Text;
                DATA_ROW["persona_apellido"] = txtApellido.Text;
                DATA_ROW["persona_direccion"] = txtDireccion.Text;
            }
            LimpiarTextBoxes();
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (mGrilla.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"¿Eliminar a {mGrilla.SelectedRows[0].Cells[1].Value} " +
                    $"{mGrilla.SelectedRows[0].Cells[2].Value}?",
                    "Eliminación",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //EL USUARIO CONFIRMO LA ELIMINACION Y SE PROCEDE A
                    //ELIMINAR EL DATAROW DEL DATASET QUE ESTA ENLAZADO A LA
                    //ROW SELECCIONADA DE LA GRILLA.
                    ((DataRowView)mGrilla.SelectedRows[0].DataBoundItem).Row.Delete();
                }
                else { MessageBox.Show("Cancelado"); }
            }
            LimpiarTextBoxes();
        }


        private void Cancelar_Click(object sender, EventArgs e) => LimpiarTextBoxes();


        private void Cargar_Click(object sender, EventArgs e)
        {
            DATA_SET.Tables[0].Rows.Clear();
            CargarGrilla();
        }


        //*******************************************************************\\

        private void Grabar_Click(object sender, EventArgs e)
        {
            //DEFINO CONSULTA Y CONNECTION_STRING DE SQL_ADAPTER
            DATA_ADAPTER = new SqlDataAdapter(
                "SELECT Persona_id, Persona_nombre, Persona_apellido, Persona_direccion " +
                "FROM Persona", CONEXION);

            // SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder COMMAND_BUILDER = new SqlCommandBuilder(DATA_ADAPTER);
            DATA_ADAPTER.UpdateCommand = COMMAND_BUILDER.GetUpdateCommand();
            DATA_ADAPTER.DeleteCommand = COMMAND_BUILDER.GetDeleteCommand();
            DATA_ADAPTER.InsertCommand = COMMAND_BUILDER.GetInsertCommand();
            DATA_ADAPTER.ContinueUpdateOnError = true;

            //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            DATA_ADAPTER.Update(DATA_SET.Tables[0]);
        }


        /// <summary>
        /// SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET. SI ALGÚN DATAROW HABIA 
        /// SIDO AGREGADO Y SE AUMENTÓ EL MÁXIMO ID EN NUESTRA SEGUNDA TABLA, 
        /// TAMBIEN SE DESCARTAN ESOS CAMBIOS. POR ESO SE DESHACEN LOS CAMBIOS 
        /// DE TODO EL DATASET Y NO SOLO DE LA TABLA PERSONA.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Descartar_Click(object sender, EventArgs e) => DATA_SET.RejectChanges();


        //*******************************************************************\\


        private void ABMSimple_TextBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_ABMSimple_TextBox = false;
        }


    }
}
