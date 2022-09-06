using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public partial class PiedraPapelTijera2JugadoresForm : Form
    {
        BLL.Jugador JUGADOR;
        BE.Historial BE_HISTORIAL;
        BLL.Historial BLL_HISTORIAL;
        BLL.PiedraPapelTijera PPT;

        private int
            GanadasPorIzquierda = 0,
            GanadasPorDerecha = 0,
            rondas = 3,
            segundos = 11;

        private string
            JugadaUsuarioIzquierda,
            JugadaUsuarioDerecha;

        //*********************************************************************

        public PiedraPapelTijera2JugadoresForm()
        {
            InitializeComponent();
            JUGADOR = new BLL.Jugador();
            BE_HISTORIAL = new BE.Historial();
            BLL_HISTORIAL = new BLL.Historial();
            PPT = new BLL.PiedraPapelTijera();
        }

        private void PiedraPapelTijera2JugadoresForm_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            try
            {
                XmlNodeList jugadores = JUGADOR.ListarJugadores();

                foreach (XmlNode jugador in jugadores)
                {
                    IzquierdaCombobox.Items.Add(jugador.InnerText);
                    DerechaCombobox.Items.Add(jugador.InnerText);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //*********************************************************************

        private void PiedraIzquierdaButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioIzquierda = "piedra";
            IzquierdaPicturebox.Image = Properties.Resources.Piedra;
        }
        private void PapelIzquierdaButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioIzquierda = "papel";
            IzquierdaPicturebox.Image = Properties.Resources.Papel;
        }
        private void TijeraIzquierdaButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioIzquierda = "tijera";
            IzquierdaPicturebox.Image = Properties.Resources.Tijera;
        }
        private void PiedraDerechaButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioDerecha = "piedra";
            DerechaPicturebox.Image = Properties.Resources.Piedra;
        }
        private void PapelDerechaButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioDerecha = "papel";
            DerechaPicturebox.Image = Properties.Resources.Papel;
        }
        private void TijeraDerechaButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioDerecha = "tijera";
            DerechaPicturebox.Image = Properties.Resources.Tijera;
        }

        //*********************************************************************

        private void CronometroTimer_Tick(object sender, EventArgs e)
        {
            segundos--;
            SegundosLabel.Text = Convert.ToString(segundos);

            if (segundos < 1)
            {
                CronometroTimer.Enabled = false;
                segundos = 11;
            }
            if (rondas > 0) ComputarRonda();
            else { DeclararVictoria(); }
        }

        //*********************************************************************

        private void ComputarRonda()
        {
            if (JugadaUsuarioIzquierda == "piedra" && JugadaUsuarioDerecha == "papel")
            {
                GanadorLabel.Text = "Ronda para " + DerechaCombobox.Text;
                MessageBox.Show("Ronda para " + DerechaCombobox.Text);
                GanadasPorDerecha++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaUsuarioIzquierda == "papel" && JugadaUsuarioDerecha == "piedra")
            {
                GanadorLabel.Text = "Ronda para " + IzquierdaCombobox.Text;
                MessageBox.Show("Ronda para " + IzquierdaCombobox.Text);
                GanadasPorIzquierda++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaUsuarioIzquierda == "papel" && JugadaUsuarioDerecha == "tijera")
            {
                GanadorLabel.Text = "Ronda para " + DerechaCombobox.Text;
                MessageBox.Show("Ronda para " + DerechaCombobox.Text);
                GanadasPorDerecha++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaUsuarioIzquierda == "tijera" && JugadaUsuarioDerecha == "papel")
            {
                GanadorLabel.Text = "Ronda para " + IzquierdaCombobox.Text;
                MessageBox.Show("Ronda para " + IzquierdaCombobox.Text);
                GanadasPorIzquierda++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaUsuarioIzquierda == "tijera" && JugadaUsuarioDerecha == "piedra")
            {
                GanadorLabel.Text = "Ronda para " + DerechaCombobox.Text;
                MessageBox.Show("Ronda para " + DerechaCombobox.Text);
                GanadasPorDerecha++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaUsuarioIzquierda == "piedra" && JugadaUsuarioDerecha == "tijera")
            {
                GanadorLabel.Text = "Ronda para " + IzquierdaCombobox.Text;
                MessageBox.Show("Ronda para " + IzquierdaCombobox.Text);
                GanadasPorIzquierda++;
                rondas--;
                ProximaRonda();
            }
            else if (JugadaUsuarioIzquierda == "ninguna")
            {
                GanadorLabel.Text = "Juegue";
                MessageBox.Show("Juegue");
                ProximaRonda();
            }
            else if (JugadaUsuarioDerecha == "ninguna")
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

        private void ProximaRonda()
        {
            RondasLabel.Text = "Ronda " + Convert.ToString(rondas);
            JugadaUsuarioIzquierda = "ninguna";
            JugadaUsuarioDerecha = "ninguna";
            IzquierdaPicturebox.Image = Properties.Resources.Pregunta;
            DerechaPicturebox.Image = Properties.Resources.Pregunta;
            CronometroTimer.Enabled = true;
        }

        private void DeclararVictoria()
        {
            if (GanadasPorIzquierda > GanadasPorDerecha)
            {
                GanadorLabel.Text = "Victoria para " + IzquierdaCombobox.Text;
                MessageBox.Show("Victoria para " + IzquierdaCombobox.Text);

                BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
                BE_HISTORIAL.NombreJuego = "Piedra-Papel-Tijera";
                BE_HISTORIAL.Jugador = IzquierdaCombobox.Text;
                BE_HISTORIAL.Estado = "Ganados";
                BE_HISTORIAL.Puntos = PPT.CalcularPuntaje("gana");

                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

                BE_HISTORIAL.ArchivoXML = "JugadoresHistorialPPT.xml";
                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

                BE_HISTORIAL.Jugador = DerechaCombobox.Text;
                BE_HISTORIAL.Estado = "Perdidos";
                BE_HISTORIAL.Puntos = PPT.CalcularPuntaje("pierde");
                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
            }
            else
            {
                GanadorLabel.Text = "Victoria para " + DerechaCombobox.Text;
                MessageBox.Show("Victoria para " + DerechaCombobox.Text);

                BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
                BE_HISTORIAL.NombreJuego = "Piedra-Papel-Tijera";
                BE_HISTORIAL.Jugador = DerechaCombobox.Text;
                BE_HISTORIAL.Estado = "Ganados";
                BE_HISTORIAL.Puntos = PPT.CalcularPuntaje("gana");

                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

                BE_HISTORIAL.ArchivoXML = "JugadoresHistorialPPT.xml";
                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

                BE_HISTORIAL.Jugador = IzquierdaCombobox.Text;
                BE_HISTORIAL.Estado = "Perdidos";
                BE_HISTORIAL.Puntos = PPT.CalcularPuntaje("pierde");
                BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
            }
            CronometroTimer.Enabled = false;
        }

        //*********************************************************************

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            JugadaUsuarioIzquierda = "ninguna";
            JugadaUsuarioDerecha = "ninguna";
            rondas = 3;
            CronometroTimer.Enabled = true;
        }

    }
}
