using ABS;
using Autofac;
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
            var container = ConfiguracionContainer.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var modelo = scope.Resolve<IModelo>();
                var procesador = scope.Resolve<IProcesador>();
                var database = scope.Resolve<IDatabase>();

                modelo.Nombre = NombreTextbox.Text;
                modelo.Descripcion = DescripcionTextbox.Text;

                modelo = procesador.AgregarCodigo((Modelo)modelo);
                CodigoTextbox.Text = modelo.Codigo.ToString();

                MessageBox.Show(database.Guardar((Modelo)modelo));
            }
        }
    }
}
