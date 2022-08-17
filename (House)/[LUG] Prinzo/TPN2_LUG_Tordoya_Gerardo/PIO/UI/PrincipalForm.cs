using System;
using System.Windows.Forms;

namespace UI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm() => InitializeComponent();

        private void MultipleDocumentInterface_Load(object sender, EventArgs e)
        {
            FRM_Login formulario = new FRM_Login()
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Archivo_SalirItem_Click(object sender, EventArgs e) => Application.Exit();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private void ABM_CategoriasItem_Click(object sender, EventArgs e)
        {
            FRM_Categoria formulario = new FRM_Categoria
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_DepartamentosItem_Click(object sender, EventArgs e)
        {
            FRM_Departamento formulario = new FRM_Departamento
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_EmpleadosItem_Click(object sender, EventArgs e)
        {
            FRM_Empleado formulario = new FRM_Empleado
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_ItemsItem_Click(object sender, EventArgs e)
        {
            FRM_Item formulario = new FRM_Item
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_OrdenesItem_Click(object sender, EventArgs e)
        {
            FRM_Orden formulario = new FRM_Orden
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_ProveedoresItem_Click(object sender, EventArgs e)
        {
            FRM_Proveedor formulario = new FRM_Proveedor
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_RolesItem_Click(object sender, EventArgs e)
        {
            FRM_Rol formulario = new FRM_Rol
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Reportes_OrdenesItem_Click(object sender, EventArgs e)
        {
            Ordenes_ItemsForm formulario = new Ordenes_ItemsForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Auditoria_EmpleadosItem_Click(object sender, EventArgs e)
        {
            FRM_XML formulario = new FRM_XML
            {
                MdiParent = this
            };
            formulario.Show();
        }
    }
}
