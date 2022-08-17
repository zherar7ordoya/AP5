using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI_XML
{
    public partial class LINQtoXML : Form
    {
        public LINQtoXML()
        {
            InitializeComponent();
        }

        private void LeerXMLconLinQ_Load(object sender, EventArgs e)
        {   }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarXml();      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeerXML();
        }


        private void LeerXML()
        {
            XDocument xmlDoc = XDocument.Load("Jugadores.xml");

            var Consulta = from Jugador in xmlDoc.Descendants("Jugador")
                           select new
                           {
                               Nombre = Jugador.Element("Nombre").Value,
                               Apellido = Jugador.Element("Apellido").Value,
                               Equipo = Jugador.Element("Equipo").Value,
                               Posicion = Jugador.Element("Posicion").Value,
                           };
            //lo que leo lo paso al texbox
            textBox1.Text = null;
            foreach (var a in Consulta)
            {
                textBox1.Text = textBox1.Text + "Nombre: " + a.Nombre + " \n";
                textBox1.Text = textBox1.Text + "Apellido: " + a.Apellido + " \n";
                textBox1.Text = textBox1.Text + " Equipo: " + a.Equipo + " \n";
                textBox1.Text = textBox1.Text + " Posicion: " + a.Posicion + " \r\n";
            }

            if (textBox1.Text == null)
                textBox1.Text = "No existen resultados.";
        }

        private void AgregarXml()
        {
            XDocument xmlDoc = XDocument.Load("Jugadores.xml");

            xmlDoc.Element("Jugadores").Add(new XElement("Jugador", 
                                         new XElement("Nombre", this.txtNombre.Text.Trim()),
                                         new XElement("Apellido", this.txtNombre.Text.Trim()),
                                         new XElement("Equipo",txtEquipo.Text.Trim()), 
                                         new XElement("Posicion", CboPosicion.SelectedItem.ToString())));

            xmlDoc.Save("Jugadores.xml");
            LeerXML();
        }

        private void LINQtoXML_Load(object sender, EventArgs e)
        {

        }
    }
    
}
