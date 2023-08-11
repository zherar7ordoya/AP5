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

// Evento personalizado que se dispara cuando se carga alguien mayor a 65 años.

namespace EventoPersonalizado
{
    public partial class EventoForm : Form
    {
        public EventoForm() => InitializeComponent();

        Persona _persona = new Persona();

        private void Formulario_Load(object sender, EventArgs e)
        {
            _persona.MenorDeEdad += FuncionParaEventoComun;
            _persona.MayorDeEdad += new EventHandler<MayordeEdadEventArgs>(this.FuncionParaEventoPersonalizado);
        }

        private void FuncionParaEventoComun(object sender, EventArgs e)
        {
            MessageBox.Show("La persona es menor de 65 años");
        }

        private void FuncionParaEventoPersonalizado(object sender, MayordeEdadEventArgs e)
        {
            MessageBox.Show($"La persona tiene {e.Edad} años");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            _persona.Nombre = Interaction.InputBox("Nombre");
            _persona.Edad = Convert.ToInt32(Interaction.InputBox("Edad"));
            // _persona.EvaluarEdad();
        }
    }

    public class Persona
    {
        //DEFINO EL EVENTO EN LA CLASE
        public event EventHandler<MayordeEdadEventArgs> MayorDeEdad;
        public event EventHandler MenorDeEdad;

        private int _edad;

        public string Nombre { get; set; }

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value > 65)
                {
                    MayorDeEdad?.Invoke(this, new MayordeEdadEventArgs(value));
                }
                else
                {
                    MenorDeEdad?.Invoke(this, null);
                }
                _edad = value;
            }
        }

        //Tambien puedo invocarlo desde un metodo
        public void EvaluarEdad()
        {
            if (_edad > 65) MayorDeEdad?.Invoke(this, new MayordeEdadEventArgs(_edad));
            else MenorDeEdad?.Invoke(this, null);
        }
    }

    public class MayordeEdadEventArgs : EventArgs
    {

        public int Edad { get; set; }

        public MayordeEdadEventArgs(int edad)
        {
            Edad = edad;
        }
    }


}
