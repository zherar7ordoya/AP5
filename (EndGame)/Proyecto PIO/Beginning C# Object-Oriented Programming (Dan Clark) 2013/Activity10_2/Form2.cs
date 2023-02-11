using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10_2
{
    public partial class Form2 : Form
    {
        public Form2() => InitializeComponent();

        DataSet StoreSalesDataSet;

        private void GetDataButtonClick(object sender, EventArgs e)
        {
            StoreSales storeSales = new StoreSales();
            StoreSalesDataSet = storeSales.GetData();
            dgvStores.DataSource = StoreSalesDataSet.Tables["Stores"];
            dgvSales.DataSource = StoreSalesDataSet.Tables["Stores"];
            dgvSales.DataMember = "StoresToSales";
        }
    }
}
