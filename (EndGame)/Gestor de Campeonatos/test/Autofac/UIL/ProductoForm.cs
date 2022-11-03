using BEL;
using System;
using System.Windows.Forms;

namespace UIL
{
    public partial class ProductoForm : Form
    {
        IProductoRepository producto_repository;

        public ProductoForm(IProductoRepository producto_repository)
        {
            InitializeComponent();
            this.producto_repository = producto_repository;
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            try
            {
                ProductosDGV.DataSource = producto_repository.GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConteoLabel.Text = $"Total records > {ProductosDGV.RowCount}";
        }
    }
}
