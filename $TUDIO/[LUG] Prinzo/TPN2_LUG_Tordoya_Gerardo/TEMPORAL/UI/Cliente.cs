using System;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();

            //instancio los objetos en el constructor del formulario
            oBECli = new BE.BE_Cliente();
            oBELoc = new BE.Localidad();
            oBLLLoc = new BLL.Localidad();
            oBLLCli = new BLL.BLL_Cliente();
        }

        BE.BE_Cliente oBECli;
        BE.Localidad oBELoc;
        readonly BLL.Localidad oBLLLoc;
        readonly BLL.BLL_Cliente oBLLCli;


        private void FrmParametros_Load(object sender, EventArgs e)
        {
               cargargrillas();
               cargarcombo();
        }

        public void cargarcombo()
        {
            this.ComboBox1.DataSource = null;
            this.ComboBox1.DataSource = oBLLLoc.ListarTodo();
            this.ComboBox1.ValueMember = "Id";
            this.ComboBox1.DisplayMember = "Descripcion";
        }

        public void cargargrillas()
        {
            this.dgvclientes.DataSource = null;
            this.dgvclientes.DataSource = oBLLCli.ListarTodo();
        }

        private void dgvUsuariosTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {

                oBECli = (BE.BE_Cliente)dgvclientes.CurrentRow.DataBoundItem;
                this.TxtID.Text = oBECli.Id.ToString();
                this.txtNombre.Text = oBECli.Nombre;
                this.TxtApellido.Text = oBECli.Apellido;
                this.TxtDNI.Text = oBECli.DNI.ToString();
                this.ComboBox1.SelectedValue = oBECli.Localidad.Id;
                this.ComboBox1.Text = oBECli.Localidad.Descripcion;
            }
        }

        public void limpiar()
        {
            this.TxtID.Text = null;
            this.txtNombre.Text = null;
            this.TxtApellido.Text = null;
            this.TxtDNI.Text = null;
            this.dgvclientes.DataSource = null;
            cargargrillas();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                oBECli.Nombre = this.txtNombre.Text;
                oBECli.Apellido = this.TxtApellido.Text;
                oBECli.DNI = Convert.ToInt32(TxtDNI.Text);
                oBELoc = (BE.Localidad)ComboBox1.SelectedItem;
                oBECli.Localidad = oBELoc;

                if (oBLLCli.Guardar(oBECli) == false)
                { MessageBox.Show("Existe un cliente con el DNI ingresado"); }
                limpiar();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Asignar();
            oBLLCli.Guardar(oBECli);
            limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try { 
            Asignar();
            DialogResult Resultado;
            Resultado = MessageBox.Show("Desea eliminar el Usuario " + oBECli.Nombre + "", "Alerta!", MessageBoxButtons.YesNo);
            if (Resultado == DialogResult.Yes)
            {
                oBLLCli.Eliminar(oBECli);
                limpiar();
            }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void Asignar()
        {
            try
            {
                oBECli.Id = Convert.ToInt32(TxtID.Text);
                oBECli.Nombre = this.txtNombre.Text;
                oBECli.Apellido = this.TxtApellido.Text;
                oBECli.DNI = Convert.ToInt32(TxtDNI.Text);
                oBELoc = (BE.Localidad)ComboBox1.SelectedItem;
                oBECli.Localidad = oBELoc;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BOTÓN "BUSCAR"
            oBECli.Apellido = textBox1.Text;
            this.dgvclientes.DataSource = null;
            this.dgvclientes.DataSource = oBLLCli.BuscarClienteXApellido(oBECli);

        }
    }
}
