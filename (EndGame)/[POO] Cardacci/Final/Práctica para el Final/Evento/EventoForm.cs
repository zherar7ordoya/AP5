using System;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Evento
{
    public partial class EventoForm : Form
    {
        Termostato termostato;

        public EventoForm() => InitializeComponent();
        private void EventoForm_Load(object sender, EventArgs e) => termostato = new Termostato();

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Suscripción
                termostato.TemperaturaPeligrosaEventHandler += TemperaturaAlta;

                /* Procedo normalmente actualizando la propiedad, y la
                 * propiedad, al evaluar, desencadena el método que yo aquí le
                 * puse a disposición (TemperaturaAlta) */
                termostato.Temperatura = int.Parse(Interaction.InputBox("Ingrese la temperatura"));

                // Desuscripción
                termostato.TemperaturaPeligrosaEventHandler -= TemperaturaAlta;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // El método al que hace referencia la suscripción
        private void TemperaturaAlta(object sender, EventArgs e) => MessageBox.Show("La temperatura supera los 100 grados");
    }
}
