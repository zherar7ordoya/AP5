using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace UI_XML
{
    public partial class LecturaEscrituraXMLSimple : Form
    {
        public LecturaEscrituraXMLSimple()
        {
            InitializeComponent();
        }

        private void LecturaEscrituraXMLSimple_Load(object sender, EventArgs e)
        { SetearGrilla(); }


        public void SetearGrilla()
        {
            //SETEO DE LA GRILLA

            this.grdPersonas.AllowDrop = true;
            this.grdPersonas.AllowUserToAddRows = true;
            this.grdPersonas.AllowUserToDeleteRows = false;
            this.grdPersonas.AllowUserToOrderColumns = true;
            this.grdPersonas.AllowUserToResizeColumns = false;
            this.grdPersonas.AllowUserToResizeRows = false;
            this.grdPersonas.RowHeadersVisible = false;

            var _with1 = this.grdPersonas.Columns;
            _with1.Add("cNombre", "Nombre");
            _with1.Add("cApellido", "Apellido");
            _with1.Add("cSaldo", "Saldo");

            //INTRODUCCION DE DATOS
            this.grdPersonas.Rows.Add("José", "Fernandez", "1200");
            this.grdPersonas.Rows.Add("Matrín", "Rodriguez", "2500");
            this.grdPersonas.Rows.Add("Pedro", "Perez", "1850");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            XmlTextWriter mXMLTW = new XmlTextWriter("Personas.xml", System.Text.Encoding.UTF8);

            //FORMATO DEL RESULTADO (EN ESTE CASO INDICAMOS QUE SE TABULEN LOS ELEMENTOS ANIDADOS)
            mXMLTW.Formatting = Formatting.Indented;

            //TAMAÑO DE LA TABULACION
            mXMLTW.Indentation = 4;

            //INDICA EL CARACTER QUE SE USARA PARA DELIMITAR VALORES DE ATRIBUTOS
            //EJ: <persona nombre="Juan">
            //EL '\'' EQUIVALEN A UNA COMILLA ENCERRADA ENTRE COMILLAS,
            //ES DECIR, SE ESTABLECE LA COMILLA COMO DELIMITADOR DEL VALOR
            mXMLTW.QuoteChar = '\'';

            //CREA EL INICIO DEL DOCUMENTO
            //EL ATRIBUTO TRUE INDICA SI EL ENCABEZADO INDICARA QUE EL 
            //DOCUMENTO XML ES "STADALONE", ES DECIR, SI NO DEPENDE DE
            //OTRO DOCUMENTO EXTERNO (COMO UN DOCUMENTO DE ESQUEMAS XML)
            mXMLTW.WriteStartDocument(true);

            //CREAMOS UN COMENTARIO PARA SABER COMO SE CREO EL CONTENIDO XML
            mXMLTW.WriteComment("CONTENIDO CREADO CON XMLTEXTWRITER EL " + DateTime.Now);

            //SE CREA LA APERTURA DEL ELEMENTO RAIZ (UNICO EN EL DOCUMENTO)
            mXMLTW.WriteStartElement("personas");

            //PARA CADA FILA DE LA GRILLA:

            foreach (DataGridViewRow Fila in this.grdPersonas.Rows)
            {
                //SI LA FILA ESTA VACIA SE SALTEA.
                //ESTO LO HACEMOS EN ESTE EJEMPLO PORQUE EL DATAGRIDVIEW DE .NET
                //AGREGA SIEMPRE UNA FILA VACIA SI SE PERMITE LA EDICION 
                //DIRECTA DEL USUARIO (CON EL ATRIBUTO ALLOWUSERTOADDROWS QUE SETEAMOS COMO TRUE)

                //  if (!(string.IsNullOrEmpty(Fila.Cells[0].Value.ToString()) & string.IsNullOrEmpty(Fila.Cells[1].Value.ToString()) & string.IsNullOrEmpty(Fila.Cells[2].Value.ToString())))
                if (!((Fila.Cells[0].Value == null) && ((Fila.Cells[1].Value == null) && (Fila.Cells[2].Value == null))))
                {
                    //SE ABRE UN ELEMENTO PERSONA
                    mXMLTW.WriteStartElement("persona");

                    //SE ESTABLECEN EL NOMBRE Y EL APELLIDO COMO ATRIBUTOS (ESTO ES ARBITRARIO,
                    //PODRIAN HABER SIDO ELEMENTOS ANIDADOS)
                    mXMLTW.WriteAttributeString("nombre", Fila.Cells[0].Value.ToString());
                    mXMLTW.WriteAttributeString("apellido", Fila.Cells[1].Value.ToString());

                    //SE ESCRIBE EL SALDO COMO ELEMENTO ANIDADO
                    mXMLTW.WriteElementString("saldo", Fila.Cells[2].Value.ToString());

                    //SE CIERRA EL ELEMENTO PERSONA
                    //ESTE METODO CIERRA CUALQUIER ELEMENTO PENDIENTE DE CIERRE
                    mXMLTW.WriteEndElement();
                }
            }
            //SE CIERRA EL DOCUMENTO Y CUALQUIER ELEMENTO PENDIENTE DE CIERRE
            mXMLTW.WriteEndDocument();

            //SE CIERRA EL XMLTEXTWRITER

            mXMLTW.Close();
        }

        private void BtnCargarXML_Click(object sender, EventArgs e)
        {
            this.grdPersonas.Rows.Clear();

            string mNombre = null;
            string mApellido = null;
            string mSaldo = null;

            XmlTextReader mXMLTR = new XmlTextReader("Personas.xml");

            while (mXMLTR.Read())
            {
                if (mXMLTR.NodeType == XmlNodeType.Element)
                {
                    //EL NODO EN EL QUE SE POSICIONA EL CURSOR ES DE TIPO <ELEMENT> EN SU TAG DE APERTURA
                    if (mXMLTR.Name == "persona")
                    {
                        //LLEGAMOS A UN NODO PERSONA, ENTONCES DEBEMOS LEER LOS ATRIBUTOS DEL NODO PARA OBTENER EL NOMBRE Y APELLIDO
                        //YA SABEMOS QUE LOS ELEMENTOS PERSONA TIENEN ATRIBUTOS
                        //UTILIZAMOS EL METODO HASATTRIBUTES CON FINES DIDACTICOS
                        if (mXMLTR.HasAttributes)
                        {
                            while (mXMLTR.MoveToNextAttribute())
                            {
                                if (mXMLTR.Name == "nombre")
                                {
                                    mNombre = mXMLTR.Value;
                                }
                                else if (mXMLTR.Name == "apellido")
                                {
                                    mApellido = mXMLTR.Value;
                                }
                            }
                            //COMO NOS METIMOS EN LOS ATRIBUTOS DEL ELEMENTO, 
                            //DEBEMOS REPOSICIONAR EL CURSOR NUEVAMENTE EN EL ELEMENTO
                            //PARA SEGUIR CON LA JERARQUIA
                            mXMLTR.MoveToElement();
                        }

                    }
                    else if (mXMLTR.Name == "saldo")
                    {
                        //COMO YA SABEMOS QUE DENTRO DE UN ELEMENTO PERSONA
                        //TENDREMOS UN ELEMENTO SALDO, SABREMOS QUE
                        //SI LLEGAMOS A ESTE PUNTO, YA TENEMOS TODOS LOS ELEMENTOS
                        //PARA AGREGAR UNA PERSONA A LA GRILLA

                        //ACCEDEMOS AL CONTENIDO DEL ELEMENTO SALDO Y VOLVEMOS AL ELEMENTO
                        //NO VERIFICAMOS SI HAY ATRIBUTOS PORQUE SABEMOS QUE ESE
                        //ELEMENTO NO LOS CONTIENE
                        mXMLTR.MoveToContent();
                        mSaldo = mXMLTR.ReadString();
                        mXMLTR.MoveToElement();

                        //POR LAS DUDAS VERIFICAMOS TENER AL MENOS UN DATO PARA LA GRILLA
                        if (!string.IsNullOrEmpty(mNombre) | !string.IsNullOrEmpty(mApellido) | !string.IsNullOrEmpty(mSaldo))
                        {
                            this.grdPersonas.Rows.Add(mNombre, mApellido, mSaldo);
                        }
                    }
                }
            }
            mXMLTR.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader mSR = new StreamReader("Personas.xml");
            this.txtPersonasXML.Text = mSR.ReadToEnd();
            mSR.Close();
        }
    }
}

 


 

         
    

