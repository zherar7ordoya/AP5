﻿using System;
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
        List<IAlimento> _listaAlimentos = new List<IAlimento>();

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

            foreach(var item in _listaAnimales)
            {
                if (item is IAlimento) _listaAlimentos.Add(item as IAlimento);
            }

            _listaAlimentos.Add(new Pasto("California"));
            _listaAlimentos.Add(new Planta("Cactus"));


            ListaAnimalesDgv.DataSource = _listaAnimales;
            ListaAlimentosDgv.DataSource = _listaAlimentos;
        }
    }
}
