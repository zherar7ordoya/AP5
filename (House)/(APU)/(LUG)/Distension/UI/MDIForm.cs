using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ABMJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JugadorRegistroForm formulario = new JugadorRegistroForm { MdiParent = this };
            formulario.Show();
        }
        private void PPP1JugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PiedraPapelTijera1JugadorForm formulario = new PiedraPapelTijera1JugadorForm { MdiParent = this };
            formulario.Show();
        }
        private void PPP2JugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PiedraPapelTijera2JugadoresForm formulario = new PiedraPapelTijera2JugadoresForm { MdiParent = this };
            formulario.Show();
        }
        private void TTT1JugadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaTeTi1JugadorForm formulario = new TaTeTi1JugadorForm { MdiParent = this };
            formulario.Show();
        }
        private void TTT2JugadoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TaTeTi2JugadoresForm formulario = new TaTeTi2JugadoresForm { MdiParent = this };
            formulario.Show();
        }
        private void HistorialJMJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialJuegosForm formulario = new HistorialJuegosForm { MdiParent = this };
            formulario.Show();
        }
        private void HistorialPPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialJugadoresPPTForm formulario = new HistorialJugadoresPPTForm { MdiParent = this };
            formulario.Show();
        }
        private void HistorialTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialJugadoresTTTForm formulario = new HistorialJugadoresTTTForm { MdiParent = this };
            formulario.Show();
        }
        private void DiagramaDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiagramaForm formulario = new DiagramaForm { MdiParent = this };
            formulario.Show();
        }
    }
}
