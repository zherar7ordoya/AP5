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
    public partial class frMateria : Form
    {
        public frMateria()
        {
            InitializeComponent();
            //intancio el objeto Materia en el constructor del form
            oBLLMat = new BLLMateria();
        }
       
       
        private void frMateria_Load(object sender, EventArgs e)
        {   //cargo la grilla para mostrar las materias existentes
            CargarGrilla();
        }

        BLLMateria oBLLMat;

      
        public void CargarGrilla()
        {
          
            this.dataGridView1.DataSource = null;
            //llamo al metodo para cargar las listas del objeto materia
            this.dataGridView1.DataSource = oBLLMat.CargarListaMateria();
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {  //instancio y abro el formulario ABMMAterias
            ABMMaterias oABMNat = new ABMMaterias();
            //uso el showDialog, para luego pasar el valor y seguir con la ejecución del código.
            DialogResult respuesta = oABMNat.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                CargarGrilla();
            }
                      
        }


        //digo que el evento es DiubleClick
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               
                oBLLMat = (BLLMateria)this.dataGridView1.CurrentRow.DataBoundItem;

                //si el indice de la columna es 0, entonces Edito
                if (e.ColumnIndex == 0)
                {   //instancio el form ABM de materia y le paso los para editar
                    ABMMaterias oABMNat = new ABMMaterias();
                    oABMNat.textcod.Text = oBLLMat.Codigo.ToString();
                    oABMNat.textNombre.Text = oBLLMat.Materia;

                    //si la respuesta es OK, actualizo la grilla
                    DialogResult respuesta = oABMNat.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {
                        CargarGrilla();
                    }
                }
                //el indice 1 lo uso para eliminar
                if (e.ColumnIndex == 1)
                {
                    DialogResult Respuesta2;
                    Respuesta2 = MessageBox.Show("¿Confirma la eleminación de la Materia?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta2 == DialogResult.Yes)
                    {
                        if (oBLLMat.Baja(oBLLMat) == false)
                        { MessageBox.Show("Para dar de baja la Materia no dene estar asociada a nignún ALumno"); }
                        else
                        { 
                            //llamo al metodo baja y paso el objeto para los datos de la consulta
                            //y el id de operación
                            oBLLMat.Baja(oBLLMat);
                            //actualizo nuevamente la grilla para que refresque los cambios
                            CargarGrilla();
                        
                         }
                    }
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
