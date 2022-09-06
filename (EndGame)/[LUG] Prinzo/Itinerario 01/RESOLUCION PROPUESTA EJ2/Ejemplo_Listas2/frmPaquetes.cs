using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Listas2
{
    public partial class frmPaquetes : Form
    {
        public frmPaquetes()
        {
            InitializeComponent();
        }

        ClsPaquete oPack;
      internal static List<ClsPaquete> LstPaq = new List<ClsPaquete>();
        public enum Tipo : int
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        void limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

        }


        private void frmPaquetes_Load(object sender, EventArgs e)
        {
            //con Enum paso el tipo de la enumeracion Tipo
            this.comboBox1.DataSource = Enum.GetValues(typeof(Tipo));

        }

        int GenerarCodigo()
        {
            Random rnd = new Random();
           return rnd.Next(1, 100);
        }

       string GenerarNombrePack()
        {
            Random rnd = new Random();
            return "Pack"+ rnd.Next(1, 100);
        }

        double GenerarPrecioPack(string TipoPaquete)
        {
            double Precio= 0;
            switch (TipoPaquete)
            {
                case "A":
                    Precio = 100;
                    break;
                case "B":
                    Precio = 200;
                    break;
                case "C":
                    Precio = 300;
                    break;
                case "D":
                    Precio = 400;
                    break;
            }
            return Precio;
        }

        string GenerarTipoPack()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 4);
            string tipo = null;

            switch (a)
            { 
                case 1:
                    tipo= "A";
                    break;
                case 2:
                    tipo = "B";
                    break;
                case 3:
                    tipo = "C";
                    break;
                case 4:
                    tipo = "D";
                    break;
                }
            return tipo;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            oPack = new ClsPaquete();
            oPack.Cod = GenerarCodigo();
            oPack.Nombre = textBox1.Text;
            oPack.Tipo = this.comboBox1.SelectedItem.ToString();
            oPack.PrecioU = Convert.ToDouble(this.textBox2.Text);
            LstPaq.Add(oPack);
            Cargargrillapack();
            limpiar();
        }

        void Cargargrillapack()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LstPaq;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns["Abono"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargaRandom_Click(object sender, EventArgs e)
        {
            oPack = new ClsPaquete();
            oPack.Cod = GenerarCodigo();
            oPack.Nombre = GenerarNombrePack();
            oPack.Tipo = GenerarTipoPack();
            oPack.PrecioU = GenerarPrecioPack(oPack.Tipo);
            LstPaq.Add(oPack);
            Cargargrillapack();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dataGridView1.SelectedRows != null)
                {

                    ClsPaquete oPaC = (ClsPaquete)dataGridView1.CurrentRow.DataBoundItem;
                    oPaC.Clone();
                    LstPaq.Add(oPaC);
                    Cargargrillapack();
                    limpiar();


                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Packete de la grilla para clonar", "Alerta");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
