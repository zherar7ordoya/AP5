using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class Localidad : Form
    {
        public Localidad()
        {
            InitializeComponent();
            //intanacio el objeto en el constructor del form
            oBLLLoc = new BLLLocalidad();
            oBELoc = new BELocalidad();
        }



        BLLLocalidad oBLLLoc;
        BELocalidad oBELoc;


        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                //antes de eliminar voy a confirmar 
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Confirma la eleminación de la Localidad?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {


                    if (oBLLLoc.Baja(oBELoc) == false)
                    { MessageBox.Show("Para dar de baja la Localidad no debe estar asociada a nignún Cliente"); }
                    else
                    {
                        //actualizo nuevamente la grilla para que refresque los cambios
                        CargarGrilla();
                        //limpio los texbox
                        Limpiar();
                    }

                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Localidad_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        void CargarGrilla()
        {

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = oBLLLoc.ListarTodo();
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }


        //Asigno los valores al objeto
        void Asignar()
        {
            oBELoc.Id = Convert.ToInt32(textcod.Text);
            oBELoc.Descripcion = textNombre.Text;

        }

        void Limpiar()
        {
            textcod.Text = string.Empty;
            textNombre.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBELoc = (BELocalidad)this.dataGridView1.CurrentRow.DataBoundItem;
            textcod.Text = oBELoc.Id.ToString();
            textNombre.Text = oBELoc.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
