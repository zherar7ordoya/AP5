using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion_UI
{
    public partial class frAlumno : Form
    {
        public frAlumno()
        {
            InitializeComponent();
            //instancio los objetos en el constructor del form
            oBLLAlu = new BLLAlumno();
            oBLLLoc = new BLLLocalidad();
        }

        BLLAlumno oBLLAlu;
        BLLLocalidad oBLLLoc;
        private void frAlumno_Load(object sender, EventArgs e)
        {
            CargarComboLocalidad();
            CargarGrilla();
        }


        //cargo el combo localidad
        void CargarComboLocalidad()
        {
              comboBox1.DataSource = null;
            //llamo al metodo para cargar Localidades que me devuleve una lista
            comboBox1.DataSource = oBLLLoc.CargarListaLocalidades();
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            comboBox1.ValueMember = "Codigo";
            //la variable publica de la clase
            comboBox1.DisplayMember = "Localidad";
            comboBox1.Refresh();
        }

        void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            //llamo al metodo cargar alumnos de Alumno que me devuelve una lista
            this.dataGridView1.DataSource = oBLLAlu.CargarListaAlumnos();
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
            //cambio el nombre de la columna oLocalidad x Localidad
            this.dataGridView1.Columns["oLocalidad"].HeaderText = "Localidad";
        }
        //Asigno los valores al objeto
        void Asignar()
        {
            try
            {
                oBLLAlu.Codigo = Convert.ToInt32(textcod.Text); 
                oBLLAlu.Nombre = textNombre.Text;
                oBLLAlu.Apellido = textApe.Text;
                oBLLAlu.DNI = Convert.ToInt32(txtDNI.Text);
                oBLLAlu.FechaNac = this.dateTimePicker1.Value;
                oBLLAlu.Edad = oBLLAlu.Calcular_Edad();
                oBLLAlu.oLocalidad = (BLLLocalidad)this.comboBox1.SelectedItem;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        // metodo limpiar
        void Limpiar()
        {
            textNombre.Text = null;
            textApe.Text = null;
            textEdad.Text = null;
            txtDNI.Text = null;
            textcod.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLLPrueba oBLLPrueba = new BLLPrueba();
            //uso el metodo testconnection que me dice el estado de la conexion., Y USO EL CONSTRUCTOR DE MessageBox
            MessageBox.Show(oBLLPrueba.TestCX(), "PROBANDO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLAlu.Nombre = textNombre.Text;
                oBLLAlu.Apellido = textApe.Text;
                oBLLAlu.DNI = Convert.ToInt32(txtDNI.Text);
                oBLLAlu.FechaNac = this.dateTimePicker1.Value;
                oBLLAlu.Edad = oBLLAlu.Calcular_Edad();
                oBLLAlu.oLocalidad = (BLLLocalidad)this.comboBox1.SelectedItem;
                oBLLAlu.AltaAlumno(oBLLAlu);
                CargarGrilla();
                Limpiar();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            oBLLAlu = (BLLAlumno)this.dataGridView1.CurrentRow.DataBoundItem;
            textcod.Text = oBLLAlu.Codigo.ToString();
            textNombre.Text = oBLLAlu.Nombre;
            textApe.Text = oBLLAlu.Apellido;
            txtDNI.Text = oBLLAlu.DNI.ToString();
            textEdad.Text = oBLLAlu.Edad.ToString();
            comboBox1.Text = oBLLAlu.oLocalidad.Localidad;
            this.dateTimePicker1.Value = oBLLAlu.FechaNac;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                oBLLAlu.ModifAlumno(oBLLAlu);
                CargarGrilla();
                Limpiar();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnELiminar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Confirma la eleminación del Alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    if (oBLLAlu.BajaAlumno(oBLLAlu) == false)
                    { MessageBox.Show("Para dar de baja al Alumno no debe tener Materias Asociadas"); }
                    else
                    {   //cargo la grilla para actualizar la informacion
                        CargarGrilla();
                        Limpiar();
                    }            
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
