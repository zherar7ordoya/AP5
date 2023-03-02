using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class ComedorAnimalForm : Form
    {
        List<Animal> _listaAnimales = new List<Animal>();
        List<Vegetacion> _listaAlimentos = new List<Vegetacion>();


        public ComedorAnimalForm()
        {
            InitializeComponent();
        }

        private void ComedorAnimalForm_Load(object sender, EventArgs e)
        {
            _listaAnimales.Add(new Cebra("Rayada"));
            _listaAnimales.Add(new Ciervo("Bambi"));
            _listaAnimales.Add(new Leon("Fred"));
            _listaAnimales.Add(new Tigre("Tom"));

            _listaAlimentos.Add(new Pasto("California"));
            _listaAlimentos.Add(new Planta("Cactus"));


            ListaAnimalesDgv.DataSource = _listaAnimales;
            ListaAlimentosDgv.DataSource = _listaAlimentos;
        }
    }
}
