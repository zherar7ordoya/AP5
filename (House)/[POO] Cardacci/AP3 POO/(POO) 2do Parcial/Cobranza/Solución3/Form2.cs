using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tonattto_POO_2P
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void ConfigurarGrilla(List<DataGridView> _pLDGV)
        {
            foreach (DataGridView _dataGridView in _pLDGV)
            {
                _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _dataGridView.MultiSelect = false;
                _dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                _dataGridView.EnableHeadersVisualStyles = false;
                _dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                _dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                _dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                _dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                _dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla(new List<DataGridView>() { grdPrestamosVencidos});
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
