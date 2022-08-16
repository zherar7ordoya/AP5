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

namespace UI_XML
{
    public partial class LecturaEscrituraDOM : Form
    {
        public LecturaEscrituraDOM()
        {
            InitializeComponent();
        }

        //creo el objeto del tipo XMLDocument
        XmlDocument MiXMLD = new XmlDocument();
        private void LecturaEscrituraDOM_Load(object sender, EventArgs e)
        {
            SetearGrilla();
        }


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
            MiXMLD = new XmlDocument();

            //ESTABLECEMOS LA DECLARACION DEL DOCUMENTO CON LA VERSION, CODIFICACION Y STANDALONE=YES
            MiXMLD.AppendChild(MiXMLD.CreateXmlDeclaration("1.0", System.Text.Encoding.UTF8.WebName, "yes"));

            //AGREGAMOS UN COMENTARIO PARA SABER COMO SE GENERO EL CONTENIDO
            MiXMLD.AppendChild(MiXMLD.CreateComment("CONTENIDO CREADO EN XMLDOCUMENT EL " +  DateTime.Now));

            XmlElement mXMLE = default(XmlElement);

            //SE CREA EL ELEMENTO RAIZ
            mXMLE = MiXMLD.CreateElement("personas");

            //PARA CADA FILA DE LA GRILLA:

            foreach (DataGridViewRow Fila in this.grdPersonas.Rows)
            {
                //SI LA FILA ESTA VACIA SE SALTEA.
                //ESTO LO HACEMOS EN ESTE EJEMPLO PORQUE EL DATAGRIDVIEW DE .NET
                //AGREGA SIEMPRE UNA FILA VACIA SI SE PERMITE LA EDICION 
                //DIRECTA DEL USUARIO (CON EL ATRIBUTO ALLOWUSERTOADDROWS QUE SETEAMOS COMO TRUE)

                if (!((Fila.Cells[0].Value == null) && ((Fila.Cells[1].Value == null) && (Fila.Cells[2].Value == null))))
                {
                    //SE CREA UN ELEMENTO PERSONA
                    XmlElement mXMLEPers = MiXMLD.CreateElement("persona");

                    //SE ESTABLECEN EL NOMBRE Y EL APELLIDO COMO ATRIBUTOS
                    //SE CREA UN ATRIBUTO PARA EL NOMBRE
                    XmlAttribute mXMLA = MiXMLD.CreateAttribute("nombre");
                    //SE ASIGNA EL VALOR
                    mXMLA.Value = Fila.Cells[0].Value.ToString();
                    //SE AGREGA AL ELEMENTO ACTUAL <persona>
                    mXMLEPers.Attributes.Append(mXMLA);
                    //SE CREA UN ATRIBUTO PARA EL APELLIDO
                    mXMLA = MiXMLD.CreateAttribute("apellido");
                    //SE ASIGNA EL VALOR
                    mXMLA.Value = Fila.Cells[1].Value.ToString();
                    //SE AGREGA AL ELEMENTO ACTUAL <persona>
                    mXMLEPers.Attributes.Append(mXMLA);

                    //SE CREA UN ELEMENTO NUEVO <saldo>
                    XmlElement mXMLESaldo = MiXMLD.CreateElement("saldo");
                    //SE LE ASIGNA EL VALOR
                    //PARA ASIGNAR UN VALOR NECESITAMOS CREAR UN NODO DE TIPO TEXTO
                    //EL TEXTO ENTRE TAGS DE APERTURA Y CIERRE (<elemento>TEXTO</elemento>)
                    //TAMBIEN ES UN NODO. SE REPRESENTA CON UN OBJETO XMLTEXT
                    XmlText mXMLText = MiXMLD.CreateTextNode(Fila.Cells[2].Value.ToString());
                    mXMLESaldo.AppendChild(mXMLText);

                    //EL NODO <saldo> SE AGREGA COMO HIJO AL ELEMENTO <persona>
                    mXMLEPers.AppendChild(mXMLESaldo);

                    //FINALMENTE SE AGREGA EL ELEMENTO <persona>
                    //COMO ELEMENTO HIJO AL ELEMENTO <personas> RAIZ
                    mXMLE.AppendChild(mXMLEPers);
                }
            }

            //POR ULTIMO AGREGAMOS EL ELEMENTO RAIZ <personas> EN EL DOCUMENTO
           MiXMLD.AppendChild(mXMLE);

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.grdPersonas.Rows.Clear();
            if (!(MiXMLD == null))
            {
                string mNombre = null;
                string mApellido = null;
                string mSaldo = null;
                XmlElement mXMLERaiz = MiXMLD.DocumentElement;
                // PARA CADA NODO HIJO DEL ELEMENTO RAIZ:
                foreach (XmlNode mXMLN in mXMLERaiz.ChildNodes)
                {
                    // SI ES DEL TIPO <persona> NOS INTERESA
                    if ((mXMLN.Name == "persona"))
                    {
                        // SI TIENE ATRIBUTOS, SE LEEN
                        // YA SABEMOS QUE TIENEN LOS ATRIBUTOS nombre Y apellido
                        // SE CONTROLA LA CANTIDAD CON FINES DIDACTICOS
                        if ((mXMLN.Attributes.Count > 0))
                        {
                            // PARA CADA ATRIBUTO EN EL NODO <persona>:
                            foreach (XmlAttribute mAtr in mXMLN.Attributes)
                            {
                                if ((mAtr.Name == "nombre"))
                                {
                                    mNombre = mAtr.Value;
                                }
                                else if ((mAtr.Name == "apellido"))
                                {
                                    mApellido = mAtr.Value;
                                }

                            }

                        }

                        // SE OBTIENE EL PRIMER NODO HIJO DEL ELEMENTO <persona>
                        // YA SABEMOS QUE ESTE NODO SERA UN ELEMENTO DE TIPO <saldo>
                        XmlElement mXMLESaldo = (XmlElement) mXMLN.FirstChild;
                       
                        // DE TODAS MANERAS CONTROLAMOS QUE ASI SEA
                        if ((mXMLESaldo.Name == "saldo"))
                        {
                            // SE LEE EL VALOR DEL PRIMER HIJO DEL ELEMENTO <saldo>
                            // ESTE PRIMER HIJO SABEMOS QUE SERA DE TIPO XMLTEXT (EL CONTENIDO DEL NODO)
                            mSaldo = mXMLESaldo.FirstChild.Value;
                        }

                    }

                    // SI TENEMOS DATOS PARA AGREGAR, LOS AGREGAMOS A LA GRILLA
                    if (((mNombre != null) || ((mApellido != null) || (mSaldo != null))))
                    {
                        this.grdPersonas.Rows.Add(mNombre, mApellido, mSaldo);
                    }

                }

            }

            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if ((MiXMLD != null))
            {
                this.txtPersonasXML.Text = MiXMLD.InnerXml;
            }
            else
            {
                this.txtPersonasXML.Text = "No se ha creado aún el XMLDocument";

            }
        }

        private void BtnCargardesdeArchivo_Click(object sender, EventArgs e)
        {
            if ((MiXMLD != null))
            { MiXMLD.Load("Personas.xml"); }

        }

        private void GrabaraArchivo_Click(object sender, EventArgs e)
        {
            if ((MiXMLD != null))
            {  MiXMLD.Save("Personas.xml"); }
        }

        private void BtnVerXML_Click(object sender, EventArgs e)
        {
            this.txtPersonasXML.Text = (MiXMLD.FirstChild.OuterXml + "\r\n");
            foreach (XmlNode mNodo in MiXMLD)
            {
                MostrarNodo(mNodo);
            }
        }


        private void MostrarNodo(XmlNode pNodo, int pNivel = 0)
        {

            switch (pNodo.NodeType)
            {

                case XmlNodeType.Comment:
                    this.txtPersonasXML.Text += pNodo.Value + "\r\n";
                    break;
                case XmlNodeType.Text:
                    for (int x = 0; x <= pNivel + 1; x++)
                    {
                        this.txtPersonasXML.Text += "  ";
                    }

                    this.txtPersonasXML.Text += pNodo.InnerText + "\r\n";
                    break;
                case XmlNodeType.Element:
                    for (int x = 0; x <= pNivel; x++)
                    {
                        this.txtPersonasXML.Text += "  ";
                    }

                    this.txtPersonasXML.Text += "<" + pNodo.Name;
                    if (pNodo.Attributes.Count > 0)
                    {
                        foreach (XmlAttribute mAtr in pNodo.Attributes)
                        {
                            this.txtPersonasXML.Text += " " + mAtr.Name + "=\"" + mAtr.Value + "\"";
                        }
                    }

                    if (pNodo.HasChildNodes)
                    {
                        this.txtPersonasXML.Text += ">" + "\r\n";
                        foreach (XmlNode mNodo in pNodo.ChildNodes)
                        {
                            MostrarNodo(mNodo, pNivel + 1);
                        }
                        for (int x = 0; x <= pNivel; x++)
                        {
                            this.txtPersonasXML.Text += "  ";
                        }
                        this.txtPersonasXML.Text += "</" + pNodo.Name + ">" + "\r\n";
                    }
                    else
                    {
                        this.txtPersonasXML.Text += "/>" + "\r\n";
                    }

                    break;
            }
        }


    }
}
