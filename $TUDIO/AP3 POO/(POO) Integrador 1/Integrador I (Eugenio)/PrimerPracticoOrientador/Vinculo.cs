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
    public partial class Vinculo : Form
    {
        public Vinculo()
        {
            InitializeComponent();
        }
         /// <summary>
         /// Metodo del evento para volver 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
