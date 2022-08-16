using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Espacio de nombres con clases para el manejo de expresiones regulares en .NET
using System.Text.RegularExpressions;

namespace Regex_C
{
    public partial class RegEx1 : Form
    {
        public RegEx1()
        {
            InitializeComponent();
        }

        private void RegEx1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNumeros_Click(object sender, EventArgs e)
        {
            string Numeros = TextNumeros.Text;

            bool respuesta = Regex.IsMatch(Numeros, "^([0-9]+$)");
            if (respuesta == false)
            {
                MessageBox.Show("No escribio un Número", "ERROR");
            }
            else
            {
                MessageBox.Show("Escribio un Número", "VALIDACION OK");

            }

        }

        private void BtnValTexto_Click(object sender, EventArgs e)
        {
            string Texto = TextTexto.Text;

            if (Texto.Length > 0)
            {
                bool respuesta = false;
                respuesta = Regex.IsMatch(Texto, "^([a-zA-Z]+$)");
                if (respuesta == false)
                {  MessageBox.Show("Escribio caracteres Especiales o Numericos", "ERROR"); }
                else
                { MessageBox.Show("Escribio Texto", "Validacion OK"); }
            }
            else
            { MessageBox.Show("Ingrese un texo ");  }
        }

        private void BtnAlfa_Click(object sender, EventArgs e)
        {

            string texto = TextAlfaNum.Text;

            bool respuesta = Regex.IsMatch(texto, "^([a-zA-Z0-9]+$)");
            if (respuesta == false)
            {
                MessageBox.Show("Escribio un caracter Especial", "ERROR");
            }
            else
            {
                MessageBox.Show("Escribio un Texto AlfaNumerico", "VALIDACION OK");

            }

          
        }

        private void BtnMail_Click(object sender, EventArgs e)
        {
            string Mail = null;

            Mail = this.TextMail.Text;

            if (Mail.Length > 0)
            {
                bool respuesta = false;
                //depende el lenguaje se puede usar \ o \\ barras

                //la barra inversa no se utiliza nunca por sí sola, sino en combinación con otros caracteres.
                //Al utilizarlo por ejemplo en combinación con el punto "\." este deja de tener su significado normal y se comporta como un carácter literal.
                //depende el lenguaje se utiliza \\ o \ en c# se toma como caracter de escape segun la combinacion y se utiliza \\
                // en \\w- , es que puede haber caracteres alfanumericos separados por guion
                respuesta = Regex.IsMatch(Mail, "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");
                if (respuesta == true)
                {
                    MessageBox.Show("Escribio el mail correctamete","VALIDACION OK");
                }
                else
                {
                    MessageBox.Show("Escriba el mail correctamente", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un correo");
            }


        }

        private void Btnfecha_Click(object sender, EventArgs e)
        {
            string Fecha = this.TextFecha.Text;

            if (Fecha.Length > 0)
            {
               // /^ (0[1 - 9] |[12][0 - 9] | 3[01])[\- \/.](?:(0[1 - 9] | 1[012])[\- \/.](19 | 20)[0 - 9]{ 2})$/)
                bool respuesta = Regex.IsMatch(Fecha, "^([0][1-9]|[12][0-9]|3[01])(\\/|-)([0][1-9]|[1][0-2])\\2(\\d{4})$");
                if (respuesta == true)
                {
                    MessageBox.Show("Escribio la fecha correctamete", "VALIDACION OK");
                }
                else
                {
                    MessageBox.Show("Escriba la fecha correctamente", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una Fecha");

            }

        }
    }
}
