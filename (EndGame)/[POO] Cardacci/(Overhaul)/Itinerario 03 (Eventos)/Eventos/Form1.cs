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

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Termostato _t;
        private void Form1_Load(object sender, EventArgs e)
        {
           _t = new Termostato();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                _t.TemperaturaPeligrosa += TemperaturaAlta;
                int _ingreso = int.Parse(Interaction.InputBox("Ingrese la Temperaturas: "));
                _t.Temperatura = _ingreso;
                _t.TemperaturaPeligrosa -= TemperaturaAlta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void TemperaturaAlta(object sender, TemperaturaPeligrosaEventArgs e)
            {
                 MessageBox.Show($"La Temperatura Supera los 100 grados !!!{Environment.NewLine}La temperatura es: {e.DatoTemperatura} grados.");
            }
     }

    public class Termostato
    {
        public event EventHandler<TemperaturaPeligrosaEventArgs> TemperaturaPeligrosa;
        int _temperatura;
        public int Temperatura 
        { 
            get { return _temperatura; }
            set { _temperatura = value; if (value > 100) { TemperaturaPeligrosa?.Invoke(this, new TemperaturaPeligrosaEventArgs(value)); } } 
        
        }

    }

    public class TemperaturaPeligrosaEventArgs : EventArgs
    {
        int _temperatura;

        // Constructor
        public TemperaturaPeligrosaEventArgs(int pTemperatura)
        {
            _temperatura = pTemperatura;
        }

        public int DatoTemperatura { get { return _temperatura; } }

    }
}
