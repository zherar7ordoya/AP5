using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Persona _persona;
        List<Persona> personas = new List<Persona>();

        private void button1_Click(object sender, EventArgs e)
        {
            _persona = new Persona(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
            personas.Add(_persona);
            Enlazar();
        }

        private void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
            textBox1.Text = Convert.ToString(p.Dni);
            textBox2.Text = p.Nombre;
            textBox3.Text = p.Apellido;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Persona p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox1.Text = Convert.ToString(p.Dni);
                textBox2.Text = p.Nombre;
                textBox3.Text = p.Apellido;
            }
            catch (Exception)
            {
 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
            personas.Remove(p);
            Enlazar();
        }
    }

   
}
