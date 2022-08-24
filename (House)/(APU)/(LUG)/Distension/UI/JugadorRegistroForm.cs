using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
    public partial class JugadorRegistroForm : Form
    {
        /* ----------------------------------------------------------------- *\
         * ARRANQUE                                                          *
        \* ----------------------------------------------------------------- */

        private BE.Jugador BE_JUGADOR;
        private BLL.Jugador BLL_JUGADOR;
        private List<BE.Jugador> JUGADORES;

        //

        public JugadorRegistroForm()
        {
            InitializeComponent();
            JUGADORES = new List<BE.Jugador>();
            BE_JUGADOR = new BE.Jugador();
            BLL_JUGADOR = new BLL.Jugador();
        }

        private void JugadorRegistroForm_Load(object sender, EventArgs e) => CargarJugadores();

        /* ----------------------------------------------------------------- *\
         * COMUNES                                                           *
        \* ----------------------------------------------------------------- */

        public void CargarJugadores()
        {
            try
            {
                JUGADORES = BLL_JUGADOR.RecopilarObjetos();

                CodigoTextbox.DataBindings.Clear();
                NombreTextbox.DataBindings.Clear();
                ApellidoTextbox.DataBindings.Clear();
                DniTextbox.DataBindings.Clear();
                EmailTextbox.DataBindings.Clear();
                NacimientoDTP.DataBindings.Clear();
                LocalidadTextbox.DataBindings.Clear();

                CodigoTextbox.DataBindings.Add("text", JUGADORES, "Codigo");
                NombreTextbox.DataBindings.Add("text", JUGADORES, "Nombre");
                ApellidoTextbox.DataBindings.Add("text", JUGADORES, "Apellido");
                DniTextbox.DataBindings.Add("text", JUGADORES, "DNI");
                EmailTextbox.DataBindings.Add("text", JUGADORES, "Email");
                NacimientoDTP.DataBindings.Add("text", JUGADORES, "FechaNacimiento");
                LocalidadTextbox.DataBindings.Add("text", JUGADORES, "LocalidadResidencia");

                JugadoresDGV.DataSource = JUGADORES;
                JugadoresDGV.Columns["Codigo"].DisplayIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        //

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in DetalleGroupbox.Controls)
                {
                    if (item is TextBox) (item as TextBox).Clear();
                    if (item is DateTimePicker) (item as DateTimePicker).Text = string.Empty;
                }
                JugadoresDGV.Enabled = false;
                ModificacionButton.Enabled = false;
                BajaButton.Enabled = false;
                AltaButton.Enabled = true;
                CancelarButton.Enabled = true;
                NombreTextbox.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        //

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            try
            {
                JugadoresDGV.Enabled = true;
                ModificacionButton.Enabled = true;
                BajaButton.Enabled = true;
                AltaButton.Enabled = false;
                CancelarButton.Enabled = false;

                CargarJugadores();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        //

        private void Asignar()
        {
            try
            {
                bool nombre = Regex.IsMatch(NombreTextbox.Text, "^([a-zA-Z]+$)");
                bool apellido = Regex.IsMatch(ApellidoTextbox.Text, "^([a-zA-Z]+$)");
                bool dni = Regex.IsMatch(DniTextbox.Text, "^([0-9]+$)");
                bool email = Regex.IsMatch(EmailTextbox.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");
                bool fecha = Regex.IsMatch(NacimientoDTP.Text, "^\\d{1,2}/\\d{1,2}/\\d{4}$");
                bool localidad = Regex.IsMatch(LocalidadTextbox.Text, "^[a-zA-Z0-9 ]+$");

                if (nombre && apellido && dni && email && fecha && localidad)
                {
                    if (CodigoTextbox.Text == string.Empty) BE_JUGADOR.Codigo = 0;
                    else { BE_JUGADOR.Codigo = Convert.ToInt32(CodigoTextbox.Text); }

                    BE_JUGADOR.Nombre = NombreTextbox.Text;
                    BE_JUGADOR.Apellido = ApellidoTextbox.Text;
                    BE_JUGADOR.DNI = Convert.ToInt32(DniTextbox.Text);
                    BE_JUGADOR.Email = EmailTextbox.Text;
                    BE_JUGADOR.FechaNacimiento = Convert.ToDateTime(NacimientoDTP.Text);
                    BE_JUGADOR.LocalidadResidencia = LocalidadTextbox.Text;
                }
                else { MessageBox.Show("Revise datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        /* ----------------------------------------------------------------- *\
         * ABM                                                               *
        \* ----------------------------------------------------------------- */

        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Agregar?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Asignar();
                    BLL_JUGADOR.Guardar(BE_JUGADOR);
                    CancelarButton_Click(this, null);
                    CargarJugadores();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        //

        private void BajaButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Remover?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Asignar();
                    BLL_JUGADOR.Remover(BE_JUGADOR);
                    CargarJugadores();
                }
            }
            catch (Exception ex)  { MessageBox.Show(ex.Message, "Error"); }
        }

        //

        private void ModificacionButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Editar?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Asignar();
                    BLL_JUGADOR.Guardar(BE_JUGADOR);
                    CargarJugadores();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        /* ----------------------------------------------------------------- *\
         * FINAL                                                             *
        \* ----------------------------------------------------------------- */

    }
}
