using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Delegado
{
    public partial class DelegadoForm : Form
    {
        public Alumno _alumno;

        public DelegadoForm() => InitializeComponent();

        private void DelegadoForm_Load(object sender, EventArgs e)
        {
            _alumno = new Alumno();

            // Suscripción al Evento          
            _alumno.CambiaNombreEventHandler += delegate (object objeto, CambiaNombreEventArgs evento)
             {
                 MessageBox.Show(
                     $"Ahora es: { evento.Nombre}\nHora del evento: {evento.Hora}",
                     "Nombre cambiado");
             };
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _alumno.Nombre = Interaction.InputBox("Ingrese el nombre");
        }
    }

    // ************************************************************************

    public class Alumno
    {
        public event EventHandler<CambiaNombreEventArgs> CambiaNombreEventHandler;
        private string _nombre = "";
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                CambiaNombreEventHandler?.Invoke(this, new CambiaNombreEventArgs(Nombre));
            }
        }
    }

    // ************************************************************************

    public class CambiaNombreEventArgs : EventArgs
    {
        private string _nombre = "";
        private string _hora = "";

        public CambiaNombreEventArgs(string nombre)
        {
            _nombre = nombre;
            _hora = DateTime.Now.ToShortTimeString();
        }
        public string Nombre { get { return _nombre; } }
        public string Hora { get { return _hora; } }
    }
}
