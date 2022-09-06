using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra_Papel_Tijera
{
    public partial class FormPPT : Form
    {
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

        public FormPPT() => InitializeComponent();

        private void FormPPT_Load(object sender, EventArgs e)
        {
            CronometroTimer.Enabled = true;
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
                MessageBox.Show("Victoria para Usuario");
            }
                
            else { 
                GanadorLabel.Text = "Victoria para Computadora";
                MessageBox.Show("Victoria para Computadora");
            }
        }


        private void ProximaRonda()
        {
            RondasLabel.Text = "Ronda " + Convert.ToString(rondas);
            JugadaDeUsuario = "ninguna";
            IzquierdaPicturebox.Image = Properties.Resources.Pregunta;
            CronometroTimer.Enabled = true;
            DerechaPicturebox.Image = Properties.Resources.Pregunta;
        }


    }
}
