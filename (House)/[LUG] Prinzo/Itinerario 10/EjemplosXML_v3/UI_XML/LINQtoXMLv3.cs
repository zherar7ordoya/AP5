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
    public partial class LINQtoXMLv3 : Form
    {
        public LINQtoXMLv3()
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

        private void CargarGrillaBusqueda1(string Campoabuscar)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BuscarenXML(Campoabuscar);
        }
        //metodo de busqueda 
        public List<Juego> BuscarenXML(string Campoabuscar)
        {
            //en load va la direccion del archivo, si pongo solo el nombre, es xq e guarda en el servidor
            //luego los elementos y atributos como estan estructurado en el XML
            var consulta =
                from juego in XElement.Load("Juegos.XML").Elements("juego")
                where (string)juego.Element("genero") == Campoabuscar.ToString()
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

        private void CargarGrillaBusqueda2(string Campoabuscar)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BuscarenXML2(Campoabuscar);
        }
        //metodo de busqueda 
        public List<Juego> BuscarenXML2(string Campoabuscar)
        {
            //en load va la direccion del archivo, si pongo solo el nombre, es xq e guarda en el servidor
            //luego los elementos y atributos como estan estructurado en el XML
            var consulta =
                from juego in XElement.Load("Juegos.XML").Elements("juego")
                where (string)juego.Element("plataforma") == Campoabuscar.ToString().Trim()
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
        private void LINQtoXMLv3_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarComboGenero();
           label6.Visible = false;
            label7.Visible = false;
            comboBox1.Visible = false;
            txtPlataforma.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            comboBox1.Visible = true;
            label6.Visible = false;
            txtPlataforma.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
            comboBox1.Visible = false;
            label6.Visible = true;
            txtPlataforma.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {   
                CargarGrillaBusqueda1(comboBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                CargarGrillaBusqueda2(txtPlataforma.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=LeerXML2();
        }
    }
}
