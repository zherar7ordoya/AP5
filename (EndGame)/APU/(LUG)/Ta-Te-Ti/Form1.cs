using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado11 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      GenerarBotones();
    }

    Button[,] botones = new Button[3, 3];

    private void GenerarBotones() {
      for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
          botones[i, j] = new Button();
          botones[i, j].Size = new Size(150, 150);
          botones[i, j].Location = new Point(i * 150, j * 150);
          botones[i, j].FlatStyle = FlatStyle.Flat;
          botones[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);
          botones[i, j].Click += new EventHandler(button_Click);
          panel1.Controls.Add(botones[i, j]);
        }
      }
    }

    private void button_Click(object sender, EventArgs e) {
      Button boton = sender as Button;
      if (boton.Text != "") return;
      boton.Text = btnJugador.Text;
      CambiarJugador();
    }

    private void CambiarJugador() {
      VerificarFinalizado();
      if (btnJugador.Text == "X") {
        btnJugador.Text = "O";
      } else {
        btnJugador.Text = "X";
      }
    }

    private void VerificarFinalizado() {
      // Vertical.
      for (int i = 0; i < 3; i++) {
        List<Button> serieGanadoraV = new List<Button>();
        for (int j = 0; j < 3; j++) {
          if (botones[i, j].Text != btnJugador.Text) break;
          serieGanadoraV.Add(botones[i, j]);
          if ( j == 2) {
            MostrarGanador(serieGanadoraV);
            return;
          }
        }
      }
      // Horizontal.
      for (int i = 0; i < 3; i++) {
        List<Button> serieGanadoraH = new List<Button>();
        for (int j = 0; j < 3; j++) {
          if (botones[j, i].Text != btnJugador.Text) break;
          serieGanadoraH.Add(botones[j, i]);
          if (j == 2) {
            MostrarGanador(serieGanadoraH);
            return;
          }
        }
      }
      // Diagonal (descendente).
      List<Button> serieGanadoraDesc = new List<Button>();
      for (int i = 0, j = 0; i < 3; i++, j++) {
        if (botones[i, j].Text != btnJugador.Text) break;
        serieGanadoraDesc.Add(botones[i, j]);
        if (j == 2) {
          MostrarGanador(serieGanadoraDesc);
          return;
        }
      }
      // Diagonal (ascendente).
      List<Button> serieGanadoraAsc = new List<Button>();
      for (int i = 2, j = 0; j < 3; i--, j++) {
        if (botones[i, j].Text != btnJugador.Text) break;
        serieGanadoraAsc.Add(botones[i, j]);
        if (j == 2) {
          MostrarGanador(serieGanadoraAsc);
          return;
        }
      }
      // Empate.
      foreach (var boton in botones) {
        if (boton.Text == "") return;
      }
      MessageBox.Show("Empate");
      Application.Restart();
    }

    private void MostrarGanador(List<Button> serieGanadora) {
      foreach (var boton in serieGanadora) {
        boton.BackColor = Color.LightGreen;
      }
      MessageBox.Show("El jugador " + btnJugador.Text + " ha ganado esta partida.");
      Application.Restart();
    }

    private void Form1_Load(object sender, EventArgs e) {
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }
    
    
  }
}
