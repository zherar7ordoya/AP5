using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Activity10_2
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private DataSet _pubDataSet;

        private void GetData_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author();
                _pubDataSet = author.GetData();
                dgvAuthors.DataSource = _pubDataSet.Tables["Author"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Update_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author();
                author.UpdateData(_pubDataSet.GetChanges());
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
