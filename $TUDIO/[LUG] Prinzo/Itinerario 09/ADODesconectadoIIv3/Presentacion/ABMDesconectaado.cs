using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class ABMDesconectaado : Form
    {
        public ABMDesconectaado() => InitializeComponent();


        //|||||||||||||||||||||||||||||||||||||||||||||||||| VARIABLES DE CLASE

        //DECLARAMOS LA CONEXION A ESTE NIVEL PARA PODER APROVECHAR LOS EVENTOS
        //EN TODO EL FORMULARIO.
        readonly SqlConnection CONEXION = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=Ejemplos_LUG;
                Integrated Security=True");

        //CREO EL OBJETO PERSONA SOLO PARA USAR EL LISTAR.
        readonly ClsPersona PERSONA = new ClsPersona();

        //DECLARAMOS EL DATASET.
        DataSet DATA_SET = new DataSet();

        //DECLARAMOS EL DATAROW PARA APROVECHAR LOS EVENTOS DEL FORMULARIO.
        DataRow DATA_ROW;

        //DECLARAMOS EL DATAADAPTER PARA APROVECHAR LOS EVENTOS DEL FORMULARIO.
        SqlDataAdapter DATA_ADAPTER;

        //UTILIZAREMOS ESTE ENUMERADO Y ESTA VARIABLE COMO FLAG PARA SABER SI
        //VAMOS A MODIFICAR O AGREGAR UNA PERSONA.
        enum Accion
        {
            Modificar = 1,
            Nuevo = 2
        }

        Accion EAccion;


        //||||||||||||||||||||||||||||||||||||||||| PROCESO DE CARGA Y DESCARGA


        private void LoadForm(object sender, EventArgs e)
        {
            SetearGrilla();
            CargarGrilla();

            //SE SETEAN LOS BOTONES
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnDeshacer.Enabled = false;

            mGrilla.ClearSelection();
        }

        public void SetearGrilla()
        {
            DataGridView GRILLA = mGrilla;
            DataGridViewColumnCollection COLUMNA = GRILLA.Columns;

            COLUMNA.Add("cEstado", "Estado");
            COLUMNA.Add("cId", "Id");
            COLUMNA.Add("cNombre", "Nombre");
            COLUMNA.Add("cApellido", "Apellido");
            COLUMNA.Add("cDireccion", "Dirección");

            COLUMNA["cId"].Width = 32;
            COLUMNA["cId"].DataPropertyName = "Persona_id";
            COLUMNA["cId"].ReadOnly = true;
            COLUMNA["cNombre"].Width = 110;
            COLUMNA["cNombre"].DataPropertyName = "Persona_nombre";
            COLUMNA["cNombre"].ReadOnly = true;
            COLUMNA["cApellido"].Width = 110;
            COLUMNA["cApellido"].DataPropertyName = "Persona_apellido";
            COLUMNA["cApellido"].ReadOnly = true;
            COLUMNA["cDireccion"].Width = 120;
            COLUMNA["cDireccion"].ReadOnly = true;
            COLUMNA["cDireccion"].DataPropertyName = "Persona_direccion";

            GRILLA.AllowDrop = false;
            GRILLA.AllowUserToAddRows = false;
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AllowUserToResizeColumns = false;
            GRILLA.AllowUserToResizeRows = false;
            GRILLA.RowHeadersVisible = true;
            GRILLA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GRILLA.MultiSelect = false;
        }

        public void CargarGrilla()
        {
            DATA_SET = PERSONA.ListarSinSaldo();
            //ENLAZAMOS LA GRILLA 
            mGrilla.DataSource = null;
            mGrilla.DataSource = DATA_SET.Tables[0];
        }


        private void UnloadForm(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_ABMDesconectaado = false;
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BOTONES


        private void Guardar_Click(object sender, EventArgs e)
        {
            switch (EAccion)
            {
                case Accion.Modificar:
                    // MODIFICAMOS LOS CAMPOS EN EL DATAROW QUE HABIAMOS
                    // OBTENIDO EN EL METODO "".
                    DATA_ROW["persona_nombre"] = txtNombre.Text;
                    DATA_ROW["persona_apellido"] = txtApellido.Text;
                    DATA_ROW["persona_direccion"] = txtDireccion.Text;
                    mGrilla.SelectedRows[0].Cells[0].Value = DATA_ROW.RowState.ToString();
                    break;

                case Accion.Nuevo:
                    // ACTUALIZAMOS EL ULTIMO ID DE PERSONA EN LA SEGUNDA TABLA
                    // DE NUESTRO DATASET.
                    DATA_SET.Tables[1].Rows[0][0] = (int.Parse(DATA_SET.Tables[1].Rows[0][0].ToString())) + 1;
                    txtId.Text = DATA_SET.Tables[1].Rows[0][0].ToString();

                    // OBTENEMOS UNA NUEVA ROW PARA LA TABLA "PERSONA" Y LE
                    // PASAMOS LOS DATOS DE NUESTRA CAJAS DE TEXTO.
                    DATA_ROW = DATA_SET.Tables[0].NewRow();
                    DATA_ROW["persona_id"] = Convert.ToInt32(txtId.Text);
                    DATA_ROW["persona_nombre"] = txtNombre.Text;
                    DATA_ROW["persona_apellido"] = txtApellido.Text;
                    DATA_ROW["persona_direccion"] = txtDireccion.Text;

                    // SE AGREGA LA NUEVA ROW AL DATATABLE
                    DATA_SET.Tables[0].Rows.Add(DATA_ROW);

                    mGrilla.Rows[mGrilla.Rows.Count - 1].Selected = true;
                    mGrilla.SelectedRows[0].Cells[0].Value = DATA_ROW.RowState.ToString();

                    break;
            }

            // SETEMOS LOS BOTONES E INTERFAZ DE USUARIO
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDireccion.Text = null;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            mGrilla.Enabled = true;

            if ((mGrilla.SelectedRows.Count > 0))
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnDeshacer.Enabled = true;
            }

            btnNuevo.Enabled = true;
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDireccion.Text = null;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            mGrilla.Enabled = true;

            if (mGrilla.SelectedRows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            btnNuevo.Enabled = true;
        }

        //---------------------------------------------------------------------


        private void Nuevo_Click(object sender, EventArgs e)
        {
            // SETEO DE LOS BOTONES E INTERFAZ
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDireccion.Text = null;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            mGrilla.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;

            if (DATA_SET.Tables[1].Rows[0] is null == false && IsNumeric(DATA_SET.Tables[1].Rows[0][0].ToString()))
            {
                int a = (int.Parse(DATA_SET.Tables[1].Rows[0][0].ToString())) + 1;
                txtId.Text = a.ToString();
            }
            else { txtId.Text = "1"; }

            // ESTE FLAG LO UTILIZAMOS PARA QUE AL PRESIONAR EL BOTON GUARDAR
            // SEPAMOS QUÉ ESTAMOS HACIENDO: SI ESTAMOS AGREGANDO UNA NUEVA
            // PERSONA O SI ESTAMOS MODIFICANDO UNA.
            EAccion = Accion.Nuevo;
        }


        private void Modificar_Click(object sender, EventArgs e)
        {
            //SI HAY UNA FILA SELECCONADA SE LLENAN LOS CAMPOS PARA MODIFICARSE
            {
                if (mGrilla.SelectedRows.Count > 0)
                {
                    //RESGUARDAMOS EL DATAROW QUE ESTA ENLAZADO AL ROW
                    //SELECCIONADO EN LA VARIABLE DECLARADA CON AMBITO DE CLASE
                    //(FORMULARIO) PARA PODER ACCEDERLO DESDE EL METODO GUARDAR.
                    DATA_ROW = ((DataRowView)mGrilla.SelectedRows[0].DataBoundItem).Row;

                    //LLENAMOS LOS CAMPOS CON LOS VALORES ACTUALES DEL DATAROW
                    txtId.Text = DATA_ROW[0].ToString();
                    txtNombre.Text = DATA_ROW[1].ToString();
                    txtApellido.Text = DATA_ROW[2].ToString();
                    txtDireccion.Text = DATA_ROW[3].ToString();

                    //SETEMAMOS LOS BOTONES E INTERFAZ DE USUARIO
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtDireccion.Enabled = true;

                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;

                    mGrilla.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnNuevo.Enabled = false;

                    //ESTE FLAG LO UTILIZAMOS PARA QUE AL PRESIONAR EL BOTON
                    //GUARDAR SEPAMOS QUE ESTAMOS HACIENDO. SI ESTAMOS
                    //AGREGANDO UNA NUEVA PERSONA O SI ESTAMOS MODIFICANDO UNA.
                    EAccion = Accion.Modificar;
                }
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (mGrilla.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"¿Eliminar a {mGrilla.SelectedRows[0].Cells[2].Value} " +
                    $"{mGrilla.SelectedRows[0].Cells[3].Value}?",
                    "Eliminación",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //EL USUARIO CONFIRMO LA ELIMINACION Y SE PROCEDE A
                    //ELIMINAR EL DATAROW DEL DATASET QUE ESTA ENLAZADO A LA
                    //ROW SELECCIONADA DE LA GRILLA.
                    ((DataRowView)
                        mGrilla.SelectedRows[0]
                        .DataBoundItem)
                        .Row
                        .Delete();
                }
                else { MessageBox.Show("Cancelado"); }
            }
        }


        private void Deshacer_Click(object sender, EventArgs e)
        {
            //SE DESHACE EL CAMBIO PARA LA FILA SELECCIONADA
            ((DataRowView)mGrilla.SelectedRows[0].DataBoundItem).Row.RejectChanges();

            //SE DESHABILITA EL BOTON PARA DESHACER CAMBIOS EN ESE DATAROW
            btnDeshacer.Enabled = false;
        }


        //---------------------------------------------------------------------


        private void Grabar_Click(object sender, EventArgs e)
        {
            //SETEO DATAADAPTER CON COnsulta Y CONNECTIONSTRING         
            DATA_ADAPTER = new SqlDataAdapter(
                "SELECT Persona_id, Persona_nombre, Persona_apellido, Persona_direccion " +
                "FROM Persona; " +
                "SELECT MAX(persona_id) " +
                "FROM Persona;", CONEXION);

            //SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder Cb = new SqlCommandBuilder(DATA_ADAPTER);
            DATA_ADAPTER.UpdateCommand = Cb.GetUpdateCommand();
            DATA_ADAPTER.DeleteCommand = Cb.GetDeleteCommand();
            DATA_ADAPTER.InsertCommand = Cb.GetInsertCommand();
            DATA_ADAPTER.ContinueUpdateOnError = true;

            //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            DATA_ADAPTER.Update(DATA_SET.Tables[0]);
        }


        private void Descartar_Click(object sender, EventArgs e)
        {
            //SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET. SI ALGUN DATAROW
            //HABIA SIDO AGREGADO Y SE AUMENTO EL MAXIMO ID EN NUESTRA SEGUNDA
            //TABLA, TAMBIEN SE DESCARTAN ESOS CAMBIOS. POR ESO SE DESHACEN LOS
            //CAMBIOS DE TODO EL DATASET Y NO SOLO DE LA TABLA PERSONA.
            DATA_SET.RejectChanges();
        }


        private void Cargar_Click(object sender, EventArgs e)
        {
            DATA_SET.Tables[0].Rows.Clear();
            CargarGrilla();
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| OTROS


        public static bool IsNumeric(string valor) => int.TryParse(valor, out _);


        private void Grilla_Click(object sender, DataGridViewCellEventArgs e)
        {
            if ((mGrilla.SelectedRows.Count > 0))
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnDeshacer.Enabled = ((DataRowView)(mGrilla.SelectedRows[0].DataBoundItem)).Row.RowState != DataRowState.Unchanged;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }


    }
}
