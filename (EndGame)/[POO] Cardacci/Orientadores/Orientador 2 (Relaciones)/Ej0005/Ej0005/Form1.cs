using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ej0005
{
    public partial class Form1 : Form
    {
        public Alumno alumno;
        EventHandler<CambiaNombreEventArgs> evento = delegate (object o, CambiaNombreEventArgs e)
        {
            MessageBox.Show("Se produjo un cambio en el nombre, ahora es: " + e.Nombre + "\n\r" +
                            "El evento se desencadenó a las: " + e.HoraEvento);
        };

        public Form1()
        {
            InitializeComponent();
            alumno = new Alumno();
            alumno.CambiaNombre += evento;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            alumno.Nombre = Interaction.InputBox("Ingrese el Nombre:");
            alumno.CambiaNombre -= evento;
        }  
    }


    public class Alumno
    {
        public event EventHandler<CambiaNombreEventArgs> CambiaNombre;
        private string nombre = "";
        public string Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
                CambiaNombre?.Invoke(this, new CambiaNombreEventArgs(this.Nombre));
            }
        }
    }
    public class CambiaNombreEventArgs : EventArgs
    {
        private string vNombre = "";
        private string vHora = "";

        public CambiaNombreEventArgs(string pNombre)
        {
            this.vNombre = pNombre;
            this.vHora = DateTime.Now.ToShortTimeString();
        }

        public string Nombre { get { return this.vNombre; } }
        public string HoraEvento { get { return this.vHora; } }
    }
}

