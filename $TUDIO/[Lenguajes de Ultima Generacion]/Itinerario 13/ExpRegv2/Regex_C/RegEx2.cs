using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex_C
{
    public partial class RegEx2 : Form
    {
        public RegEx2()
        {
            InitializeComponent();
        }

        private void RegEx2_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        public void CargarLista()
        {
            //PARA PODER ASIGNAR UN VALOR AL TEXTO A MOSTRAR EN CADA ITEM DEL COMBO Y OTRO VALOR AL "VALUE" O VALOR REAL DE CADA ITEM, SE PUEDE EFECTUAR
            //UN ENLACE DE DATOS A UNA COLECCION DE OBJETOS CON ESTOS DOS ATRIBUTOS  ( cual contiene el texto a mostrar y cual el valor)
            //(VER LA DEFINICION DE LA CLASE LISTITEM MAS ABAJO)
            List<ListaItems> LItems = new List<ListaItems>();
            LItems.Add(new ListaItems("", "Seleccionar expresión regular"));
            LItems.Add(new ListaItems("(bin laden|Bin Laden|bomba|Bomba|atentado|Atentado)", "Ocurrencia de alguna de ciertas palabras"));
            LItems.Add(new ListaItems("^[a-zA-Z0-9]+$", "Solo caracteres alfanuméricos"));
            LItems.Add(new ListaItems("\\d{1,2}[/-]\\d{1,2}[/-]\\d{4}", "Fecha válida en formato DD/MM/AAAA (validación básica)"));
            LItems.Add(new ListaItems("^[A-Z]{3}[0-9]{3}$", "Patente de automóvil hasta 03/2016 XXX y 3 nro"));
            LItems.Add(new ListaItems("^[A-Z]{2}[0-9]{3}[A-Z]{2}$", "Patente de automóvil desde 04/2016 XX, 3 nros y XX"));
            LItems.Add(new ListaItems("#[0-9A-Fa-f][0-9A-Fa-f][0-9A-Fa-f][0-9A-Fa-f][0-9A-Fa-f][0-9A-Fa-f]", "Color expresado en hexadecimal"));
            LItems.Add(new ListaItems("^\\w+[\\w.]*@[\\w.]+\\.[a-zA-Z]{3}(\\.[a-zA-Z]{2,3})?$", "Email válido"));
            LItems.Add(new ListaItems("https?://[\\w./]+", "URL válida"));
            LItems.Add(new ListaItems("", "Personalizada"));

            this.cmbRegex.DisplayMember = "Text";
            this.cmbRegex.ValueMember = "Value";
            this.cmbRegex.DataSource = LItems;
        }

  
        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
            // utilizo la clase match que me valida el texto para valida, con el patron de la exprsion regular y utilizo el constructor
            //con la opción RegexOptions, Singleline para validar en una sola linea
            MessageBox.Show(((Regex.Match(this.txtTexto.Text, this.txtPatron.Text,RegexOptions.Singleline).Success ? "Correcto!!!" : "Error")), "Resultado");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //INSTANCIAMOS NUESTRA CLASE REGEX.
            //SE PODRIA HABER UTILIZADO TAMBIEN EL METODO COMPARTIDO MATCHES Y SE HUBIESE EVITADO ESTA INSTANCIA

            {
                Regex mRegEx = new Regex(this.txtPatron.Text);

                //PREPARAMOS LA COLECCION DE RESULTADOS POSITIVOS (MATCH COLLECTION)
                MatchCollection mMCol; // = default(MatchCollection);

                //RECUPERAMOS LOS RESULTADOS POSITIVOS DE LA EVALUACION MEDIANTE EL METODO DE INSTANCIA MATCHES DEL OBJETO REGEX
                mMCol = mRegEx.Matches(this.txtTexto.Text);

                //SI HAY EL MENOS UNO, SIGNIFICA QUE TUVIMOS AL MENOS UN EXITO EN NUESTRA EVALUACION
                //SINO, LA EVALUACION FRACASO
                if (mMCol.Count > 0)
                {
                    MessageBox.Show("La evaluación ha tenido éxito!!!");
                }
                else
                {
                    MessageBox.Show("No hubo coincidencias");
                }

                //MOSTRAMOS TODOS LOS RESULTADOS EXITOSOS (MATCH) DE LA COLECCION (MATCH COLLECTION)
                this.txtResultados.Text = "";
                int x = 1;
                foreach (Match mM in mMCol)
                {
                    this.txtResultados.Text += "Coincidencia " + x + ")    " + mM.Value + "\r\n";
                    x += 1;
                }

            }


        }

        private void cmbRegex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListaItems)this.cmbRegex.SelectedItem).Text == "Personalizada")
            {
                this.txtPatron.ReadOnly = false;
            }
            else
            {
                this.txtPatron.ReadOnly = true;
                this.txtPatron.Text = this.cmbRegex.SelectedValue.ToString();
            }
        }
    }
}
