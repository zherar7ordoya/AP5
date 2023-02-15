using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Integrador
{
    public partial class Form1 : Form
    {
        Concesionario _c;

        public Form1()
        {
            InitializeComponent();
            _c= new Concesionario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarGrilla(dataGridView1, _c.RetornaListaPersonas());
        }


        void RefrescarGrilla(DataGridView pDGV, object pObject)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pObject;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _c.AgregarPersona(new Persona(
                    Interaction.InputBox("DNI"),
                    Interaction.InputBox("Nombre"),
                    Interaction.InputBox("Apellido")));
                RefrescarGrilla(dataGridView1, _c.RetornaListaPersonas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    _c.BorrarPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
                    RefrescarGrilla(dataGridView1, _c.RetornaListaPersonas());
                }
                else
                {
                    throw new Exception("No hay nada para borrar");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Persona _auxPersona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                    if (_auxPersona != null)
                    {
                        _auxPersona.Nombre = Interaction.InputBox("Nombre", "Modificación", _auxPersona.Nombre);
                        _auxPersona.Apellido = Interaction.InputBox("Apellido", "Modificación", _auxPersona.Apellido);
                        _c.ModificarPersona(_auxPersona);
                        RefrescarGrilla(dataGridView1, _c.RetornaListaPersonas());
                    }
                    else
                    {
                        throw new Exception("No existe la persona a modificar");
                    }
                }
                else
                {
                    throw new Exception("No hay nada para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
