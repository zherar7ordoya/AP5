using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ABMxml
{
    public partial class JuegosFormulario : Form
    {
        public JuegosFormulario() => InitializeComponent();

        //|||||||||||||||||||||||| VARIABLES DE CLASE Y PROCEDIMIENTOS DE CARGA
        XDocument xdocument;
        readonly string archivo = "juegos.xml";

        private void JuegosFormulario_Load(object sender, EventArgs e) => CargarJuegos();

        void CargarJuegos()
        {
            xdocument = XDocument.Load(archivo);
            var datos = xdocument.Descendants("juego").Select(x=> new
            {
                Id = x.Element("id").Value,
                Nombre = x.Element("nombre").Value,
                Genero = x.Element("genero").Value,
                Plataforma = x.Element("plataforma").Value,
                Compania = x.Element("compania").Value
            }).OrderBy(i=> i.Id).ToList();

            IdTextBox.DataBindings.Clear();
            NombreTextBox.DataBindings.Clear();
            GeneroTextBox.DataBindings.Clear();
            PlataformaTextBox.DataBindings.Clear();
            CompaniaTextBox.DataBindings.Clear();

            IdTextBox.DataBindings.Add("text", datos, "id");
            NombreTextBox.DataBindings.Add("text", datos, "nombre");
            GeneroTextBox.DataBindings.Add("text", datos, "genero");
            PlataformaTextBox.DataBindings.Add("text", datos, "plataforma");
            CompaniaTextBox.DataBindings.Add("text", datos, "compania");

            JuegosDGV.DataSource = datos;
        }

        void LimpiarTextBoxes()
        {
            foreach(var item in Controls)
            {
                if (item is TextBox) (item as TextBox).Clear();
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BOTONES

        private void AltaButton_Click(object sender, EventArgs e)
        {
            XElement juego =
                new XElement("juego",
                new XElement("id", IdTextBox.Text.Trim()),
                new XElement("nombre", NombreTextBox.Text.Trim()),
                new XElement("genero", GeneroTextBox.Text.Trim()),
                new XElement("plataforma", PlataformaTextBox.Text.Trim()),
                new XElement("compania", CompaniaTextBox.Text.Trim()));
            xdocument.Root.Add(juego);
            xdocument.Save(archivo);
            CargarJuegos();
            LimpiarTextBoxes();
        }

        private void BajaButton_Click(object sender, EventArgs e)
        {
            XElement juego = xdocument.Descendants("juego").FirstOrDefault(x => x.Element("id").Value == IdTextBox.Text);

            if (juego != null)
            {
                juego.Remove();
                xdocument.Save(archivo);
                CargarJuegos();
                LimpiarTextBoxes();
            }
        }

        private void ModificacionButton_Click(object sender, EventArgs e)
        {
            XElement juego = xdocument.Descendants("juego").FirstOrDefault(x => x.Element("id").Value == IdTextBox.Text);

            if (juego != null)
            {
                juego.Element("nombre").Value = NombreTextBox.Text.Trim();
                juego.Element("genero").Value = GeneroTextBox.Text.Trim();
                juego.Element("plataforma").Value = PlataformaTextBox.Text.Trim();
                juego.Element("compania").Value = CompaniaTextBox.Text.Trim();

                xdocument.Save(archivo);
                CargarJuegos();
                LimpiarTextBoxes();
            }
        }

    }
}
