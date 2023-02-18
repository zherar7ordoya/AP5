using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Delegados_02
{
    public delegate void MiDelegado();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona P = new Persona();
            
            P.Del1 += FuncionFormulario; //aca suscribo desde el form
            P.Del1();
            P.RecibirMetodo(FuncionParaPasarPorReferencia); //Puedo pasar un metodo por referencia a la clase
            P.Del1();
        }

        private void FuncionFormulario()
        {
            MessageBox.Show("Soy la funcion del formulario");
        }
        

        private void FuncionParaPasarPorReferencia()
        {
            MessageBox.Show("Esta funcion me llego del form por referencia");
        }
    }

    public class Persona
    {
        
        public MiDelegado Del1;
        
        public int Dni { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {
            Del1 += MuestraMensaje; //aca suscribo desde la clase
        }
        public Persona(int pDni, string pNombre)
        {
            Dni = pDni;
            Nombre = pNombre;
        }

        public void MuestraMensaje()
        {
            MessageBox.Show("Soy la clase");
        }
        public void Invoca()
        {
            Del1();
        }

        public void RecibirMetodo(MiDelegado pDel)
        {
            Del1 += pDel;
        }
    }
}
