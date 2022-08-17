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
    public partial class LecturaEscrituraI : Form
    {
        public LecturaEscrituraI()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MostrarXML("libros.xml");
           // MostrarXML("Juegos.XML");
        }

        void MostrarXML(string Archivo)
        {
            //limpio el treeview
            this.Arbol.Nodes.Clear();
            //creo el objetoArchivoXML del tipo XMLtextereader
            XmlTextReader ArchivoXML = new XmlTextReader(Archivo);
            try
            {   //Leo el archivo XML 
                while (ArchivoXML.Read())
                {        //los nodos del tipo elemento
                    if (ArchivoXML.NodeType == XmlNodeType.Element)
                    {  //si tiene atributos
                        if (ArchivoXML.HasAttributes == true)
                        {      //por si tiene mas 1  atributo, me muevo en el elemento
                            while (ArchivoXML.MoveToNextAttribute())
                            {
                                this.Arbol.Nodes.Add(ArchivoXML.Value);
                            }
                        }
                    }
                    
                    if (ArchivoXML.NodeType == XmlNodeType.Text)
                    {
                        this.Arbol.Nodes.Add(ArchivoXML.Value);
                    }
                }
            }
            catch (System.Xml.XmlException ex)
            {  MessageBox.Show(ex.Message); }
        }

        private void LecturaEscrituraI_Load(object sender, EventArgs e)
        {

        }
       
        private void Button2_Click_1(object sender, EventArgs e)
        {    // se escribe el documento de 0
            XmlTextWriter archivoxml = new XmlTextWriter("Ejemplo2.xml", System.Text.Encoding.UTF8);
            archivoxml.Formatting = Formatting.Indented;
            //identation es para que se escriba nueva lineas
            archivoxml.Indentation=2;
            archivoxml.WriteStartDocument(true);
            archivoxml.WriteStartElement("Alumno");
            archivoxml.WriteAttributeString("DNI", this.textBox1.Text.ToString());
            archivoxml.WriteElementString("Nombre", this.textBox2.Text.ToString());
            archivoxml.WriteElementString("Apellido", this.textBox3.Text.ToString());
            archivoxml.WriteEndElement();
            archivoxml.WriteEndDocument();
            archivoxml.Close();
            MostrarXML("Ejemplo2.xml");
            Limpiar();
        }

        //void CrearItem(XmlTextWriter archivoxml)
        //{
        //    archivoxml.WriteAttributeString("DNI", this.textBox1.Text.ToString());
        //    archivoxml.WriteElementString("Nombre", this.textBox2.Text.ToString());
        //    archivoxml.WriteElementString("Apellido", this.textBox3.Text.ToString());
        //}

        void Limpiar()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        private void Button3_Click_1(object sender, EventArgs e)
        {
            //limpio el treeview
            this.Arbol.Nodes.Clear();
            XmlDocument doc = new XmlDocument();
             doc.Load("libros.xml");
           // doc.Load("Juegos.XML");
            foreach (XmlNode f in doc.DocumentElement)
            {
                foreach (XmlNode a in f.Attributes)
                {
                    this.Arbol.Nodes.Add (a.InnerText);
                }
                foreach (XmlNode ff in f.ChildNodes)
                {
                    this.Arbol.Nodes.Add(ff.InnerText);
                }

            }
        }
    }
}
