using System;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public partial class PiedraPapelTijera1JugadorForm : Form
    {
        BLL.Jugador JUGADOR;
        BE.Historial BE_HISTORIAL;
        BLL.Historial BLL_HISTORIAL;
        BLL.PiedraPapelTijera PPT;

        private int
            GanadasPorUsuario = 0,
            GanadasPorComputadora = 0,
            rondas = 3,
            segundos = 4,
            aleatorio;
        private string
            JugadaDeUsuario,
            comando;
        readonly Random semilla = new Random();
        readonly string[] JugadaDeComputadora =
        {
            "piedra",
            "papel",
            "tijera",
        };

        public PiedraPapelTijera1JugadorForm()
        {
            InitializeComponent();
            JUGADOR = new BLL.Jugador();
            BE_HISTORIAL= new BE.Historial();
            BLL_HISTORIAL= new BLL.Historial();
            PPT = new BLL.PiedraPapelTijera();
        }

        private void PiedraPapelTijera1JugadorForm_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            JugadaDeUsuario = "ninguna";
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private void PiedraButton_Click(object sender, EventArgs e)
        {
            JugadaDeUsuario = "piedra";
            IzquierdaPicturebox.Image = Properties.Resources.Piedra;
        }

        private void PapelButton_Click(object sender, EventArgs e)
        {
            JugadaDeUsuario = "papel";
            IzquierdaPicturebox.Image = Properties.Resources.Papel;
        }

        private void TijeraButton_Click(object sender, EventArgs e)
        {
            JugadaDeUsuario = "tijera";
            IzquierdaPicturebox.Image = Properties.Resources.Tijera;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            segundos--;
            SegundosLabel.Text = Convert.ToString(segundos);

            if (segundos < 1)
            {
                CronometroTimer.Enabled = false;
                segundos = 4;
                aleatorio = semilla.Next(0, 2);
                comando = JugadaDeComputadora[aleatorio];

                switch (comando)
                {
                    case "piedra":
                        DerechaPicturebox.Image = Properties.Resources.Piedra;
                        break;
                    case "papel":
                        DerechaPicturebox.Image = Properties.Resources.Papel;
                        break;
                    case "tijera":
                        DerechaPicturebox.Image = Properties.Resources.Tijera;
                        break;
                    default:
                        break;
                }
                if (rondas > 0) ComputarRonda();
                else { DeclararVictoria(); }
            }
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            rondas = 3;
            CronometroTimer.Enabled = true;
        }

        private void ComputarRonda()
        {
            if (JugadaDeUsuario == "piedra" && comando == "papel")
            {
                GanadorLabel.Text = "Ronda para Computadora";
                MessageBox.Show("Ronda para Computadora");
                GanadasPorComputadora++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaDeUsuario == "papel" && comando == "piedra")
            {
                GanadorLabel.Text = "Ronda para Usuario";
                MessageBox.Show("Ronda para Usuario");
                GanadasPorUsuario++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaDeUsuario == "papel" && comando == "tijera")
            {
                GanadorLabel.Text ="Ronda para Computadora";
                MessageBox.Show("Ronda para Computadora");
                GanadasPorComputadora++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaDeUsuario == "tijera" && comando == "papel")
            {
                GanadorLabel.Text = "Ronda para Usuario";
                MessageBox.Show("Ronda para Usuario");
                GanadasPorUsuario++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaDeUsuario == "tijera" && comando == "piedra")
            {
                GanadorLabel.Text = "Ronda para Computadora";
                MessageBox.Show("Ronda para Computadora");
                GanadasPorComputadora++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaDeUsuario == "piedra" && comando == "tijera")
            {
                GanadorLabel.Text = "Ronda para Usuario";
                MessageBox.Show("Ronda para Usuario");
                GanadasPorUsuario++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaDeUsuario == "ninguna")
            {
                GanadorLabel.Text = "Juegue";
                MessageBox.Show("Juegue");
                ProximaRonda();
            }
            else
            {
                GanadorLabel.Text = "Empate";
                MessageBox.Show("Empate");
                ProximaRonda();
            }
            if (rondas == 0) DeclararVictoria();
        }


        private void DeclararVictoria()
        {
            if (GanadasPorUsuario > GanadasPorComputadora)
            {
                GanadorLabel.Text = "Victoria para Usuario";
                MessageBox.Show("Victoria para " + JugadorCombobox.Text);

                BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
                BE_HISTORIAL.NombreJuego = "Piedra-Papel-Tijera";
                BE_HISTORIAL.Jugador = JugadorCombobox.Text;
                BE_HISTORIAL.Estado = "Ganados";
                BE_HISTORIAL.Puntos = PPT.CalcularPuntaje("gana");

                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
                BE_HISTORIAL.ArchivoXML = "JugadoresHistorialPPT.xml";
                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
            }
            else
            { 
                GanadorLabel.Text = "Victoria para Computadora";
                MessageBox.Show("Victoria para Computadora");

                BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
                BE_HISTORIAL.NombreJuego = "Piedra-Papel-Tijera";
                BE_HISTORIAL.Jugador = JugadorCombobox.Text;
                BE_HISTORIAL.Estado = "Perdidos";
                BE_HISTORIAL.Puntos = PPT.CalcularPuntaje("pierde");

                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
                BE_HISTORIAL.ArchivoXML = "JugadoresHistorialPPT.xml";
                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
            }
            CronometroTimer.Enabled = false;
        }


        private void ProximaRonda()
        {
            RondasLabel.Text = "Ronda " + Convert.ToString(rondas);
            JugadaDeUsuario = "ninguna";
            IzquierdaPicturebox.Image = Properties.Resources.Pregunta;
            CronometroTimer.Enabled = true;
            DerechaPicturebox.Image = Properties.Resources.Pregunta;
        }

        ///////////////////////////////////////////////////////////////////////

        private void CargarComboBox()
        {
            try
            {
                XmlNodeList jugadores = JUGADOR.ListarJugadores();
                
                foreach (XmlNode jugador in jugadores)
                {
                    JugadorCombobox.Items.Add(jugador.InnerText);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void JugadorCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CronometroTimer.Enabled = true;
        }

    }
}
