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

namespace _04_Evento_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///Vamos a hacer un evento personalizado que se dispare cuando se cargue una persona mayor a 65
        ///

        
        Persona P = new Persona();
        private void Form1_Load(object sender, EventArgs e)
        {
           //Suscribo al evento
            P.MayordeEdad += new EventHandler<MayordeEdadEventArgs>(this.funcionEvento);
            P.EventoComun += FuncionEventoComun;
            P.EventoComun += OtraFuncion;
        }

        private void OtraFuncion(object sender, EventArgs e)
        {
            MessageBox.Show("Segunda funcion del Evento Comun");
            P.EventoComun -= OtraFuncion; //solo lo ejecuto una vez y desuscribo
        }

        private void FuncionEventoComun(object sender, EventArgs e)
        {
            MessageBox.Show("Este es el evento comun");
        }

        private void funcionEvento(object sender, MayordeEdadEventArgs e)
        {
            MessageBox.Show("Cargó un viejo de " + e.Edad + " Anos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P.Nombre = Interaction.InputBox("Nombre");
            P.Edad = Convert.ToInt32(Interaction.InputBox("Edad"));
            P.verificarEdad();
        }
    }

    public class Persona
    {
        //DEFINO EL EVENTO EN LA CLASE

        public event EventHandler<MayordeEdadEventArgs> MayordeEdad;

        //Evento NO PERSONALIZADO

        public event EventHandler EventoComun;

        private int _Edad;

        public string Nombre { get; set; }
        public int Edad
        {
            get { return _Edad; }
            set
            {
                //INVOCO EL EVENTO en el SETTER
                //if (value > 65)
                //{
                //    MayordeEdad?.Invoke(this, new MayordeEdadEventArgs(value));
                //}
                _Edad = value;

            }
        }

        //Tambien puedo invocarlo desde un metodo
        //Osea lo invoco de donde se me canta


        public void verificarEdad()
        {
            if (_Edad > 65)
            {
                MayordeEdad?.Invoke(this, new MayordeEdadEventArgs(_Edad));
                EventoComun?.Invoke(this, null); //Le paso null
            }
        }
    }

    public class MayordeEdadEventArgs : EventArgs
    {

        public int Edad { get; set; }

        public MayordeEdadEventArgs(int pEdad)
        {

            Edad = pEdad;
        }
    }

    
}
