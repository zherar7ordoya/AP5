using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Empleado : Form
    {
        // ************************************************************** CARGA

        BE.BE_Empleado BE_EMPLEADO;
        readonly BLL.BLL_Empleado BLL_EMPLEADO;

        public FRM_Empleado()
        {
            InitializeComponent();
            BE_EMPLEADO = new BE.BE_Empleado();
            BLL_EMPLEADO = new BLL.BLL_Empleado();
        }

        private void FRM_Empleado_Load(object sender, EventArgs e) => CargarDGV();

        // ********************************************************** CONTROLES

        private void EmpleadoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (EmpleadoDGV.CurrentRow != null)
                {
                    BE_EMPLEADO = (BE.BE_Empleado)EmpleadoDGV.CurrentRow.DataBoundItem;
                    LegajoTextBox.Text = BE_EMPLEADO.Legajo.ToString();
                    NombreTextBox.Text = BE_EMPLEADO.Nombre;
                    ApellidoTextBox.Text = BE_EMPLEADO.Apellido;
                    UsuarioTextBox.Text = BE_EMPLEADO.Usuario;
                    ContraseñaTextBox.Text = BE_EMPLEADO.Contraseña;
                    DepartamentoIDTextBox.Text = BE_EMPLEADO.DepartamentoID;
                    RolIDTextBox.Text = BE_EMPLEADO.RolID;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                BE_EMPLEADO.Instruccion = "Alta";

                DialogResult resultado = MessageBox.Show("¿Agregar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (BLL_EMPLEADO.Guardar(BE_EMPLEADO) == false)
                    {
                        MessageBox.Show("Ya existe el empleado");
                    }
                    LimpiarTextBoxes();
                    CargarDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void BajaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();

                DialogResult resultado = MessageBox.Show("¿Eliminar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    BLL_EMPLEADO.Eliminar(BE_EMPLEADO);
                    LimpiarTextBoxes();
                    CargarDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ModificacionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();

                DialogResult resultado = MessageBox.Show("¿Modificar?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    BLL_EMPLEADO.Guardar(BE_EMPLEADO);
                    LimpiarTextBoxes();
                    CargarDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ************************************************************ MÉTODOS

        private void CargarDGV()
        {
            try
            {
                EmpleadoDGV.DataSource = null;
                EmpleadoDGV.DataSource = BLL_EMPLEADO.ListarTodo();
                EmpleadoDGV.Columns["ID"].Visible = false;
                EmpleadoDGV.Columns["Instruccion"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void LimpiarTextBoxes()
        {
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox box) box.Text = string.Empty;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void Asignar()
        {
            try
            {
                BE_EMPLEADO.Legajo = Convert.ToInt32(LegajoTextBox.Text);
                BE_EMPLEADO.Nombre = NombreTextBox.Text;
                BE_EMPLEADO.Apellido = ApellidoTextBox.Text;
                BE_EMPLEADO.Usuario = UsuarioTextBox.Text;
                BE_EMPLEADO.Contraseña = ContraseñaTextBox.Text;
                BE_EMPLEADO.DepartamentoID = DepartamentoIDTextBox.Text;
                BE_EMPLEADO.RolID = RolIDTextBox.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //                    ▂▃▄▅▆▇█▓▒░ THE END ░▒▓█▇▆▅▄▃▂

    }
}
