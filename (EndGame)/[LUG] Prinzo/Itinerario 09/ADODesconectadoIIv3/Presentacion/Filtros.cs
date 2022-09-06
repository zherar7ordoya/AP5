using System;
using System.Windows.Forms;
//libreria para que tome el Process
using System.Diagnostics;

namespace Presentacion
{
    public partial class Filtros : Form
    {
        public Filtros()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void Filtros_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link
            {
                LinkData = "https://www.csharp-examples.net/dataview-rowfilter/"
            };
            LinkLabel.Links.Add(link);
        }

        private void Filtros_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_Filtros = false;
        }
    }
}
