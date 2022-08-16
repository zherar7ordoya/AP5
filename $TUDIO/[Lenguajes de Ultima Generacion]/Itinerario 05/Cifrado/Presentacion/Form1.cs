using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;//hago referencia a la capa de Seguridad

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        this.Btn_Desencripta.Visible = false;
        this.TextBox3.Visible = false;
        this.Label3.Visible = false;
        }

        private void BtnMD5_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ClsEncriptar.GenerarMD5(TextBox1.Text);
        }

        private void BtnSHA_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ClsEncriptar.GenerarSHA(TextBox1.Text);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
        TextBox1.Text = null;
        TextBox2.Text = null;
       TextBox3.Text = null;
       TextBox3.Visible = false;
        Btn_Desencripta.Visible = false;
        this.Label3.Visible = false;
        }

        private void BtnEncripta_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ClsEncriptar.Encriptar(TextBox1.Text);
        Btn_Desencripta.Visible = true;
        Label3.Visible = true;
       TextBox3.Visible = true;
        }

        private void Btn_Desencripta_Click(object sender, EventArgs e)
        {
            TextBox3.Text = ClsEncriptar.Desencriptar(TextBox2.Text);
        TextBox3.Visible = true;
        }
    }
}
