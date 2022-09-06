using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Herencia_y_varios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IComparer<Usuario> NomDesc = new Usuario.NombreDesc();
        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario User = new UserPremiun();
            User.SoyMayor += new EventHandler<SoyMayorEventArgs>( Metodo1);
            User.SoyMenor += Metodo2;
            User.Id = 124;
            User.Edad = 24;
            User.Nombre = "Juan";

            foreach(string s in User)
            {
                MessageBox.Show(s);
            }

            List<Usuario> LU = new List<Usuario>();

            LU.Add(User);
            LU.Add(new UserPremiun(12, "Ramon"));

            LU.Sort(NomDesc);
            Grilla1.DataSource = null;
            Grilla1.DataSource = LU;

        }

        private void Metodo1(object sender, SoyMayorEventArgs e)
        {
            MessageBox.Show("Soy Mayor");
        }
        private void Metodo2(object sender,EventArgs e)
        {
            MessageBox.Show("Soy Menor");
        }
    }

    
}
