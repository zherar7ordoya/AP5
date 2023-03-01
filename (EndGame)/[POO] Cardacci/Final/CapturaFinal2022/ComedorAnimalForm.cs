using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturaFinal2022
{
    public partial class ComedorAnimalForm : Form
    {
        List<Animal> _listaAnimales = new List<Animal>();
        List<IAlimento> _listaAlimentos = new List<IAlimento>();


        public ComedorAnimalForm()
        {
            InitializeComponent();
        }

        private void ComedorAnimalForm_Load(object sender, EventArgs e)
        {
            _listaAnimales.Add(new Cebra());
            _listaAnimales.Add(new Ciervo());
            _listaAnimales.Add(new Leon());
            _listaAnimales.Add(new Tigre());

            _listaAlimentos.Add(new Cebra());
            _listaAlimentos.Add(new Ciervo());
            _listaAlimentos.Add(new Pasto());
            _listaAlimentos.Add(new Planta());

            ListaAnimalesDgv.DataSource = _listaAnimales;
            ListaAlimentosDgv.DataSource = _listaAlimentos;
        }
    }
}
