using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public partial class TaTeTi2JugadoresForm : Form
    {
        BLL.Jugador JUGADOR;
        BE.Historial BE_HISTORIAL;
        BLL.Historial BLL_HISTORIAL;
        BLL.TaTeTi TTT;


        public TaTeTi2JugadoresForm()
        {
            InitializeComponent();
            GenerarBotones();

            JUGADOR = new BLL.Jugador();
            BE_HISTORIAL = new BE.Historial();
            BLL_HISTORIAL = new BLL.Historial();
            TTT = new BLL.TaTeTi();
        }

        Button[,] botones = new Button[3, 3];

        private void GenerarBotones()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    botones[i, j] = new Button
                    {
                        Size = new Size(150, 150),
                        Location = new Point(i * 150, j * 150),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(DefaultFont.FontFamily, 80, FontStyle.Bold)
                    };
                    botones[i, j].Click += new EventHandler(JugarButton_Click);
                    TableroPanel.Controls.Add(botones[i, j]);
                }
            }
        }

        private void JugarButton_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton.Text != "") return;
            boton.Text = JugarButton.Text;
            CambiarJugador();
        }

        private void CambiarJugador()
        {
            VerificarFinalizado();
            if (JugarButton.Text == "X")
            {
                JugarButton.Text = "O";
            }
            else
            {
                JugarButton.Text = "X";
            }
        }

        private void VerificarFinalizado()
        {
            // Vertical.
            for (int i = 0; i < 3; i++)
            {
                List<Button> serieGanadoraV = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (botones[i, j].Text != JugarButton.Text) break;
                    serieGanadoraV.Add(botones[i, j]);
                    if (j == 2)
                    {
                        MostrarGanador(serieGanadoraV);
                        return;
                    }
                }
            }
            // Horizontal.
            for (int i = 0; i < 3; i++)
            {
                List<Button> serieGanadoraH = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (botones[j, i].Text != JugarButton.Text) break;
                    serieGanadoraH.Add(botones[j, i]);
                    if (j == 2)
                    {
                        MostrarGanador(serieGanadoraH);
                        return;
                    }
                }
            }
            // Diagonal (descendente).
            List<Button> serieGanadoraDesc = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (botones[i, j].Text != JugarButton.Text) break;
                serieGanadoraDesc.Add(botones[i, j]);
                if (j == 2)
                {
                    MostrarGanador(serieGanadoraDesc);
                    return;
                }
            }
            // Diagonal (ascendente).
            List<Button> serieGanadoraAsc = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (botones[i, j].Text != JugarButton.Text) break;
                serieGanadoraAsc.Add(botones[i, j]);
                if (j == 2)
                {
                    MostrarGanador(serieGanadoraAsc);
                    return;
                }
            }
            // Empate.
            foreach (var boton in botones)
            {
                if (boton.Text == "") return;
            }
            MessageBox.Show("Empate");

            // Ingresar propiedades para actualizar juegos y jugadores.
            BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
            BE_HISTORIAL.NombreJuego = "Ta-Te-Ti";
            BE_HISTORIAL.Jugador = XCombobox.Text;
            BE_HISTORIAL.Estado = "Empatados";
            BE_HISTORIAL.Puntos = TTT.CalcularPuntaje("empata");

            // Registrar juegos jugados.
            BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

            // Actualizar propiedades y registrar jugador X
            BE_HISTORIAL.ArchivoXML = "JugadoresHistorialTTT.xml";
            BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

            // Actualizar propiedades y registrar jugador O
            BE_HISTORIAL.Jugador = XCombobox.Text;
            BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
        }

        private void MostrarGanador(List<Button> serieGanadora)
        {
            foreach (var boton in serieGanadora)
            {
                boton.BackColor = Color.LightGreen;
            }
            MessageBox.Show("El jugador " + JugarButton.Text + " ha ganado esta partida.");

            // Ingresar propiedades para actualizar juegos y jugadores.
            BE_HISTORIAL.ArchivoXML = "JuegosHistorial.xml";
            BE_HISTORIAL.NombreJuego = "Ta-Te-Ti";
            if (JugarButton.Text == "X") BE_HISTORIAL.Jugador = XCombobox.Text;
            if (JugarButton.Text == "O") BE_HISTORIAL.Jugador = OCombobox.Text;
            BE_HISTORIAL.Estado = "Ganados";
            BE_HISTORIAL.Puntos = TTT.CalcularPuntaje("gana");

            // Registrar juegos jugados.
            BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

            // Actualizar propiedades y registrar ganador.
            BE_HISTORIAL.ArchivoXML = "JugadoresHistorialTTT.xml";
            BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);

            // Actualizar propiedades y registrar perdedor.
            if (JugarButton.Text == "X") BE_HISTORIAL.Jugador = OCombobox.Text;
            if (JugarButton.Text == "O") BE_HISTORIAL.Jugador = XCombobox.Text;
            BE_HISTORIAL.Estado = "Perdidos";
            BE_HISTORIAL.Puntos = TTT.CalcularPuntaje("pierde");
            BLL_HISTORIAL.ActualizarHistorial(BE_HISTORIAL);
        }

        private void TaTeTi2JugadoresForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            CargarComboBox();
        }


        private void CargarComboBox()
        {
            try
            {
                XmlNodeList jugadores = JUGADOR.ListarJugadores();

                foreach (XmlNode jugador in jugadores)
                {
                    OCombobox.Items.Add(jugador.InnerText);
                    XCombobox.Items.Add(jugador.InnerText);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void IniciarJuegoButton_Click(object sender, EventArgs e)
        {
            foreach (var item in TableroPanel.Controls)
            {
                if (item is Button)
                {
                    (item as Button).Text = string.Empty;
                    (item as Button).BackColor = Color.Empty;
                }
            }
        }
    }
}
