using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPracticoOrientador
{
    public partial class CargaPersona : Form
    {
        public int dni;
        public CargaPersona()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo del evento de la carga de personas donde se realizan las validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargaPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(txtDni.Text) && !String.IsNullOrEmpty(txtNombre.Text) &&
                    !String.IsNullOrEmpty(txtApellido.Text))
                {
                    txtDni.MaxLength = 8;

                    if(txtDni.MaxLength == 8)
                    {
                        dni = int.Parse(txtDni.Text);
                        this.Close();
                    }
                    else
                    {   
                        MessageBox.Show("Se excedieron la cantidad de caracteres del DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                        
                }
                else
                {
                    MessageBox.Show("debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El dato ingresado no corresponde a su tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void Borrar()
        {
            this.txtDni.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
        }
    }
}
