﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> frutas =
            new List<string> { "manzana", "frutilla", "banana", "mango",
                               "naranja", "uva", "pera", "durazno" };
  
            foreach (string fruta in frutas.Where(fruit => fruit.Length < 6))
            {
                listBox1.Items.Add(fruta);
            }
        }
    }
}