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
    public partial class LINQtoXMLv4 : Form
    {
        public LINQtoXMLv4()
        {
            InitializeComponent();
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
        private void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LeerXML2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
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
        private void button4_Click(object sender, EventArgs e)
        {
            AgregarXML2();
            CargarGrilla();
        }

        public enum Genero : int
        {
            Acción = 1,
            Arcade = 2,
            Deportivo = 3,
            Estrategia = 4,
            Simulación = 5
        }

        void CargarComboGenero()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Genero));
        }
       
        public void BorrarNodo(string ID)
        {
            //cargo el XML
            XDocument doc = XDocument.Load("Juegos.XML");

            //consulto por algun campo en este caso por el atribnuto ID
            //puedo consultar por elemento también
            var consulta = from juego in doc.Descendants("juego")
                    where juego.Attribute("id").Value == ID
                    select juego;
            //metodo remove borro todo el nodo
            consulta.Remove();

            //despues del borrado , guardo el archivo XML para que impacte el cambio
            doc.Save("Juegos.XML");
        }

        public void ModificarNodo(string ID)
        {
            //cargo el XML
            XDocument doc = XDocument.Load("Juegos.XML");

            //consulto por algun campo en este caso por el atribnuto ID
            //puedo consultar por elemento también
            var consulta = from juego in doc.Descendants("juego")
                           where juego.Attribute("id").Value == ID
                           select juego;

          //recorro la consulta y modifico el elemento de la consulta
           foreach (XElement EModifcar in consulta)
            {
                //recorro y le paso los nuevos valores 
                EModifcar.Element("nombre").Value = txtNom.Text.Trim();
                EModifcar.Element("genero").Value = comboBox1.Text.Trim();
                EModifcar.Element("plataforma").Value = txtPlataforma.Text.Trim();
                EModifcar.Element("companiaCreadora").Value = txtempresa.Text.Trim();
            }

            //despues de modificar , guardo el archivo XML para que impacte el cambio
            doc.Save("Juegos.XML");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BorrarNodo(txtid.Text);
                CargarGrilla();
             }
            else
            {
                MessageBox.Show("Seleccione el Nodo a eliminar");
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Juego oJuego = new Juego();
            oJuego = (Juego)dataGridView1.CurrentRow.DataBoundItem;
            txtid.Text = oJuego.IdJuego.ToString().Trim();
            txtNom.Text = oJuego.NombreJuego.Trim();
            txtPlataforma.Text = oJuego.PlataformaJuego.Trim();
            comboBox1.Text = oJuego.GeneroJuego.Trim();
            txtempresa.Text = oJuego.CompaniaCreadora.Trim();
        }

     
        private void LINQtoXMLv4_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarComboGenero();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPlataforma.Text = string.Empty;
            comboBox1.Text = string.Empty;
            txtempresa.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ModificarNodo(txtid.Text);
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione el Nodo a Modificar");
            }

        }
    }
}
