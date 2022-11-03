using BEL;
using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace UIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            var modelo = new Modelo();
            var procesador = new Procesador();
            var database = new Database();

            modelo.Nombre = NombreTextbox.Text;
            modelo.Descripcion = DescripcionTextbox.Text;

            modelo = procesador.AgregarCodigo(modelo);
            CodigoTextbox.Text = modelo.Codigo.ToString();

            MessageBox.Show(database.Guardar(modelo));
        }
    }
}
