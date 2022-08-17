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
using BE;

namespace Presentacion_UI
{
    public partial class ABMMaterias : Form
    {
        public ABMMaterias()
        {
            InitializeComponent();
            //instancio el objeto en el constructor del form
            oBLLMat = new BLLMateria();
            oBEMat = new BEMateria();
        }

        BLLMateria oBLLMat;
        BEMateria oBEMat;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        void Limpiar()
        {   textcod.Text = string.Empty;
            textNombre.Text = null;
        }

       
        private void ABMMaterias_Load(object sender, EventArgs e)
        {

        }

       
       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {   //si el txt no tiene codigo es porque es una materia que existe.
                if (textcod.Text != "")
                { oBEMat.Codigo = Convert.ToInt32(textcod.Text); }
                else
                { oBEMat.Codigo = 0; }
                oBEMat.Materia = textNombre.Text;
                //llamo al metodo para guardar
                oBLLMat.Guardar(oBEMat);
                             
                //limpio los texbox
                Limpiar();
                //le paso el OK al diaglo result para que luego se ejecute el metodo cargargrilla y actualizarla
                this.DialogResult = DialogResult.OK;
                //cierro el form actual
                this.Close();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
