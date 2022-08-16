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
    public partial class CargaAuto : Form
    {
        public CargaAuto()
        {
            InitializeComponent();
        }
        public int ano;
        public decimal precio;
        /// <summary>
        /// Metodo del evento de carga de autos donde se toman ciertas validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtAno.Text) && !String.IsNullOrEmpty(txtMarca.Text) && !String.IsNullOrEmpty(txtModelo.Text) &&
                                !String.IsNullOrEmpty(txtPatente.Text) && !String.IsNullOrEmpty(txtPrecio.Text))
                {

                    ano = int.Parse(txtAno.Text);
                    precio = decimal.Parse(txtPrecio.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception)
            {
                MessageBox.Show("El dato ingresado no corresponde a su tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Borrar()
        {
            this.txtPatente.Clear();
            this.txtMarca.Clear();
            this.txtModelo.Clear();
            this.txtAno.Clear();
            this.txtPrecio.Clear();
        }
    }
}
