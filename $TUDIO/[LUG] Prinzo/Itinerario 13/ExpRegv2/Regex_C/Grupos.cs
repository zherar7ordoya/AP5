using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex_C
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }


        void SetearGrilla() { 
        grdCompras.Columns.Add("cProducto", "Producto");
        grdCompras.Columns.Add("cCantidad", "Cantidad");
        grdCompras.AllowDrop = false;
        grdCompras.AllowUserToAddRows = false;
        grdCompras.AllowUserToDeleteRows = false;
        grdCompras.AllowUserToResizeColumns = false;
        grdCompras.AllowUserToResizeRows = false;
        grdCompras.RowHeadersVisible = false;
       }
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Match oMatch = Regex.Match(this.txtTexto.Text, this.txtExpresion.Text);

            if (!oMatch.Success)
            { MessageBox.Show("El nombre y apellido están mal expresados."); }
            else
            {  MessageBox.Show("Correcto!!!. Su nombre es: " + oMatch.Groups["nombre"].Value + " y su apellido es: " + oMatch.Groups["apellido"].Value);

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.grdCompras.Rows.Clear();
            MatchCollection mMs = Regex.Matches(this.txtCompras.Text, "^\\s*(?<Producto>\\w+)\\s*\\:\\s*(?<Cantidad>\\d+)\\s*$", RegexOptions.Multiline);
            foreach (Match mM in mMs)
            {
                this.grdCompras.Rows.Add(mM.Groups["Producto"].Value, mM.Groups["Cantidad"].Value);
            }
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            txtExpresion.Text = "^(?<nombre>[A-Z][a-z]+)\\s(?<apellido>[A-Z][a-z]+)$";
            SetearGrilla();
        }
    }
}
