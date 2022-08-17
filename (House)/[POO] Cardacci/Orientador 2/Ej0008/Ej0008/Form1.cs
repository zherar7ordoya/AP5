using System;
using System.Windows.Forms;

namespace Ej0008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Test T = new Test();
            MessageBox.Show(T.X.ToString());
        }
       
    }
}
