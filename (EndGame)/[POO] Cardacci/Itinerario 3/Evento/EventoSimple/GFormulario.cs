using System;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace EventoSimple
{
    public partial class GerardoForm : Form
    {
        Termostato _t;

        public GerardoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _t = new Termostato();

        }

        // *----------------

        private void IngresarTemperatura(object sender, EventArgs e)
        {
            try
            {
                // Suscripción
                _t.TemperaturaPeligrosa += TemperaturaAlta;

                int _ingreso = int.Parse(Interaction.InputBox("Ingrese la temperatura"));
                _t.Temperatura = _ingreso;

                // Desuscripción
                _t.TemperaturaPeligrosa -= TemperaturaAlta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // El método al que hace referencia la suscripción
        private void TemperaturaAlta(object sender, EventArgs e)
        {
            MessageBox.Show($"La temperatura supera los 100 grados");
        }
    }

    // *---------------

    public class Termostato
    {
        // Declaración
        public event EventHandler TemperaturaPeligrosa;
        int _temperatura;

        public int Temperatura
        {
            get { return _temperatura; }

            set
            {
                _temperatura = value;

                // Desencadenamiento
                if (value > 100)
                {
                    TemperaturaPeligrosa?.Invoke(this, null);
                }
            }
        }
    }
}
