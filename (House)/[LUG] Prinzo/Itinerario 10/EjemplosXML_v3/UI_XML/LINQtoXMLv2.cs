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
    public partial class LINQtoXMLv2 : Form
    {
        public LINQtoXMLv2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarListbox();
            CargarGrilla();
        }

        private void CargarListbox()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = LeerXML2();
        }

        private void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LeerXML2();
        }

        public List<Juego> LeerXML2()
        {
            //en load va la direccion del archivo, si pongo solo el nombre, es xq e guarda en el servidor
            //luego los elementos y atributos como estan estructurado en el XML
            var consulta =
                from juego in XElement.Load("Juegos.XML").Elements("juego")
                select new Juego
                {
                    IdJuego = Convert.ToInt32(Convert.ToString(juego.Attribute("id").Value).Trim()),
                    NombreJuego = Convert.ToString(juego.Element("nombre").Value).Trim(),
                    GeneroJuego = Convert.ToString(juego.Element("genero").Value).Trim(),
                    PlataformaJuego = Convert.ToString(juego.Element("plataforma").Value).Trim(),
                    CompaniaCreadora = Convert.ToString(juego.Element("companiaCreadora").Value).Trim()
                };//Fin de consulta.
            //paso la consulta a lista del tipo clase Juego
            List<Juego> Lstjuegos = consulta.ToList<Juego>(); 
            return Lstjuegos;
        }


        private void AgregarXML2()
        {
            XDocument xmlDoc = XDocument.Load("Juegos.XML");
            // en el Xdocument, utilizo, y agrego como esta estructurado el XML
            xmlDoc.Element("juegos").Add(new XElement("juego",
                                        new XAttribute("id", this.txtid.Text.Trim()),
                                        new XElement("nombre", txtNom.Text.Trim()),
                                        new XElement("genero", comboBox1.Text.Trim()),
                                        new XElement("plataforma", txtPlataforma.Text.Trim()),
                                        new XElement("companiaCreadora", txtempresa.Text.Trim())));

            //luego el metodo save guarda lo ingresado en el XML
            xmlDoc.Save("Juegos.XML");
            LeerXML2();
        }

        public enum Genero : int
        {
            Acción =1,
            Arcade=2,
            Deportivo=3,
            Estrategia=4,
            Simulación=5
        }

        void CargarComboGenero()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Genero));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AgregarXML2();
            CargarListbox();
            CargarGrilla();
         
        }

        private void LINQtoXMLv2_Load(object sender, EventArgs e)
        {
            CargarComboGenero();
        }
    }
}
